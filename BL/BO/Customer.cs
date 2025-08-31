namespace BO;

/// <summary>
/// רשומה לנתוני לקוח
/// </summary>
public class Customer
{
    public int Identity { get; init; } // תעודת זהות
    public string CustomerName { get; set; } // שם לקוח
    public string? Address { get; set; } // כתובת
    public string Phone { get; set; } // טלפון

    public Customer () { }

    public Customer(int identity, string customerName, string address, string phone)
    {
        Identity = identity;
        CustomerName = customerName;
        Address = address;
        Phone = phone;
    }

    /// <summary>
    /// תכונות לקוח 
    /// </summary>
    /// <returns>מחרוזת של תכונות לקוח</returns>
    public override string ToString() => this.ToStringProperty();
}
