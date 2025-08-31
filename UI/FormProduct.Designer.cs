namespace UI
{
    partial class FormProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlProduct = new TabControl();
            tabPageCreate = new TabPage();
            numericUpDownCreateAmountIStock = new NumericUpDown();
            numericUpDownCreatePrice = new NumericUpDown();
            buttonCreate = new Button();
            comboBoxCreateCategory = new ComboBox();
            textBoxCreateProductName = new TextBox();
            labelCreateAmountInStock = new Label();
            labelCreatePrice = new Label();
            labelCreateCategory = new Label();
            labelCreateName = new Label();
            tabPageRead = new TabPage();
            labelSelectProduct = new Label();
            comboBoxReadOne = new ComboBox();
            listBoxRead = new ListBox();
            buttonReadOne = new Button();
            buttonReadAllWithFilter = new Button();
            buttonReadAll = new Button();
            tabPageUpdate = new TabPage();
            comboBoxNameUpdate = new ComboBox();
            buttonUpdate = new Button();
            numericUpDownUpdateAmountInStock = new NumericUpDown();
            numericUpDownUpdatePrice = new NumericUpDown();
            comboBoxUpdateCategory = new ComboBox();
            labelUpdateAmountInStock = new Label();
            labelUpdatePrice = new Label();
            labelUpdateCategory = new Label();
            labelUpdateName = new Label();
            tabPageDelete = new TabPage();
            comboBoxDelete = new ComboBox();
            buttonDelete = new Button();
            labelSelectDeleteProduct = new Label();
            labelProduct = new Label();
            tabControlProduct.SuspendLayout();
            tabPageCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCreateAmountIStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCreatePrice).BeginInit();
            tabPageRead.SuspendLayout();
            tabPageUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUpdateAmountInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUpdatePrice).BeginInit();
            tabPageDelete.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlProduct
            // 
            tabControlProduct.Controls.Add(tabPageCreate);
            tabControlProduct.Controls.Add(tabPageRead);
            tabControlProduct.Controls.Add(tabPageUpdate);
            tabControlProduct.Controls.Add(tabPageDelete);
            tabControlProduct.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlProduct.Location = new Point(66, 117);
            tabControlProduct.Name = "tabControlProduct";
            tabControlProduct.RightToLeft = RightToLeft.Yes;
            tabControlProduct.RightToLeftLayout = true;
            tabControlProduct.SelectedIndex = 0;
            tabControlProduct.Size = new Size(839, 456);
            tabControlProduct.TabIndex = 0;
            // 
            // tabPageCreate
            // 
            tabPageCreate.Controls.Add(numericUpDownCreateAmountIStock);
            tabPageCreate.Controls.Add(numericUpDownCreatePrice);
            tabPageCreate.Controls.Add(buttonCreate);
            tabPageCreate.Controls.Add(comboBoxCreateCategory);
            tabPageCreate.Controls.Add(textBoxCreateProductName);
            tabPageCreate.Controls.Add(labelCreateAmountInStock);
            tabPageCreate.Controls.Add(labelCreatePrice);
            tabPageCreate.Controls.Add(labelCreateCategory);
            tabPageCreate.Controls.Add(labelCreateName);
            tabPageCreate.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tabPageCreate.Location = new Point(4, 40);
            tabPageCreate.Name = "tabPageCreate";
            tabPageCreate.Padding = new Padding(3);
            tabPageCreate.Size = new Size(831, 412);
            tabPageCreate.TabIndex = 0;
            tabPageCreate.Text = "הוספה";
            tabPageCreate.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCreateAmountIStock
            // 
            numericUpDownCreateAmountIStock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownCreateAmountIStock.Location = new Point(309, 224);
            numericUpDownCreateAmountIStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownCreateAmountIStock.Name = "numericUpDownCreateAmountIStock";
            numericUpDownCreateAmountIStock.Size = new Size(193, 38);
            numericUpDownCreateAmountIStock.TabIndex = 4;
            numericUpDownCreateAmountIStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownCreatePrice
            // 
            numericUpDownCreatePrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownCreatePrice.Location = new Point(309, 172);
            numericUpDownCreatePrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownCreatePrice.Name = "numericUpDownCreatePrice";
            numericUpDownCreatePrice.Size = new Size(193, 38);
            numericUpDownCreatePrice.TabIndex = 4;
            numericUpDownCreatePrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonCreate
            // 
            buttonCreate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreate.Location = new Point(204, 292);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(151, 52);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "הוספה";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // comboBoxCreateCategory
            // 
            comboBoxCreateCategory.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxCreateCategory.FormattingEnabled = true;
            comboBoxCreateCategory.Items.AddRange(new object[] { "בגדים", "שמיכות_וכובעים", "בקבוקים_ומוצצים", "עגלות", "צמידים_ועגילים" });
            comboBoxCreateCategory.Location = new Point(309, 113);
            comboBoxCreateCategory.Name = "comboBoxCreateCategory";
            comboBoxCreateCategory.Size = new Size(193, 39);
            comboBoxCreateCategory.TabIndex = 2;
            // 
            // textBoxCreateProductName
            // 
            textBoxCreateProductName.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCreateProductName.Location = new Point(309, 57);
            textBoxCreateProductName.Name = "textBoxCreateProductName";
            textBoxCreateProductName.Size = new Size(193, 38);
            textBoxCreateProductName.TabIndex = 1;
            // 
            // labelCreateAmountInStock
            // 
            labelCreateAmountInStock.AutoSize = true;
            labelCreateAmountInStock.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCreateAmountInStock.Location = new Point(538, 224);
            labelCreateAmountInStock.Name = "labelCreateAmountInStock";
            labelCreateAmountInStock.Size = new Size(142, 33);
            labelCreateAmountInStock.TabIndex = 0;
            labelCreateAmountInStock.Text = "כמות במלאי:";
            // 
            // labelCreatePrice
            // 
            labelCreatePrice.AutoSize = true;
            labelCreatePrice.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCreatePrice.Location = new Point(538, 172);
            labelCreatePrice.Name = "labelCreatePrice";
            labelCreatePrice.Size = new Size(72, 33);
            labelCreatePrice.TabIndex = 0;
            labelCreatePrice.Text = "מחיר:";
            // 
            // labelCreateCategory
            // 
            labelCreateCategory.AutoSize = true;
            labelCreateCategory.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCreateCategory.Location = new Point(538, 115);
            labelCreateCategory.Name = "labelCreateCategory";
            labelCreateCategory.Size = new Size(102, 33);
            labelCreateCategory.TabIndex = 0;
            labelCreateCategory.Text = "קטגוריה:";
            // 
            // labelCreateName
            // 
            labelCreateName.AutoSize = true;
            labelCreateName.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCreateName.Location = new Point(538, 62);
            labelCreateName.Name = "labelCreateName";
            labelCreateName.Size = new Size(54, 33);
            labelCreateName.TabIndex = 0;
            labelCreateName.Text = "שם:";
            // 
            // tabPageRead
            // 
            tabPageRead.Controls.Add(labelSelectProduct);
            tabPageRead.Controls.Add(comboBoxReadOne);
            tabPageRead.Controls.Add(listBoxRead);
            tabPageRead.Controls.Add(buttonReadOne);
            tabPageRead.Controls.Add(buttonReadAllWithFilter);
            tabPageRead.Controls.Add(buttonReadAll);
            tabPageRead.Location = new Point(4, 40);
            tabPageRead.Name = "tabPageRead";
            tabPageRead.Padding = new Padding(3);
            tabPageRead.Size = new Size(831, 412);
            tabPageRead.TabIndex = 1;
            tabPageRead.Text = "תצוגה";
            tabPageRead.UseVisualStyleBackColor = true;
            // 
            // labelSelectProduct
            // 
            labelSelectProduct.AutoSize = true;
            labelSelectProduct.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelSelectProduct.Location = new Point(603, 220);
            labelSelectProduct.Name = "labelSelectProduct";
            labelSelectProduct.Size = new Size(207, 27);
            labelSelectProduct.TabIndex = 3;
            labelSelectProduct.Text = "בחר מוצר מהרשימה:";
            // 
            // comboBoxReadOne
            // 
            comboBoxReadOne.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxReadOne.FormattingEnabled = true;
            comboBoxReadOne.Location = new Point(630, 250);
            comboBoxReadOne.Name = "comboBoxReadOne";
            comboBoxReadOne.Size = new Size(151, 30);
            comboBoxReadOne.TabIndex = 2;
            // 
            // listBoxRead
            // 
            listBoxRead.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxRead.FormattingEnabled = true;
            listBoxRead.ItemHeight = 20;
            listBoxRead.Location = new Point(6, 7);
            listBoxRead.Name = "listBoxRead";
            listBoxRead.Size = new Size(567, 404);
            listBoxRead.TabIndex = 1;
            // 
            // buttonReadOne
            // 
            buttonReadOne.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReadOne.Location = new Point(627, 293);
            buttonReadOne.Name = "buttonReadOne";
            buttonReadOne.Size = new Size(157, 37);
            buttonReadOne.TabIndex = 0;
            buttonReadOne.Text = "הצגת מוצר זה";
            buttonReadOne.UseVisualStyleBackColor = true;
            buttonReadOne.Click += buttonReadOne_Click;
            // 
            // buttonReadAllWithFilter
            // 
            buttonReadAllWithFilter.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReadAllWithFilter.Location = new Point(579, 120);
            buttonReadAllWithFilter.Name = "buttonReadAllWithFilter";
            buttonReadAllWithFilter.Size = new Size(246, 63);
            buttonReadAllWithFilter.TabIndex = 0;
            buttonReadAllWithFilter.Text = "מוצרים שמחירם עד 100 ש\"ח";
            buttonReadAllWithFilter.UseVisualStyleBackColor = true;
            buttonReadAllWithFilter.Click += buttonReadAllWithFilter_Click;
            // 
            // buttonReadAll
            // 
            buttonReadAll.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReadAll.Location = new Point(630, 45);
            buttonReadAll.Name = "buttonReadAll";
            buttonReadAll.Size = new Size(154, 52);
            buttonReadAll.TabIndex = 0;
            buttonReadAll.Text = "כל המוצרים";
            buttonReadAll.UseVisualStyleBackColor = true;
            buttonReadAll.Click += buttonReadAll_Click;
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(comboBoxNameUpdate);
            tabPageUpdate.Controls.Add(buttonUpdate);
            tabPageUpdate.Controls.Add(numericUpDownUpdateAmountInStock);
            tabPageUpdate.Controls.Add(numericUpDownUpdatePrice);
            tabPageUpdate.Controls.Add(comboBoxUpdateCategory);
            tabPageUpdate.Controls.Add(labelUpdateAmountInStock);
            tabPageUpdate.Controls.Add(labelUpdatePrice);
            tabPageUpdate.Controls.Add(labelUpdateCategory);
            tabPageUpdate.Controls.Add(labelUpdateName);
            tabPageUpdate.Location = new Point(4, 40);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Size = new Size(831, 412);
            tabPageUpdate.TabIndex = 3;
            tabPageUpdate.Text = "עריכה";
            tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // comboBoxNameUpdate
            // 
            comboBoxNameUpdate.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxNameUpdate.FormattingEnabled = true;
            comboBoxNameUpdate.Location = new Point(276, 67);
            comboBoxNameUpdate.Name = "comboBoxNameUpdate";
            comboBoxNameUpdate.Size = new Size(181, 30);
            comboBoxNameUpdate.TabIndex = 15;
            comboBoxNameUpdate.SelectedIndexChanged += comboBoxNameUpdate_SelectedIndexChanged;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(202, 308);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(135, 50);
            buttonUpdate.TabIndex = 14;
            buttonUpdate.Text = "עדכון";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // numericUpDownUpdateAmountInStock
            // 
            numericUpDownUpdateAmountInStock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownUpdateAmountInStock.Location = new Point(276, 228);
            numericUpDownUpdateAmountInStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownUpdateAmountInStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownUpdateAmountInStock.Name = "numericUpDownUpdateAmountInStock";
            numericUpDownUpdateAmountInStock.Size = new Size(181, 38);
            numericUpDownUpdateAmountInStock.TabIndex = 13;
            numericUpDownUpdateAmountInStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownUpdatePrice
            // 
            numericUpDownUpdatePrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownUpdatePrice.Location = new Point(276, 174);
            numericUpDownUpdatePrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownUpdatePrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownUpdatePrice.Name = "numericUpDownUpdatePrice";
            numericUpDownUpdatePrice.Size = new Size(181, 38);
            numericUpDownUpdatePrice.TabIndex = 13;
            numericUpDownUpdatePrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBoxUpdateCategory
            // 
            comboBoxUpdateCategory.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxUpdateCategory.FormattingEnabled = true;
            comboBoxUpdateCategory.Items.AddRange(new object[] { "בגדים", "שמיכות_וכובעים", "בקבוקים_ומוצצים", "עגלות", "צמידים_ועגילים" });
            comboBoxUpdateCategory.Location = new Point(276, 124);
            comboBoxUpdateCategory.Name = "comboBoxUpdateCategory";
            comboBoxUpdateCategory.Size = new Size(181, 30);
            comboBoxUpdateCategory.TabIndex = 12;
            // 
            // labelUpdateAmountInStock
            // 
            labelUpdateAmountInStock.AutoSize = true;
            labelUpdateAmountInStock.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelUpdateAmountInStock.Location = new Point(493, 228);
            labelUpdateAmountInStock.Name = "labelUpdateAmountInStock";
            labelUpdateAmountInStock.Size = new Size(142, 33);
            labelUpdateAmountInStock.TabIndex = 5;
            labelUpdateAmountInStock.Text = "כמות במלאי:";
            // 
            // labelUpdatePrice
            // 
            labelUpdatePrice.AutoSize = true;
            labelUpdatePrice.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelUpdatePrice.Location = new Point(493, 174);
            labelUpdatePrice.Name = "labelUpdatePrice";
            labelUpdatePrice.Size = new Size(72, 33);
            labelUpdatePrice.TabIndex = 6;
            labelUpdatePrice.Text = "מחיר:";
            // 
            // labelUpdateCategory
            // 
            labelUpdateCategory.AutoSize = true;
            labelUpdateCategory.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelUpdateCategory.Location = new Point(493, 119);
            labelUpdateCategory.Name = "labelUpdateCategory";
            labelUpdateCategory.Size = new Size(103, 33);
            labelUpdateCategory.TabIndex = 7;
            labelUpdateCategory.Text = "קטגוריה:";
            // 
            // labelUpdateName
            // 
            labelUpdateName.AutoSize = true;
            labelUpdateName.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelUpdateName.Location = new Point(493, 66);
            labelUpdateName.Name = "labelUpdateName";
            labelUpdateName.Size = new Size(55, 33);
            labelUpdateName.TabIndex = 8;
            labelUpdateName.Text = "שם:";
            // 
            // tabPageDelete
            // 
            tabPageDelete.Controls.Add(comboBoxDelete);
            tabPageDelete.Controls.Add(buttonDelete);
            tabPageDelete.Controls.Add(labelSelectDeleteProduct);
            tabPageDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageDelete.Location = new Point(4, 40);
            tabPageDelete.Name = "tabPageDelete";
            tabPageDelete.Size = new Size(831, 412);
            tabPageDelete.TabIndex = 4;
            tabPageDelete.Text = "מחיקה";
            tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // comboBoxDelete
            // 
            comboBoxDelete.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxDelete.FormattingEnabled = true;
            comboBoxDelete.Location = new Point(268, 108);
            comboBoxDelete.Name = "comboBoxDelete";
            comboBoxDelete.Size = new Size(309, 30);
            comboBoxDelete.TabIndex = 5;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.Location = new Point(344, 208);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(151, 52);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "מחיקה";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelSelectDeleteProduct
            // 
            labelSelectDeleteProduct.AutoSize = true;
            labelSelectDeleteProduct.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectDeleteProduct.Location = new Point(316, 58);
            labelSelectDeleteProduct.Name = "labelSelectDeleteProduct";
            labelSelectDeleteProduct.Size = new Size(204, 33);
            labelSelectDeleteProduct.TabIndex = 1;
            labelSelectDeleteProduct.Text = "בחר מוצר למחיקה:";
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelProduct.Location = new Point(399, 19);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(191, 69);
            labelProduct.TabIndex = 1;
            labelProduct.Text = "מוצרים";
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(labelProduct);
            Controls.Add(tabControlProduct);
            Name = "FormProduct";
            Text = "Products";
            tabControlProduct.ResumeLayout(false);
            tabPageCreate.ResumeLayout(false);
            tabPageCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCreateAmountIStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCreatePrice).EndInit();
            tabPageRead.ResumeLayout(false);
            tabPageRead.PerformLayout();
            tabPageUpdate.ResumeLayout(false);
            tabPageUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUpdateAmountInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUpdatePrice).EndInit();
            tabPageDelete.ResumeLayout(false);
            tabPageDelete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlProduct;
        private TabPage tabPageCreate;
        private TabPage tabPageRead;
        private TabPage tabPageUpdate;
        private TabPage tabPageDelete;
        private Label labelCreateName;
        private TextBox textBoxCreateProductName;
        private Label labelCreateCategory;
        private ComboBox comboBoxCreateCategory;
        private Label labelCreatePrice;
        private Label labelCreateAmountInStock;
        private Label labelProduct;
        private Label labelSelectDeleteProduct;
        private ComboBox comboBoxUpdateCategory;
        private Label labelUpdateAmountInStock;
        private Label labelUpdatePrice;
        private Label labelUpdateCategory;
        private Label labelUpdateName;
        private Button buttonCreate;
        private NumericUpDown numericUpDownCreateAmountIStock;
        private NumericUpDown numericUpDownCreatePrice;
        private NumericUpDown numericUpDownUpdateAmountInStock;
        private NumericUpDown numericUpDownUpdatePrice;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonReadOne;
        private Button buttonReadAllWithFilter;
        private Button buttonReadAll;
        private ListBox listBoxRead;
        private ComboBox comboBoxDelete;
        private ComboBox comboBoxReadOne;
        private Label labelSelectProduct;
        private ComboBox comboBoxNameUpdate;
    }
}