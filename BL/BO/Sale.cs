namespace BO;

/// <summary>
/// רשומה לנתוני מבצע
/// </summary>
public class Sale
{
    public int IdSale { get; init; } // מספר מזהה של המבצע
    public int IdProductOfSale { get; set ; } // מספר מזהה של המוצר
    public int AmountToGetSale { get; set; } // כמות נדרשת לקבלת המבצע
    public double SumPrice { get; set; } // מחיר כולל במבצע
    public bool IsForAllCustomers { get; set; } // האם המבצע מיועד לכלל הלקוחות או רק ללקוחות מועדון
    public DateTime StartSale { get; set; } // תאריך תחילת המבצע
    public DateTime EndSale { get; set; } // תאריך סיום המבצע

    /// <summary>
    /// תכונות מבצע 
    /// </summary>
    /// <returns>מחרוזת של תכונות מבצע</returns>
    public override string ToString() => this.ToStringProperty();
}
