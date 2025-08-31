namespace BO;

/// <summary>
/// רשומה לנתוני מוצר
/// </summary>
public class Product
{
    public int IdProduct { get; init; } // ברקוד מוצר
    public string ProductName { get; set; } // שם מוצר
    public Categories? Category { get; set; } // קטגוריה
    public double Price { get; set; } // מחיר
    public int AmountInStock { get; set; } // כמות במלאי
    public List<SaleInProduct> SalesListForProduct { get; set; } // רשימת מבצעים למוצר
    public object ToStringProperty { get; set; }

    /// <summary>
    /// תכונות מוצר 
    /// </summary>
    /// <returns>מחרוזת של תכונות מוצר</returns>
    public override string ToString() => this.ToStringProperty();
}
