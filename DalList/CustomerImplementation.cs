namespace Dal;
using DO;
using DalApi;
using System.Linq;
using Tools;
using System.Reflection;

internal class CustomerImplementation : ICustomer
{
    /// <summary>
    /// הוספת לקוח לרשימה
    /// </summary>
    /// <param name="customer">הלקוח להוספה</param>
    /// <returns>ת"ז הלקוח שנוסף</returns>
    /// <exception cref="Exception">שגיאה אם כבר קיים לקוח עם מס' ת"ז כזה</exception>
    public int Create(Customer customer)
    {
        if (DataSource.Customers.Any(c => c.Identity == customer.Identity))
            throw new DalIdExistException(@"ת""ז לקוח כבר קיים, הלקוח לא נוסף");
        else
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
            DataSource.Customers.Add(customer);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return customer.Identity;
        }
    }

    /// <summary>
    /// שליפת הלקוח שהת"ז שלו התקבל
    /// </summary>
    /// <param name="id">ת"ז הלקוח</param>
    /// <returns>הלקוח שהת"ז שלו התקבל</returns>
    /// <exception cref="Exception">שגיאה אם הלקוח לא קיים</exception>
    public Customer? Read(int id)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
            Customer c = DataSource.Customers.First(c => c.Identity == id);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return c;
        }
        catch
        {
            throw new DalIdNotExistException("מזהה לקוח לא קיים");
        }
    }

    /// <summary>
    /// שליפת לקוח לפי פרמטר סינון
    /// </summary>
    /// <param name="filter">פרמטר לסינון</param>
    /// <returns>הלקוח שעמד בתנאי הסינון</returns>
    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Customer c = DataSource.Customers.FirstOrDefault(filter);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        return c;
    }

    ///// <summary>
    ///// שליפת כל הלקוחות ברשימה
    ///// </summary>
    ///// <returns>רשימת הלקוחות</returns>
    //public List<Customer?> ReadAll()
    //{
    //    return new List<Customer?>(DataSource.Customers);
    //}

    /// <summary>
    /// שליפת כל הלקוחות ברשימה שעומדים בפרמטר הסינון
    /// </summary>
    /// <param name="filter">פרמטר לסינון</param>
    /// <returns>רשימת הלקוחות שעמדו בתנאי הסינון</returns>
    /// 
    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        if (filter == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return new List<Customer?>(DataSource.Customers);
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        return DataSource.Customers.Where(filter).ToList();
    }

    /// <summary>
    /// עדכון הלקוח ברשימה - שהתקבל
    /// </summary>
    /// <param name="customer">הלקוח לעדכון</param>
    /// <exception cref="Exception">שגיאה אם הלקוח לא קיים</exception>
    public void Update(Customer customer)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Delete(customer.Identity);
        DataSource.Customers.Add(customer);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
    }

    /// <summary>
    /// מחיקת לקוח מהרשימה לפי הת"ז שהתקבל
    /// </summary>
    /// <param name="id">ת"ז הלקוח למחיקה</param>
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Customer c = Read(id);
        DataSource.Customers.Remove(c);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
    }
}
