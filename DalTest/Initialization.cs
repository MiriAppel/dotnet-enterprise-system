using DO;
using DalApi;

namespace DalTest;

public static class Initialization
{
    private static IProduct? s_dalProduct;
    private static ISale? s_dalSale;
    private static ICustomer? s_dalCustomer;
    private static List<int> productIds = new List<int>();

    private static IDal s_dal;

    /// <summary>
    /// יצירת מוצרים חדשים
    /// </summary>
    private static void createProduct()
    {
        productIds.Add(s_dal.Product.Create(new Product(0, "בייביגרו", Categories.בגדים, 80, 50)));
        productIds.Add(s_dal.Product.Create(new Product(0, "כובע פונפון", Categories.שמיכות_וכובעים, 39.9, 35)));
        productIds.Add(s_dal.Product.Create(new Product(0, "Mam בקבוק", Categories.בקבוקים_ומוצצים, 40, 100)));
        productIds.Add(s_dal.Product.Create(new Product(0, "עגלת בוגבו", Categories.עגלות, 5000, 30)));
        productIds.Add(s_dal.Product.Create(new Product(0, "צמיד כסף", Categories.צמידים_ועגילים, 75, 25)));
    }

    /// <summary>
    /// יצירת מבצעים חדשים
    /// </summary>
    private static void createSale()
    {
        s_dal.Sale.Create(new Sale(0, productIds[0], 2, 140, true, DateTime.Today, DateTime.Today.AddDays(7)));
        s_dal.Sale.Create(new Sale(0, productIds[1], 1, 19.9, false, DateTime.Today, DateTime.Today.AddDays(5)));
        s_dal.Sale.Create(new Sale(0, productIds[2], 2, 60, false, DateTime.Today, DateTime.Today.AddDays(3)));
        s_dal.Sale.Create(new Sale(0, productIds[3], 1, 4850, true, DateTime.Today, DateTime.Today.AddDays(10)));
        s_dal.Sale.Create(new Sale(0, productIds[4], 1, 70, true, DateTime.Today, DateTime.Today.AddDays(8)));
    }

    /// <summary>
    /// יצירת לקוחות חדשים
    /// </summary>
    private static void createCustomer()
    {
        s_dal.Customer.Create(new Customer(327742896, "אביגיל מרקוביץ", "מרומי שדה 2", "0556895874"));
        s_dal.Customer.Create(new Customer(365858745, "יעל שטרן", "קצות החושן 4", "0556785962"));
        s_dal.Customer.Create(new Customer(225658745, "מיכל כהן", "אידלסון 6", "025689547"));
        s_dal.Customer.Create(new Customer(223358953, "שירה שוורץ", "זית רענן15", "0527185956"));
        s_dal.Customer.Create(new Customer(328574587, "אפרת שאול", "יהודה הנשיא 5", "0534142314"));
    }

    /// <summary>
    /// אתחול הרשימות באובייקטים
    /// </summary>
    /// <param name="productImp">משתנה גישה לתכונות המוצרים</param>
    /// <param name="saleImp">משתנה גישה לתכונות המבצעים</param>
    /// <param name="customerImp">משתנה גישה לתכונות הלקוחות</param>
    public static void Initialize()
    {
        s_dal = Factory.Get;
        createProduct();
        createSale();
        createCustomer();
    }
}
