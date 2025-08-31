namespace Dal;
using DO;
using DalApi;
using Tools;
using System.Reflection;

internal class ProductImplementation : IProduct
{
    /// <summary>
    /// הוספת מוצר לרשימה
    /// </summary>
    /// <param name="item">המוצר להוספה</param>
    /// <returns>קוד המוצר שנוסף</returns>
    public int Create(Product item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Product p = item with { IdProduct = DataSource.Config.ProductId };
        DataSource.Products.Add(p);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        return p.IdProduct;
    }

    /// <summary>
    /// שליפת המוצר שהקוד שלו התקבל
    /// </summary>
    /// <param name="id">קוד המוצר</param>
    /// <returns>המוצר שהקוד שלו התקבל</returns>
    /// <exception cref="Exception">שגיאה אם המוצר לא נמצא</exception>
    public Product? Read(int id)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
            Product p = DataSource.Products.First(p => p.IdProduct == id);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return p;
        }
        catch
        {
            throw new DalIdNotExistException("מזהה מוצר לא קיים");
        }
    }

    /// <summary>
    /// שליפת מוצר לפי פרמטר סינון
    /// </summary>
    /// <param name="filter">פרמטר לסינון</param>
    /// <returns>המוצר שעמד בתנאי הסינון</returns>
    public Product? Read(Func<Product, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Product p = DataSource.Products.FirstOrDefault(filter);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        return p;
    }

    ///// <summary>
    ///// שליפת כל המוצרים ברשימה
    ///// </summary>
    ///// <returns>רשימת המוצרים</returns>
    //public List<Product?> ReadAll()
    //{
    //    return new List<Product?>(DataSource.Products);
    //}

    /// <summary>
    /// שליפת כל המוצרים ברשימה שעומדים בפרמטר הסינון
    /// </summary>
    /// <param name="filter">פרמטר לסינון</param>
    /// <returns>רשימת המוצרים שעמדו בתנאי הסינון</returns>
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        if (filter == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return new List<Product?>(DataSource.Products);
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        return DataSource.Products.Where(filter).ToList();
    }

    /// <summary>
    /// עדכון המוצר ברשימה - שהתקבל
    /// </summary>
    /// <param name="item">המוצר לעדכון</param>
    /// <exception cref="Exception">שגיאה אם המוצר לא נמצא</exception>
    public void Update(Product item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Delete(item.IdProduct);
        DataSource.Products.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
    }

    /// <summary>
    /// מחיקת מוצר מהרשימה לפי הקוד שהתקבל
    /// </summary>
    /// <param name="id">קוד המוצר למחיקה</param>
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Product p = Read(id);
        DataSource.Products.Remove(p);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
    }
}
