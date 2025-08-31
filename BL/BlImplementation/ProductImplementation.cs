using BlApi;
using BO;

namespace BlImplementation;

internal class ProductImplementation : IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    
    /// <summary>
    /// הוספת מוצר לרשימה
    /// </summary>
    /// <param name="item">המוצר להוספה</param>
    /// <returns>קוד המוצר שנוסף</returns>
    public int Create(BO.Product item)
    {
        return _dal.Product.Create(item.convertProductToDo());
    }

    /// <summary>
    /// שליפת המוצר שהקוד שלו התקבל
    /// </summary>
    /// <param name="id">קוד המוצר</param>
    /// <returns>המוצר שהקוד שלו התקבל</returns>
    public BO.Product? Read(int id)
    {
        return _dal.Product.Read(id).convertProductToBo();
    }

    /// <summary>
    /// שליפת כל המוצרים ברשימה שעומדים בפרמטר הסינון
    /// </summary>
    /// <param name="filter">פרמטר לסינון</param>
    /// <returns>רשימת המוצרים שעמדו בתנאי הסינון</returns>
    public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
    {
        //return _dal.Product.ReadAll(prod => filter(prod.convertProductToBo()))
        //    .Select(p => p.convertProductToBo()).ToList();
        return _dal.Product.ReadAll()
            .Select(p => p.convertProductToBo())
            .Where(p => filter == null || filter(p))
            .ToList();
    }

    /// <summary>
    /// עדכון המוצר ברשימה - שהתקבל
    /// </summary>
    /// <param name="item">המוצר לעדכון</param>
    public void Update(BO.Product item)
    {
        _dal.Product.Update(item.convertProductToDo());
    }

    /// <summary>
    /// מחיקת מוצר מהרשימה לפי הקוד שהתקבל
    /// </summary>
    /// <param name="id">קוד המוצר למחיקה</param>
    public void Delete(int id)
    {
        _dal.Product.Delete(id);
    }

    /// <summary>
    /// קבלת כל המבצעים שבתוקף של המוצר
    /// </summary>
    /// <param name="idProduct">קוד מוצר</param>
    /// <param name="isPriorityCustomer">האם לקוח מועדף או לא</param>
    /// <returns>כל המבצעים שבתוקף של המוצר</returns>
    public List<BO.SaleInProduct> SaleInForce(int idProduct, bool isPriorityCustomer)
    {
        return _dal.Sale.ReadAll(sale => idProduct == sale.IdProductOfSale && (isPriorityCustomer == true || (isPriorityCustomer ==  false && sale.IsForAllCustomers == true)) && DateTime.Now >= sale.StartSale && DateTime.Now <= sale.EndSale)
            .Select(s => new BO.SaleInProduct()
            {
                IdSale = s.IdSale,
                AmountToSale = s.AmountToGetSale ?? 0,
                IsForAllCustomers = s.IsForAllCustomers ?? false,
                Price = s.SumPrice ?? 0,
            }).ToList();
    }
}
