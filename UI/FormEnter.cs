namespace UI;

public partial class FormEnter : Form
{
    public FormEnter()
    {
        InitializeComponent();
    }

    private void buttonManager_Click(object sender, EventArgs e)
    {
        FormManagerMenu managerMenu = new FormManagerMenu();
        managerMenu.ShowDialog();
    }

    private void buttonShopkeeper_Click(object sender, EventArgs e)
    {
        FormLogin login = new FormLogin();
        login.ShowDialog();
    }
}