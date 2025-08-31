using BlApi;
using BO;

namespace BlImplementation;

internal class OrderImplementation : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    /// <summary>
    /// הוספת מוצר להזמנה
    /// </summary>
    /// <param name="order">הזמנה</param>
    /// <param name="idProduct">מזהה מוצר</param>
    /// <param name="amountToOrder">כמות להזמנה</param>
    /// <returns>רשימת מבצעים שהתקבלו למוצר שנוסף</returns>
    public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int idProduct, int amountToOrder)
    {
        BO.Product p = _dal.Product.Read(idProduct).convertProductToBo();
        if (p == null)
        {
            throw new BlIdNotExistException("מוצר לא קיים");
        }
        List<BO.SaleInProduct> salesThatUsed = new List<BO.SaleInProduct>();
        //חיפוש המוצר ברשימת המוצרים שבהזמנה
        BO.ProductInOrder isProductInOrder = order.ProductsListInOrder.FirstOrDefault(p => p.IdProduct == idProduct);
        //אם המוצר קיים בהזמנה
        if (isProductInOrder != null)
        {
            //בדיקה אם יש כמות מספיקה במלאי כדי להוסיף להזמנה
            if (p.AmountInStock >= isProductInOrder.AmountInOrder + amountToOrder)
            {
                order.ProductsListInOrder.Remove(isProductInOrder);
                isProductInOrder.AmountInOrder += amountToOrder;
                order.ProductsListInOrder.Add(isProductInOrder);
            }
            //אם הכמות במלאי אינה מספיקה
            else
            {
                throw new BO.BlNotEnoughInStockException("אין מספיק במלאי");
            }
        }
        //אם המוצר לא קיים בהזמנה
        else
        {
            if (p.AmountInStock >= amountToOrder)
            {
                //אם יש מספיק - הוספת מוצר חדש להזמנה
                isProductInOrder = new BO.ProductInOrder() { IdProduct = idProduct };
                isProductInOrder.ProductName = p.ProductName;
                isProductInOrder.BasicPriceForProduct = p.Price;
                p.AmountInStock -= amountToOrder;
                isProductInOrder.AmountInOrder = amountToOrder;
                isProductInOrder.SalesListForThisProduct = new List<BO.SaleInProduct>();
                order.ProductsListInOrder.Add(isProductInOrder);
            }
            //אם אין מספיק במלאי
            else
            {
                throw new BO.BlNotEnoughInStockException("אין מספיק במלאי");
            }
        }
        SearchSaleForProduct(isProductInOrder, order.IsPriorityCustomer);
        CalcTotalPriceForProduct(isProductInOrder);
        salesThatUsed = isProductInOrder.SalesListForThisProduct;
        CalcTotalPrice(order);
        return salesThatUsed;
    }

    /// <summary>
    /// עדכון המבצעים המתאימים למוצר בהזמנה
    /// </summary>
    /// <param name="product">מוצר בהזמנה</param>
    /// <param name="isPriorityCustomer">האם ההזמנה היא ללקוח קיים</param>
    public void SearchSaleForProduct(BO.ProductInOrder product, bool isPriorityCustomer)
    {
        try
        {
            product.SalesListForThisProduct = _dal.Sale.ReadAll(sale => product.IdProduct == sale.IdProductOfSale && (isPriorityCustomer == true || (isPriorityCustomer == false && sale.IsForAllCustomers == true)) && DateTime.Now >= sale.StartSale && DateTime.Now <= sale.EndSale)
            .Select(s => new BO.SaleInProduct()
            {
                IdSale = s.IdSale,
                AmountToSale = s.AmountToGetSale ?? 0,
                IsForAllCustomers = s.IsForAllCustomers == false,
                Price = s.SumPrice ?? 0
            }).OrderBy(s => product.FinalPriceForProduct / product.AmountInOrder).ToList();
        }
        catch (BO.BlNotValidInputException e)
        {
            throw new BO.BlNotValidInputException(e.Message);
        }
    }

    /// <summary>
    /// חישוב המחיר הסופי למוצר
    /// </summary>
    /// <param name="product">ProductInOrder מוצר מסוג</param>
    public void CalcTotalPriceForProduct(BO.ProductInOrder product)
    {
        try
        {
            product.FinalPriceForProduct = 0;
            int count = product.AmountInOrder;
            List<BO.SaleInProduct> listSalesUsed = new();
            foreach (BO.SaleInProduct sale in product.SalesListForThisProduct)
            {
                if (count >= sale.AmountToSale)
                {
                    product.FinalPriceForProduct += ((count / sale.AmountToSale) * sale.Price);
                    count = count % sale.AmountToSale;
                    listSalesUsed.Add(sale);
                }
            }
            product.FinalPriceForProduct += (count * product.BasicPriceForProduct);
            product.SalesListForThisProduct = listSalesUsed;
        }
        catch (BO.BlNotValidInputException e)
        {
            throw new BO.BlNotValidInputException(e.Message);
        }
    }

    /// <summary>
    /// חישוב המחיר הסופי להזמנה
    /// </summary>
    /// <param name="order">הזמנה</param>
    public void CalcTotalPrice(BO.Order order)
    {
        try
        {
            order.FinalSumToPay = order.ProductsListInOrder.Sum(p => p.FinalPriceForProduct);
        }
        catch (BO.BlNotValidInputException e)
        {
            throw new BO.BlNotValidInputException(e.Message);
        }
    }

    /// <summary>
    /// ביצוע הזמנה
    /// </summary>
    /// <param name="order">הזמנה</param>
    public void DoOrder(BO.Order order)
    {
        try
        {
            foreach (BO.ProductInOrder product in order.ProductsListInOrder)
            {
                DO.Product p = _dal.Product.Read(product.IdProduct);
                if (p == null)
                {
                    throw new BlIdNotExistException("מוצר לא קיים");
                }
                _dal.Product.Update(p with { AmountInStock = p.AmountInStock - product.AmountInOrder });
            }
        }
        catch (BO.BlNotValidInputException e)
        {
            throw new BO.BlNotValidInputException(e.Message);
        }
    }
}
