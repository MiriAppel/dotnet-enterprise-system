namespace DO;

/// <summary>
/// רשומה לנתוני מוצר
/// </summary>
/// <param name="IdProduct">ברקוד מוצר</param>
/// <param name="ProductName">שם מוצר</param>
/// <param name="Category">קטגוריה</param>
/// <param name="Price">מחיר</param>
/// <param name="AmountInStock">כמות במלאי</param>
public record Product
    (int IdProduct,
    string? ProductName,
    Categories? Category,
    double? Price,
    int? AmountInStock)
{
    public Product() : this(0, null, 0, 0, 0)
    {
    }
}
