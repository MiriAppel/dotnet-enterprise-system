using BO;

namespace UI;

public partial class FormOrder : Form
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

    Order order = new Order();
    int custId;
    bool isClubCustomer = false;

    public FormOrder(int identity)
    {
        InitializeComponent();

        comboBoxNameProduct.DataSource = s_bl.Product.ReadAll().ToList();
        comboBoxNameProduct.DisplayMember = "ProductName";   // מה שמוצג למשתמש
        comboBoxNameProduct.ValueMember = "IdProduct";       // המזהה הפנימי
        try
        {
            custId = identity;
            if (s_bl.Customer.isExistCustomer(custId))
            {
                order.IsPriorityCustomer = true;
                isClubCustomer = true;
                BO.Customer c = new BO.Customer();
                c = s_bl.Customer.Read(custId);
                labelHello.Text = "שלום " + c.CustomerName + "!";
            }
            else
            {
                labelHello.Text = "שלום לקוח חדש!";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonAddToOrder_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxNameProduct.SelectedValue != null)
            {
                int id = int.Parse(comboBoxNameProduct.SelectedValue.ToString());
                s_bl.Order.AddProductToOrder(order, id, (int)numericUpDownAmountToOrder.Value);
                listBoxOrder.Items.Clear();
                foreach (var product in order.ProductsListInOrder)
                {
                    listBoxOrder.Items.Add("שם מוצר: " + product.ProductName + ", כמות: " + product.AmountInOrder + ", מחיר ליחידה: " + product.BasicPriceForProduct + ", מחיר כולל: " + product.FinalPriceForProduct);
                }
                comboBoxNameProduct.SelectedItem = null;
                numericUpDownAmountToOrder.Value = 1;
            }
            else
            {
                MessageBox.Show("לא נבחר מוצר");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonFinishOrder_Click(object sender, EventArgs e)
    {
        try
        {
            s_bl.Order.DoOrder(order);
            order.ProductsListInOrder.Clear();

            labelTotalPrice.Text = $"{order.FinalSumToPay} ₪";
            MessageBox.Show(@$" ₪ההזמנה בוצעה בהצלחה! סה""כ לתשלום: {order.FinalSumToPay}");

            listBoxOrder.Items.Clear();
            labelTotalPrice.Text = "0 ₪";
            labelHello.Text = string.Empty;
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
