namespace UI;

public partial class FormLogin : Form
{
    public FormLogin()
    {
        InitializeComponent();
    }

    private void buttonStartOrder_Click(object sender, EventArgs e)
    {
        try
        {
            FormOrder order = new FormOrder(int.Parse(textBoxIdentityCustomer.Text));
            order.ShowDialog();
            textBoxIdentityCustomer.Text = string.Empty;
        }
        catch
        {
            MessageBox.Show(@"ת""ז לא תקינה");
            textBoxIdentityCustomer.Text = string.Empty;
        }
    }
}
