namespace DO;

/// <summary>
/// רשומה לנתוני לקוח
/// </summary>
/// <param name="Identity">תעודת זהות</param>
/// <param name="CustomerName">שם לקוח</param>
/// <param name="Address">כתובת</param>
/// <param name="Phone">טלפון</param>
public record Customer
    (int Identity,
    string? CustomerName,
    string? Address,
    string? Phone)
{
    public Customer() : this(0, null, null, null)
    {
    }
}
