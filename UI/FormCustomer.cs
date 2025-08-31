using BO;

namespace UI;

public partial class FormCustomer : Form
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

    public FormCustomer()
    {
        InitializeComponent();

        comboBoxReadOne.DataSource = s_bl.Customer.ReadAll().ToList();
        comboBoxReadOne.DisplayMember = "Identity";   // מה שמוצג למשתמש
        comboBoxReadOne.ValueMember = "Identity";       // המזהה הפנימי

        comboBoxIdentityUpdate.DataSource = s_bl.Customer.ReadAll().ToList();
        comboBoxIdentityUpdate.DisplayMember = "Identity";   // מה שמוצג למשתמש
        comboBoxIdentityUpdate.ValueMember = "Identity";       // המזהה הפנימי

        comboBoxDelete.DataSource = s_bl.Customer.ReadAll().ToList();
        comboBoxDelete.DisplayMember = "Identity";    // מה שמוצג למשתמש
        comboBoxDelete.ValueMember = "Identity";        // המזהה הפנימי
    }

    private void refreshComboBoxes()
    {
        var customers = s_bl.Customer.ReadAll().ToList();
        comboBoxReadOne.DataSource = customers;
        comboBoxIdentityUpdate.DataSource = customers;
        comboBoxDelete.DataSource = customers;
    }

    private void buttonCreate_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxIdentityCreate.Text) ||
                string.IsNullOrWhiteSpace(textBoxNameCreate.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddressCreate.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhoneCreate.Text))
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }

            Customer c = new Customer
            (
                int.Parse(textBoxIdentityCreate.Text),
                textBoxNameCreate.Text,
                textBoxAddressCreate.Text,
                textBoxPhoneCreate.Text
            );

            s_bl.Customer.Create(c);
            MessageBox.Show("!הלקוח נוסף בהצלחה");

            textBoxIdentityCreate.Clear();
            textBoxNameCreate.Clear();
            textBoxAddressCreate.Clear();
            textBoxPhoneCreate.Clear();
            refreshComboBoxes();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonReadAll_Click(object sender, EventArgs e)
    {
        try
        {
            listBoxRead.DataSource = null;
            listBoxRead.Items.Clear();
            List<Customer> listCustomer = new List<Customer>();
            listCustomer = s_bl.Customer.ReadAll();
            listBoxRead.DataSource = listCustomer.SelectMany(c => c.ToString().Split("\n")).ToList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonReadAllWithFilter_Click(object sender, EventArgs e)
    {
        try
        {
            listBoxRead.DataSource = null;
            listBoxRead.Items.Clear();
            List<Customer> listCustomer = new List<Customer>();
            listCustomer = s_bl.Customer.ReadAll(c => c.Phone.Length > 1 && c.Phone[1] == '8');
            listBoxRead.DataSource = listCustomer.SelectMany(c => c.ToString().Split("\n")).ToList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonReadOne_Click(object sender, EventArgs e)
    {
        try
        {
            listBoxRead.DataSource = null;
            listBoxRead.Items.Clear();
            int id = int.Parse(comboBoxReadOne.SelectedValue.ToString());
            Customer customer = s_bl.Customer.Read(id);
            List<string> customerDetails = new List<string>
                {
                    "Identity: " + customer.Identity,
                    "Name: " + customer.CustomerName,
                    "Address: " + customer.Address,
                    "Phone: " + customer.Phone
                };
            listBoxRead.DataSource = customerDetails;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void comboBoxIdentityUpdate_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxIdentityUpdate.SelectedValue == null)
            {
                MessageBox.Show("לא נבחר לקוח");
                return;
            }

            int id;
            if (!int.TryParse(comboBoxIdentityUpdate.SelectedValue.ToString(), out id))
            {
                MessageBox.Show("בחרת בקטגורית לקוחות");
                return;
            }

            Customer customer = s_bl.Customer.Read(id);
            if (customer != null)
            {
                comboBoxIdentityUpdate.SelectedValue = customer.Identity;
                textBoxNameUpdate.Text = customer.CustomerName;
                textBoxAddressUpdate.Text = customer.Address;
                textBoxPhoneUpdate.Text = customer.Phone;
            }
            else
            {
                MessageBox.Show("לקוח לא נמצא");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxIdentityUpdate.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxNameUpdate.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddressUpdate.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhoneUpdate.Text))
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }

            int id = int.Parse(comboBoxIdentityUpdate.SelectedValue.ToString());
            List<Customer> customers = new List<Customer>();
            customers = s_bl.Customer.ReadAll();
            Customer c = customers.FirstOrDefault(i => i.Identity == id);
            c.CustomerName = textBoxNameUpdate.Text;
            c.Address = textBoxAddressUpdate.Text;
            c.Phone = textBoxPhoneUpdate.Text;

            if (comboBoxIdentityUpdate.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxNameUpdate.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddressUpdate.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhoneUpdate.Text))
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }

            s_bl.Customer.Update(c);
            MessageBox.Show("!השינויים נשמרו");

            comboBoxIdentityUpdate.SelectedValue = null;
            textBoxNameUpdate.Clear();
            textBoxAddressUpdate.Clear();
            textBoxPhoneUpdate.Clear();
            refreshComboBoxes();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        try
        {
            int id = int.Parse(comboBoxDelete.SelectedValue.ToString());
            s_bl.Customer.Delete(id);
            MessageBox.Show("!הלקוח נמחק בהצלחה");
            comboBoxDelete.SelectedItem = null;
            refreshComboBoxes();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
