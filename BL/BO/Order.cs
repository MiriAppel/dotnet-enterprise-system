namespace BO;

/// <summary>
/// רשומה לנתוני הזמנה
/// </summary>
public class Order
{
    public bool IsPriorityCustomer { get; set; } // האם זו הזמנה של לקוח מועדף או לקוח מזדמן
    public List<ProductInOrder> ProductsListInOrder { get; set; } = new List<ProductInOrder>(); // רשימת המוצרים בהזמנה
    public double FinalSumToPay { get; set; } // המחיר הסופי לתשלום

    /// <summary>
    /// תכונות הזמנה 
    /// </summary>
    /// <returns>מחרוזת של תכונות הזמנה</returns>
    public override string ToString() => this.ToStringProperty();
}
