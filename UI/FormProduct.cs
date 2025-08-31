using BO;

namespace UI;

public partial class FormProduct : Form
{
    static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

    public FormProduct()
    {
        InitializeComponent();

        comboBoxReadOne.DataSource = s_bl.Product.ReadAll().ToList();
        comboBoxReadOne.DisplayMember = "ProductName";   // מה שמוצג למשתמש
        comboBoxReadOne.ValueMember = "IdProduct";       // המזהה הפנימי

        comboBoxNameUpdate.DataSource = s_bl.Product.ReadAll().ToList();
        comboBoxNameUpdate.DisplayMember = "ProductName";   // מה שמוצג למשתמש
        comboBoxNameUpdate.ValueMember = "IdProduct";       // המזהה הפנימי

        comboBoxDelete.DataSource = s_bl.Product.ReadAll().ToList();
        comboBoxDelete.DisplayMember = "ProductName";    // מה שמוצג למשתמש
        comboBoxDelete.ValueMember = "IdProduct";        // המזהה הפנימי
    }

    private void refreshComboBoxes()
    {
        var products = s_bl.Product.ReadAll().ToList();
        comboBoxReadOne.DataSource = products;
        comboBoxNameUpdate.DataSource = products;
        comboBoxDelete.DataSource = products;
    }

    private void buttonCreate_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxCreateProductName.Text) ||
                comboBoxCreateCategory.SelectedItem == null ||
                numericUpDownCreatePrice.Value <= 0 ||
                numericUpDownCreateAmountIStock.Value <= 0)
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }

            Product p = new Product();
            p.ProductName = textBoxCreateProductName.Text;
            p.Category = (Categories)Enum.Parse(typeof(Categories), comboBoxCreateCategory.SelectedItem.ToString());
            p.Price = (double)numericUpDownCreatePrice.Value;
            p.AmountInStock = (int)numericUpDownCreateAmountIStock.Value;

            s_bl.Product.Create(p);
            MessageBox.Show("!המוצר נוסף בהצלחה");

            textBoxCreateProductName.Clear();
            comboBoxCreateCategory.SelectedItem = null;
            numericUpDownCreatePrice.Value = 0;
            numericUpDownCreateAmountIStock.Value = 0;
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
            List<Product> listProduct = new List<Product>();
            listProduct = s_bl.Product.ReadAll();
            listBoxRead.DataSource = listProduct.SelectMany(p => p.ToString().Split("\n")).ToList();
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
            List<Product> listProduct = new List<Product>();
            listProduct = s_bl.Product.ReadAll(i => i.Price < 100);
            listBoxRead.DataSource = listProduct.SelectMany(p => p.ToString().Split("\n")).ToList();
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
            Product product = s_bl.Product.Read(id);
            List<string> productDetails = new List<string>
                {
                    "IdProduct: " + product.IdProduct,
                    "Name: " + product.ProductName,
                    "Category: " + product.Category,
                    "Price: " + product.Price,
                    "AmountInStock: " + product.AmountInStock
                };
            listBoxRead.DataSource = productDetails;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void comboBoxNameUpdate_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxNameUpdate.SelectedValue == null)
            {
                MessageBox.Show("לא נבחר מוצר");
                return;
            }

            int id;
            if (!int.TryParse(comboBoxNameUpdate.SelectedValue.ToString(), out id))
            {
                MessageBox.Show("בחרת בקטגורית מוצרים");
                return;
            }

            Product product = s_bl.Product.Read(id);
            if (product != null)
            {
                comboBoxNameUpdate.Text = product.ProductName;
                comboBoxUpdateCategory.Text = product.Category.ToString();
                numericUpDownUpdatePrice.Value = (decimal)product.Price;
                numericUpDownUpdateAmountInStock.Value = (decimal)product.AmountInStock;
            }
            else
            {
                MessageBox.Show("מוצר לא נמצא");
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
            if (comboBoxNameUpdate.SelectedItem == null ||
                comboBoxUpdateCategory.SelectedItem == null ||
                numericUpDownUpdatePrice.Value <= 0 ||
                numericUpDownUpdateAmountInStock.Value <= 0)
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }

            int id = int.Parse(comboBoxNameUpdate.SelectedValue.ToString());
            List<Product> products = new List<Product>();
            products = s_bl.Product.ReadAll();
            Product p = products.FirstOrDefault(i => i.IdProduct == id);
            p.ProductName = comboBoxNameUpdate.Text;
            p.Category = (Categories)Enum.Parse(typeof(Categories), comboBoxUpdateCategory.SelectedItem.ToString());
            p.Price = (double)numericUpDownUpdatePrice.Value;
            p.AmountInStock = (int)numericUpDownUpdateAmountInStock.Value;

            if (comboBoxNameUpdate.SelectedItem == null ||
                comboBoxUpdateCategory.SelectedItem == null ||
                numericUpDownUpdatePrice.Value <= 0 ||
                numericUpDownUpdateAmountInStock.Value <= 0)
            {
                MessageBox.Show("יש למלא את כל השדות");
                return;
            }

            s_bl.Product.Update(p);
            MessageBox.Show("!השינויים נשמרו");

            comboBoxNameUpdate.SelectedValue = null;
            comboBoxUpdateCategory.SelectedItem = null;
            numericUpDownUpdatePrice.Value = 0;
            numericUpDownUpdateAmountInStock.Value = 0;
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
            s_bl.Product.Delete(id);
            List<Sale> sales = new List<Sale>();
            sales = s_bl.Sale.ReadAll();
            foreach (Sale s in sales)
            {
                if (s.IdProductOfSale == id)
                    s_bl.Sale.Delete(s.IdSale);
            }
            MessageBox.Show("!המוצר נמחק בהצלחה");

            comboBoxDelete.SelectedItem = null;
            refreshComboBoxes();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
