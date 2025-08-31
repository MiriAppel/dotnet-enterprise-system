namespace Dal;
using DO;
using DalApi;
using System.Linq;
using Tools;
using System.Reflection;

internal class SaleImplementation : ISale
{
    /// <summary>
    /// הוספת מבצע לרשימה
    /// </summary>
    /// <param name="sale">המבצע להוספה</param>
    /// <returns>קוד המבצע שנוסף</returns>
    public int Create(Sale sale)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Sale s = sale with { IdSale = DataSource.Config.SaleId };
        DataSource.Sales.Add(s);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        return s.IdSale;
    }

    /// <summary>
    /// שליפת המבצע שהקוד שלו התקבל
    /// </summary>
    /// <param name="id">קוד המבצע</param>
    /// <returns>המבצע שהקוד שלו התקבל</returns>
    /// <exception cref="Exception">שגיאה אם המבצע לא קיים</exception>
    public Sale? Read(int id)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
            Sale s = DataSource.Sales.First(s => s.IdSale == id);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return s;
        }
        catch
        {
            throw new DalIdNotExistException("מזהה מבצע לא קיים");
        }
    }

    /// <summary>
    /// שליפת מבצע לפי פרמטר סינון
    /// </summary>
    /// <param name="filter">פרמטר לסינון</param>
    /// <returns>המבצע שעמד בתנאי הסינון</returns>
    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Sale s = DataSource.Sales.FirstOrDefault(filter);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        return s;
    }

    ///// <summary>
    ///// שליפת כל המבצעים ברשימה
    ///// </summary>
    ///// <returns>רשימת המבצעים</returns>
    //public List<Sale?> ReadAll()
    //{
    //    return new List<Sale?>(DataSource.Sales);
    //}

    /// <summary>
    /// שליפת כל המבצעים ברשימה שעומדים בפרמטר הסינון
    /// </summary>
    /// <param name="filter">פרמטר לסינון</param>
    /// <returns>רשימת המבצעים שעמדו בתנאי הסינון</returns>
    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        if (filter == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return new List<Sale?>(DataSource.Sales);
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        return DataSource.Sales.Where(filter).ToList();
    }

    /// <summary>
    /// עדכון המבצע ברשימה - שהתקבל
    /// </summary>
    /// <param name="sale">המבצע לעדכון</param>
    /// <exception cref="Exception">שגיאה אם המבצע לא קיים</exception>
    public void Update(Sale sale)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Delete(sale.IdSale);
        DataSource.Sales.Add(sale);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
    }

    /// <summary>
    /// מחיקת מבצע מהרשימה לפי הקוד שהתקבל
    /// </summary>
    /// <param name="id">קוד המבצע למחיקה</param>
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Sale s = Read(id);
        DataSource.Sales.Remove(s);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
    }
}
