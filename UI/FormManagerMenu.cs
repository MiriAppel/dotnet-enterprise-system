namespace UI;

public partial class FormManagerMenu : Form
{
    public FormManagerMenu()
    {
        InitializeComponent();
    }

    private void buttonProducts_Click(object sender, EventArgs e)
    {
        FormProduct product = new FormProduct();
        product.ShowDialog();
    }

    private void buttonSales_Click(object sender, EventArgs e)
    {
        FormSale sale = new FormSale();
        sale.ShowDialog();
    }

    private void buttonCustomers_Click(object sender, EventArgs e)
    {
        FormCustomer customer = new FormCustomer();
        customer.ShowDialog();
    }
}
