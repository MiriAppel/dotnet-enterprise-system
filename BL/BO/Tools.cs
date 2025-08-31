using System.Collections;
using System.Reflection;
using System.Text;

namespace BO;

internal static class Tools
{
    /// <summary>
    /// BO-המרת מוצר ל
    /// </summary>
    /// <param name="productDo">DO-מוצר מ</param>
    /// <returns>BO מוצר</returns>
    public static BO.Product convertProductToBo(this DO.Product productDo)
    {
        BO.Product product = new BO.Product
        //(
        //productDo.IdProduct,
        //productDo.ProductName,
        //(BO.Categories)productDo.Category,
        //productDo.Price ?? 0,
        //productDo.AmountInStock ?? 0
        //);
        {
            IdProduct = productDo.IdProduct,
            ProductName = productDo.ProductName,
            Category = (BO.Categories)productDo.Category,
            Price = productDo.Price ?? 0,
            AmountInStock = productDo.AmountInStock ?? 0
        };
        return product;
    }

    /// <summary>
    /// BO-המרת לקוח ל
    /// </summary>
    /// <param name="customerDo">DO-לקוח מ</param>
    /// <returns>BO לקוח</returns>
    public static BO.Customer convertCustomerToBo(this DO.Customer customerDo)
    {
        BO.Customer customer = new BO.Customer
        (
            customerDo.Identity,
            customerDo.CustomerName,
            customerDo.Address,
            customerDo.Phone
        );
        return customer;
    }

    /// <summary>
    /// BO-המרת מבצע ל
    /// </summary>
    /// <param name="saleDo">DO-מבצע מ</param>
    /// <returns>BO מבצע</returns>
    public static BO.Sale convertSaleToBo(this DO.Sale saleDo)
    {
        BO.Sale sale = new BO.Sale
        {
            IdSale = saleDo.IdSale,
            IdProductOfSale = saleDo.IdProductOfSale ?? 0,
            AmountToGetSale = saleDo.AmountToGetSale ?? 1,
            SumPrice = saleDo.SumPrice ?? 0,
            IsForAllCustomers = saleDo.IsForAllCustomers ?? true,
            StartSale = saleDo.StartSale ?? DateTime.Now,
            EndSale = saleDo.EndSale ?? DateTime.Now.AddDays(1),
        };
        return sale;
    }

    /// <summary>
    /// DO-המרת מוצר ל
    /// </summary>
    /// <param name="productBo">BO-מוצר מ</param>
    /// <returns>DO מוצר</returns>
    public static DO.Product convertProductToDo(this BO.Product productBo)
    {
        DO.Product product = new DO.Product
        {
            IdProduct = productBo.IdProduct,
            ProductName = productBo.ProductName,
            Category = (DO.Categories)productBo.Category,
            Price = productBo.Price,
            AmountInStock = productBo.AmountInStock
        };
        return product;
    }

    /// <summary>
    /// DO-המרת לקוח ל
    /// </summary>
    /// <param name="customerBo">BO-לקוח מ</param>
    /// <returns>DO לקוח</returns>
    public static DO.Customer convertCustomerToDo(this BO.Customer customerBo)
    {
        DO.Customer customer = new DO.Customer
        {
            Identity = customerBo.Identity,
            CustomerName = customerBo.CustomerName,
            Address = customerBo.Address,
            Phone = customerBo.Phone
        };
        return customer;
    }

    /// <summary>
    /// DO-המרת מבצע ל
    /// </summary>
    /// <param name="saleBo">BO-מבצע מ</param>
    /// <returns>DO מבצע</returns>
    public static DO.Sale convertSaleToDo(this BO.Sale saleBo)
    {
        DO.Sale sale = new DO.Sale
        {
            IdSale = saleBo.IdSale,
            IdProductOfSale = saleBo.IdProductOfSale,
            AmountToGetSale = saleBo.AmountToGetSale,
            SumPrice = saleBo.SumPrice,
            IsForAllCustomers = saleBo.IsForAllCustomers,
            StartSale = saleBo.StartSale,
            EndSale = saleBo.EndSale,
        };
        return sale;
    }

    /// <summary>
    /// תכונות הישות
    /// </summary>
    /// <typeparam name="T">product/sale/customer</typeparam>
    /// <param name="obj">מוצר/מבצע/לקוח</param>
    /// <returns>מחרוזת של תכונות הישות</returns>

    public static string ToStringProperty<T>(this T t)
    {
        string str = "";
        Type Ttype = t.GetType();
        PropertyInfo[] info = Ttype.GetProperties();
        foreach (PropertyInfo item in info)
        {
            if (typeof(IEnumerable).IsAssignableFrom(item.PropertyType) && item.PropertyType != typeof(string))
            {
                IEnumerable collection = item.GetValue(t) as IEnumerable;
                if (collection != null)
                {
                    foreach (var x in collection)
                    {
                        str += x.ToStringProperty();
                    }
                }
                else
                {
                    str += string.Format("{0}: {1}  \n", item.Name, item.GetValue(t, null));
                }
            }
            else
                str += string.Format("{0}: {1}  \n", item.Name, item.GetValue(t, null));
        }
        return str;
    }
}
