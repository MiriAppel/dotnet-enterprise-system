namespace DO;

/// <summary>
/// רשומה לנתוני מבצע
/// </summary>
/// <param name="IdSale">מספר מזהה של המבצע</param>
/// <param name="IdProductOfSale">מספר מזהה של המוצר</param>
/// <param name="AmountToGetSale">כמות נדרשת לקבלת המבצע</param>
/// <param name="SumPrice">מחיר כולל במבצע</param>
/// <param name="IsForAllCustomers">האם המבצע מיועד לכלל הלקוחות או רק ללקוחות מועדון</param>
/// <param name="StartSale">תאריך תחילת המבצע</param>
/// <param name="EndSale">תאריך סיום המבצע</param>
public record Sale
    (int IdSale,
    int? IdProductOfSale,
    int? AmountToGetSale,
    double? SumPrice,
    bool? IsForAllCustomers,
    DateTime? StartSale,
    DateTime? EndSale)
{
    public Sale() : this(0, 0, 0, 0, false, DateTime.Now, DateTime.Now)
    {
    }
}
