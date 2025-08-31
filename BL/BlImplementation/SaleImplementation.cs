using BlApi;
using BO;

namespace BlImplementation;

internal class SaleImplementation : ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    /// <summary>
    /// הוספת מבצע לרשימה
    /// </summary>
    /// <param name="item">המבצע להוספה</param>
    /// <returns>קוד המבצע שנוסף</returns>
    public int Create(BO.Sale item)
    {
        return _dal.Sale.Create(item.convertSaleToDo());
    }

    /// <summary>
    /// שליפת המבצע שהקוד שלו התקבל
    /// </summary>
    /// <param name="id">קוד המבצע</param>
    /// <returns>המבצע שהקוד שלו התקבל</returns>
    public BO.Sale? Read(int id)
    {
        return _dal.Sale.Read(id).convertSaleToBo();
    }

    /// <summary>
    /// שליפת כל המבצעים ברשימה שעומדים בפרמטר הסינון
    /// </summary>
    /// <param name="filter">פרמטר לסינון</param>
    /// <returns>רשימת המבצעים שעמדו בתנאי הסינון</returns>
    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        //return _dal.Sale.ReadAll(sale => filter(sale.convertSaleToBo()))
        //    .Select(s => s.convertSaleToBo()).ToList();
        return _dal.Sale.ReadAll()
            .Select(s => s.convertSaleToBo())
            .Where(s => filter == null || filter(s))
            .ToList();
    }

    /// <summary>
    /// עדכון המבצע ברשימה - שהתקבל
    /// </summary>
    /// <param name="item">המבצע לעדכון</param>
    public void Update(BO.Sale item)
    {
        _dal.Sale.Update(item.convertSaleToDo());
    }

    /// <summary>
    /// מחיקת מבצע מהרשימה לפי הקוד שהתקבל
    /// </summary>
    /// <param name="id">קוד המבצע למחיקה</param>
    public void Delete(int id)
    {
        _dal.Sale.Delete(id);
    }
}
