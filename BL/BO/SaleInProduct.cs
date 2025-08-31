namespace BO;

/// <summary>
/// עזר לתיאור מבצע של מוצר
/// </summary>
public class SaleInProduct
{
    public int IdSale { get; init; } // מזהה מבצע
    public int AmountToSale { get; set; } // כמות למבצע
    public double Price { get; set; } // מחיר
    public bool IsForAllCustomers { get; set; } // האם המבצע מיועד לכל הלקוחות

    /// <summary>
    /// תכונות עזר לתיאור מבצע של מוצר 
    /// </summary>
    /// <returns>מחרוזת של תכונות עזר לתיאור מבצע של מוצר</returns>
    public override string ToString() => this.ToStringProperty();
}
