using BO;

namespace UI;

public partial class FormSale : Form
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

    public FormSale()
    {
        InitializeComponent();

        comboBoxCreate.DataSource = s_bl.Product.ReadAll().ToList();
        comboBoxCreate.DisplayMember = "ProductName";   // מה שמוצג למשתמש
        comboBoxCreate.ValueMember = "IdProduct";              // המזהה הפנימי

        comboBoxReadOne.DataSource = s_bl.Product.ReadAll().ToList();
        comboBoxReadOne.DisplayMember = "ProductName";   // מה שמוצג למשתמש
        comboBoxReadOne.ValueMember = "IdProduct";       // המזהה הפנימי

        comboBoxIdSaleUpdate.DataSource = s_bl.Sale.ReadAll().ToList();
        comboBoxIdSaleUpdate.DisplayMember = "IdSale";   // מה שמוצג למשתמש
        comboBoxIdSaleUpdate.ValueMember = "IdSale";     // המזהה הפנימי

        comboBoxDelete.DataSource = s_bl.Sale.ReadAll().ToList();
        comboBoxDelete.DisplayMember = "IdSale";    // מה שמוצג למשתמש
        comboBoxDelete.ValueMember = "IdSale";      // המזהה הפנימי
    }

    private void refreshComboBoxes()
    {
        var sales = s_bl.Sale.ReadAll().ToList();
        var products = s_bl.Product.ReadAll().ToList();
        comboBoxCreate.DataSource = products;
        comboBoxReadOne.DataSource = products;
        comboBoxIdSaleUpdate.DataSource = sales;
        comboBoxDelete.DataSource = sales;
    }

    private void buttonCreate_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxCreate.SelectedItem == null ||
                numericUpDownAmountToGetSale.Value <= 0 ||
                numericUpDownSumPrice.Value <= 0 ||
                (radioButtonAllCustomer.Checked == false && radioButtonFavoriteCustomer.Checked == false))
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }

            bool flag = false;
            if (radioButtonAllCustomer.Checked)
            {
                flag = true;
            }

            Sale s = new Sale();
            s.IdProductOfSale = int.Parse(comboBoxCreate.SelectedValue.ToString());
            s.AmountToGetSale = (int)numericUpDownAmountToGetSale.Value;
            s.SumPrice = (double)numericUpDownSumPrice.Value;
            s.IsForAllCustomers = flag;
            s.StartSale = dateTimePickerStartSale.Value;
            s.EndSale = dateTimePickerEndSale.Value;

            s_bl.Sale.Create(s);
            MessageBox.Show("!המבצע נוסף בהצלחה");

            comboBoxCreate.SelectedItem = null;
            numericUpDownAmountToGetSale.Value = 1;
            numericUpDownSumPrice.Value = 1;
            radioButtonAllCustomer.Checked = false;
            radioButtonFavoriteCustomer.Checked = false;
            dateTimePickerStartSale.Value = DateTime.Now;
            dateTimePickerEndSale.Value = DateTime.Now;
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
            List<Sale> listSale = new List<Sale>();
            listSale = s_bl.Sale.ReadAll();
            listBoxRead.DataSource = listSale.SelectMany(s => s.ToString().Split("\n")).ToList();
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
            List<Sale> listSale = new List<Sale>();
            listSale = s_bl.Sale.ReadAll(s => s.StartSale < DateTime.Now && s.EndSale > DateTime.Now);
            listBoxRead.DataSource = listSale.SelectMany(s => s.ToString().Split("\n")).ToList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonReadAllWithFilterClubCustomer_Click(object sender, EventArgs e)
    {
        try
        {
            listBoxRead.DataSource = null;
            listBoxRead.Items.Clear();
            List<Sale> listSale = new List<Sale>();
            listSale = s_bl.Sale.ReadAll(s => s.IsForAllCustomers == false);
            listBoxRead.DataSource = listSale.SelectMany(s => s.ToString().Split("\n")).ToList();
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
            List<Sale> sales = s_bl.Sale.ReadAll();
            Sale s = sales.FirstOrDefault(s => s.IdProductOfSale == id);
            if (s != null)
            {
                List<string> salesDetail = new List<string>
                    {
                        "IdSale: " + s.IdSale,
                        "IdProductOfSale: " + s.IdProductOfSale,
                        "AmountToGetSale: " + s.AmountToGetSale,
                        "SumPrice: " + s.SumPrice,
                        "IsForAllCustomers: " + s.IsForAllCustomers,
                        "StartSale: " + s.StartSale,
                        "EndSale: " + s.EndSale
                    };
                listBoxRead.DataSource = salesDetail;
            }
            else
            {
                MessageBox.Show("לא קיים מבצע למוצר זה");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void comboBoxIdSaleUpdate_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBoxIdSaleUpdate.SelectedValue == null)
        {
            MessageBox.Show("לא נבחר מוצר");
            return;
        }

        int id;
        if (!int.TryParse(comboBoxIdSaleUpdate.SelectedValue.ToString(), out id))
        {
            MessageBox.Show("בחרת בקטגורית מבצעים");
            return;
        }

        Sale sale = s_bl.Sale.Read(id);
        if (sale != null)
        {
            textBoxIdProductOfSale.Text = sale.IdProductOfSale.ToString();
            numericUpDownAmountToSaleUpdate.Value = (decimal)sale.AmountToGetSale;
            numericUpDownSumPriceUpdate.Value = (decimal)sale.SumPrice;
            radioButtonAllCustomerUpdate.Checked = sale.IsForAllCustomers;
            radioButtonFavoraiteCustomerUpdate.Checked = sale.IsForAllCustomers;
            dateTimePickerStartSaleUpdate.Value = sale.StartSale;
            dateTimePickerEndSaleUpdate.Value = sale.EndSale;
        }
        else
        {
            MessageBox.Show("מבצע לא נמצא");
        }
    }

    private void buttonUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxIdSaleUpdate.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxIdProductOfSale.Text) ||
                numericUpDownAmountToSaleUpdate.Value <= 0 ||
                numericUpDownSumPriceUpdate.Value <= 0 ||
                (radioButtonAllCustomerUpdate.Checked == false && radioButtonFavoraiteCustomerUpdate.Checked == false))
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }

            bool flag = false;
            if (radioButtonAllCustomerUpdate.Checked)
            {
                flag = true;
            }

            int id = int.Parse(comboBoxIdSaleUpdate.SelectedValue.ToString());
            List<Sale> sales = new List<Sale>();
            sales = s_bl.Sale.ReadAll();
            Sale s = sales.FirstOrDefault(i => i.IdSale == id);
            s.IdProductOfSale = int.Parse(textBoxIdProductOfSale.Text);
            s.AmountToGetSale = (int)numericUpDownAmountToSaleUpdate.Value;
            s.SumPrice = (int)numericUpDownSumPriceUpdate.Value;
            s.IsForAllCustomers = flag;
            s.StartSale = dateTimePickerStartSaleUpdate.Value;
            s.EndSale = dateTimePickerEndSaleUpdate.Value;

            if (comboBoxIdSaleUpdate.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBoxIdProductOfSale.Text) ||
                numericUpDownAmountToSaleUpdate.Value <= 0 ||
                numericUpDownSumPriceUpdate.Value <= 0 ||
                (radioButtonAllCustomerUpdate.Checked == false && radioButtonFavoraiteCustomerUpdate.Checked == false))
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }

            s_bl.Sale.Update(s);
            MessageBox.Show("!השינויים נשמרו");

            comboBoxIdSaleUpdate.SelectedItem = null;
            numericUpDownAmountToSaleUpdate.Value = 1;
            numericUpDownSumPriceUpdate.Value = 1;
            radioButtonAllCustomerUpdate.Checked = false;
            radioButtonFavoraiteCustomerUpdate.Checked = false;
            dateTimePickerStartSaleUpdate.Value = DateTime.Now;
            dateTimePickerEndSaleUpdate.Value = DateTime.Now;
            refreshComboBoxes();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonDelete_Click_1(object sender, EventArgs e)
    {
        try
        {
            int id = int.Parse(comboBoxDelete.SelectedValue.ToString());
            List<Sale> sales = new List<Sale>();
            sales = s_bl.Sale.ReadAll();
            Sale s = sales.FirstOrDefault(s => s.IdProductOfSale == id);
            s_bl.Sale.Delete(id);
            MessageBox.Show("!המבצע נמחק בהצלחה");

            comboBoxDelete.SelectedItem = null;
            refreshComboBoxes();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
