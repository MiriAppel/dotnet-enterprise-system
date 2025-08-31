using BlApi;
using BO;

namespace BlImplementation;

internal class CustomerImplementation : ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    /// <summary>
    /// הוספת לקוח לרשימה
    /// </summary>
    /// <param name="item">להוספה BO לקוח</param>
    /// <returns>מחזיר את ת"ז הלקוח שנוסף</returns>
    public int Create(BO.Customer item)
    {
        return _dal.Customer.Create(item.convertCustomerToDo());
    }

    /// <summary>
    /// שליפת הלקוח שהת"ז שלו התקבל
    /// </summary>
    /// <param name="id">ת"ז הלקוח</param>
    /// <returns>מחזיר את הלקוח</returns>
    public BO.Customer? Read(int id)
    {
        return _dal.Customer.Read(id).convertCustomerToBo();
    }

    /// <summary>
    /// שליפת כל הלקוחות ברשימה שעומדים בפרמטר הסינון
    /// </summary>
    /// <param name="filter">פרמטר לסינון</param>
    /// <returns>רשימת הלקוחות שעמדו בתנאי הסינון</returns>
    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        var customers = _dal.Customer.ReadAll();

        if (filter == null)
        {
            return customers.Select(c => c.convertCustomerToBo()).ToList();
        }

        return customers
            .Where(c => c != null && filter(c.convertCustomerToBo()))
            .Select(c => c.convertCustomerToBo())
            .ToList();
        //return _dal.Customer.ReadAll(cust => filter(cust.convertCustomerToBo()))
        //    .Select(c => c.convertCustomerToBo()).ToList();
    }

    /// <summary>
    /// עדכון הלקוח ברשימה - שהתקבל
    /// </summary>
    /// <param name="item">הלקוח לעדכון</param>
    public void Update(BO.Customer item)
    {
        _dal.Customer.Update(item.convertCustomerToDo());
    }

    /// <summary>
    /// מחיקת לקוח מהרשימה לפי הת"ז שהתקבל
    /// </summary>
    /// <param name="id">ת"ז הלקוח למחיקה</param>
    public void Delete(int id)
    {
        _dal.Customer.Delete(id);
    }

    /// <summary>
    /// בדיקה האם לקוח קיים
    /// </summary>
    /// <param name="id">ת"ז הלקוח לבדיקה</param>
    /// <returns>false-אם לא קיים ,true-אם קיים</returns>
    public bool isExistCustomer(int id)
    {
        try
        {
            _dal.Customer.Read(id).convertCustomerToBo();
            return true;
        }
        catch 
        { 
            return false;
        }
    }
}
