namespace BO;

/// <summary>
/// עזר לתיאור מוצר בהזמנה
/// </summary>
public class ProductInOrder
{
    public int IdProduct { get; init; } // מזהה מוצר
    public string ProductName { get; set; } // שם מוצר
    public double BasicPriceForProduct { get; set; } // מחיר בסיס למוצר
    public int AmountInOrder { get; set; } // כמות בהזמנה
    public List<SaleInProduct> SalesListForThisProduct { get; set; } // רשימת מבצעים למוצר זה
    public double FinalPriceForProduct { get; set; } // מחיר סופי למוצר

    /// <summary>
    /// תכונות עזר לתיאור מוצר בהזמנה 
    /// </summary>
    /// <returns>מחרוזת של תכונות עזר לתיאור מוצר בהזמנה</returns>
    public override string ToString() => this.ToStringProperty();
}
