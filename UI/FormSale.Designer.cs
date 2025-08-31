namespace UI
{
    partial class FormSale
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
            tabControlSale = new TabControl();
            tabPageCreate = new TabPage();
            comboBoxCreate = new ComboBox();
            radioButtonAllCustomer = new RadioButton();
            radioButtonFavoriteCustomer = new RadioButton();
            dateTimePickerStartSale = new DateTimePicker();
            dateTimePickerEndSale = new DateTimePicker();
            numericUpDownAmountToGetSale = new NumericUpDown();
            numericUpDownSumPrice = new NumericUpDown();
            buttonCreate = new Button();
            labelEndSale = new Label();
            labelStartSale = new Label();
            labelIsForAllCustomers = new Label();
            labelSumPrice = new Label();
            labelIdProductOfSaleCreate = new Label();
            labelAmountToGetSale = new Label();
            tabPageRead = new TabPage();
            buttonReadAllWithFilterClubCustomer = new Button();
            labelSelectProduct = new Label();
            comboBoxReadOne = new ComboBox();
            listBoxRead = new ListBox();
            buttonReadOne = new Button();
            buttonReadAllWithFilter = new Button();
            buttonReadAll = new Button();
            tabPageUpdate = new TabPage();
            radioButtonAllCustomerUpdate = new RadioButton();
            radioButtonFavoraiteCustomerUpdate = new RadioButton();
            textBoxIdProductOfSale = new TextBox();
            comboBoxIdSaleUpdate = new ComboBox();
            dateTimePickerStartSaleUpdate = new DateTimePicker();
            dateTimePickerEndSaleUpdate = new DateTimePicker();
            numericUpDownAmountToSaleUpdate = new NumericUpDown();
            numericUpDownSumPriceUpdate = new NumericUpDown();
            buttonUpdate = new Button();
            labelEndSaleUpdate = new Label();
            labelStartSaleUpdate = new Label();
            labelIsForAllCustomerUpdate = new Label();
            labelSumPriceUpdate = new Label();
            labelIdProductOfSaleUpdate = new Label();
            labelIdSale = new Label();
            labelAmountToSaleUpdate = new Label();
            tabPageDelete = new TabPage();
            comboBoxDelete = new ComboBox();
            buttonDelete = new Button();
            labelSelectDeleteProduct = new Label();
            labelSale = new Label();
            tabControlSale.SuspendLayout();
            tabPageCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmountToGetSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSumPrice).BeginInit();
            tabPageRead.SuspendLayout();
            tabPageUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmountToSaleUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSumPriceUpdate).BeginInit();
            tabPageDelete.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlSale
            // 
            tabControlSale.Controls.Add(tabPageCreate);
            tabControlSale.Controls.Add(tabPageRead);
            tabControlSale.Controls.Add(tabPageUpdate);
            tabControlSale.Controls.Add(tabPageDelete);
            tabControlSale.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlSale.Location = new Point(44, 120);
            tabControlSale.Name = "tabControlSale";
            tabControlSale.RightToLeft = RightToLeft.Yes;
            tabControlSale.RightToLeftLayout = true;
            tabControlSale.SelectedIndex = 0;
            tabControlSale.Size = new Size(885, 482);
            tabControlSale.TabIndex = 1;
            // 
            // tabPageCreate
            // 
            tabPageCreate.Controls.Add(comboBoxCreate);
            tabPageCreate.Controls.Add(radioButtonAllCustomer);
            tabPageCreate.Controls.Add(radioButtonFavoriteCustomer);
            tabPageCreate.Controls.Add(dateTimePickerStartSale);
            tabPageCreate.Controls.Add(dateTimePickerEndSale);
            tabPageCreate.Controls.Add(numericUpDownAmountToGetSale);
            tabPageCreate.Controls.Add(numericUpDownSumPrice);
            tabPageCreate.Controls.Add(buttonCreate);
            tabPageCreate.Controls.Add(labelEndSale);
            tabPageCreate.Controls.Add(labelStartSale);
            tabPageCreate.Controls.Add(labelIsForAllCustomers);
            tabPageCreate.Controls.Add(labelSumPrice);
            tabPageCreate.Controls.Add(labelIdProductOfSaleCreate);
            tabPageCreate.Controls.Add(labelAmountToGetSale);
            tabPageCreate.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tabPageCreate.Location = new Point(4, 40);
            tabPageCreate.Name = "tabPageCreate";
            tabPageCreate.Padding = new Padding(3);
            tabPageCreate.Size = new Size(877, 438);
            tabPageCreate.TabIndex = 0;
            tabPageCreate.Text = "הוספה";
            tabPageCreate.UseVisualStyleBackColor = true;
            // 
            // comboBoxCreate
            // 
            comboBoxCreate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxCreate.FormattingEnabled = true;
            comboBoxCreate.Location = new Point(255, 30);
            comboBoxCreate.Name = "comboBoxCreate";
            comboBoxCreate.Size = new Size(181, 39);
            comboBoxCreate.TabIndex = 9;
            // 
            // radioButtonAllCustomer
            // 
            radioButtonAllCustomer.AutoSize = true;
            radioButtonAllCustomer.Location = new Point(275, 209);
            radioButtonAllCustomer.Name = "radioButtonAllCustomer";
            radioButtonAllCustomer.Size = new Size(161, 35);
            radioButtonAllCustomer.TabIndex = 8;
            radioButtonAllCustomer.TabStop = true;
            radioButtonAllCustomer.Text = "כלל הלקוחות";
            radioButtonAllCustomer.UseVisualStyleBackColor = true;
            // 
            // radioButtonFavoriteCustomer
            // 
            radioButtonFavoriteCustomer.AutoSize = true;
            radioButtonFavoriteCustomer.Location = new Point(117, 209);
            radioButtonFavoriteCustomer.Name = "radioButtonFavoriteCustomer";
            radioButtonFavoriteCustomer.Size = new Size(143, 35);
            radioButtonFavoriteCustomer.TabIndex = 8;
            radioButtonFavoriteCustomer.TabStop = true;
            radioButtonFavoriteCustomer.Text = "חברי מועדון";
            radioButtonFavoriteCustomer.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerStartSale
            // 
            dateTimePickerStartSale.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStartSale.Location = new Point(198, 263);
            dateTimePickerStartSale.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePickerStartSale.Name = "dateTimePickerStartSale";
            dateTimePickerStartSale.Size = new Size(238, 30);
            dateTimePickerStartSale.TabIndex = 6;
            // 
            // dateTimePickerEndSale
            // 
            dateTimePickerEndSale.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEndSale.Location = new Point(198, 307);
            dateTimePickerEndSale.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePickerEndSale.Name = "dateTimePickerEndSale";
            dateTimePickerEndSale.Size = new Size(238, 30);
            dateTimePickerEndSale.TabIndex = 6;
            // 
            // numericUpDownAmountToGetSale
            // 
            numericUpDownAmountToGetSale.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAmountToGetSale.Location = new Point(255, 86);
            numericUpDownAmountToGetSale.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAmountToGetSale.Name = "numericUpDownAmountToGetSale";
            numericUpDownAmountToGetSale.Size = new Size(181, 38);
            numericUpDownAmountToGetSale.TabIndex = 4;
            numericUpDownAmountToGetSale.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownSumPrice
            // 
            numericUpDownSumPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownSumPrice.Location = new Point(255, 149);
            numericUpDownSumPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownSumPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSumPrice.Name = "numericUpDownSumPrice";
            numericUpDownSumPrice.Size = new Size(181, 38);
            numericUpDownSumPrice.TabIndex = 4;
            numericUpDownSumPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonCreate
            // 
            buttonCreate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreate.Location = new Point(160, 363);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(151, 52);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "הוספה";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // labelEndSale
            // 
            labelEndSale.AutoSize = true;
            labelEndSale.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelEndSale.Location = new Point(456, 307);
            labelEndSale.Name = "labelEndSale";
            labelEndSale.Size = new Size(212, 33);
            labelEndSale.TabIndex = 0;
            labelEndSale.Text = "תאריך סיום המבצע:";
            // 
            // labelStartSale
            // 
            labelStartSale.AutoSize = true;
            labelStartSale.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelStartSale.Location = new Point(457, 263);
            labelStartSale.Name = "labelStartSale";
            labelStartSale.Size = new Size(236, 33);
            labelStartSale.TabIndex = 0;
            labelStartSale.Text = "תאריך תחילת המבצע:";
            // 
            // labelIsForAllCustomers
            // 
            labelIsForAllCustomers.AutoSize = true;
            labelIsForAllCustomers.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIsForAllCustomers.Location = new Point(457, 209);
            labelIsForAllCustomers.Name = "labelIsForAllCustomers";
            labelIsForAllCustomers.Size = new Size(196, 33);
            labelIsForAllCustomers.TabIndex = 0;
            labelIsForAllCustomers.Text = "למי המבצע מיועד?";
            // 
            // labelSumPrice
            // 
            labelSumPrice.AutoSize = true;
            labelSumPrice.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelSumPrice.Location = new Point(456, 149);
            labelSumPrice.Name = "labelSumPrice";
            labelSumPrice.Size = new Size(197, 33);
            labelSumPrice.TabIndex = 0;
            labelSumPrice.Text = "מחיר כולל במבצע:";
            // 
            // labelIdProductOfSaleCreate
            // 
            labelIdProductOfSaleCreate.AutoSize = true;
            labelIdProductOfSaleCreate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdProductOfSaleCreate.Location = new Point(457, 30);
            labelIdProductOfSaleCreate.Name = "labelIdProductOfSaleCreate";
            labelIdProductOfSaleCreate.Size = new Size(182, 33);
            labelIdProductOfSaleCreate.TabIndex = 0;
            labelIdProductOfSaleCreate.Text = "שם מוצר למבצע:";
            // 
            // labelAmountToGetSale
            // 
            labelAmountToGetSale.AutoSize = true;
            labelAmountToGetSale.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelAmountToGetSale.Location = new Point(456, 88);
            labelAmountToGetSale.Name = "labelAmountToGetSale";
            labelAmountToGetSale.Size = new Size(300, 33);
            labelAmountToGetSale.TabIndex = 0;
            labelAmountToGetSale.Text = "כמות נדרשת לקבלת המבצע:";
            // 
            // tabPageRead
            // 
            tabPageRead.Controls.Add(buttonReadAllWithFilterClubCustomer);
            tabPageRead.Controls.Add(labelSelectProduct);
            tabPageRead.Controls.Add(comboBoxReadOne);
            tabPageRead.Controls.Add(listBoxRead);
            tabPageRead.Controls.Add(buttonReadOne);
            tabPageRead.Controls.Add(buttonReadAllWithFilter);
            tabPageRead.Controls.Add(buttonReadAll);
            tabPageRead.Location = new Point(4, 40);
            tabPageRead.Name = "tabPageRead";
            tabPageRead.Padding = new Padding(3);
            tabPageRead.Size = new Size(877, 438);
            tabPageRead.TabIndex = 1;
            tabPageRead.Text = "תצוגה";
            tabPageRead.UseVisualStyleBackColor = true;
            // 
            // buttonReadAllWithFilterClubCustomer
            // 
            buttonReadAllWithFilterClubCustomer.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReadAllWithFilterClubCustomer.Location = new Point(614, 179);
            buttonReadAllWithFilterClubCustomer.Name = "buttonReadAllWithFilterClubCustomer";
            buttonReadAllWithFilterClubCustomer.Size = new Size(240, 53);
            buttonReadAllWithFilterClubCustomer.TabIndex = 10;
            buttonReadAllWithFilterClubCustomer.Text = "מבצעים לחברי מועדון";
            buttonReadAllWithFilterClubCustomer.UseVisualStyleBackColor = true;
            buttonReadAllWithFilterClubCustomer.Click += buttonReadAllWithFilterClubCustomer_Click;
            // 
            // labelSelectProduct
            // 
            labelSelectProduct.AutoSize = true;
            labelSelectProduct.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelSelectProduct.Location = new Point(631, 256);
            labelSelectProduct.Name = "labelSelectProduct";
            labelSelectProduct.Size = new Size(207, 27);
            labelSelectProduct.TabIndex = 9;
            labelSelectProduct.Text = "בחר מוצר מהרשימה:";
            // 
            // comboBoxReadOne
            // 
            comboBoxReadOne.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxReadOne.FormattingEnabled = true;
            comboBoxReadOne.Location = new Point(664, 290);
            comboBoxReadOne.Name = "comboBoxReadOne";
            comboBoxReadOne.Size = new Size(153, 30);
            comboBoxReadOne.TabIndex = 8;
            // 
            // listBoxRead
            // 
            listBoxRead.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxRead.FormattingEnabled = true;
            listBoxRead.ItemHeight = 20;
            listBoxRead.Location = new Point(17, 20);
            listBoxRead.Name = "listBoxRead";
            listBoxRead.Size = new Size(566, 404);
            listBoxRead.TabIndex = 7;
            // 
            // buttonReadOne
            // 
            buttonReadOne.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReadOne.Location = new Point(625, 326);
            buttonReadOne.Name = "buttonReadOne";
            buttonReadOne.Size = new Size(229, 49);
            buttonReadOne.TabIndex = 4;
            buttonReadOne.Text = "הצגת מבצע למוצר זה";
            buttonReadOne.UseVisualStyleBackColor = true;
            buttonReadOne.Click += buttonReadOne_Click;
            // 
            // buttonReadAllWithFilter
            // 
            buttonReadAllWithFilter.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReadAllWithFilter.Location = new Point(621, 113);
            buttonReadAllWithFilter.Name = "buttonReadAllWithFilter";
            buttonReadAllWithFilter.Size = new Size(227, 60);
            buttonReadAllWithFilter.TabIndex = 5;
            buttonReadAllWithFilter.Text = "מבצעים בתוקף";
            buttonReadAllWithFilter.UseVisualStyleBackColor = true;
            buttonReadAllWithFilter.Click += buttonReadAllWithFilter_Click;
            // 
            // buttonReadAll
            // 
            buttonReadAll.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReadAll.Location = new Point(663, 38);
            buttonReadAll.Name = "buttonReadAll";
            buttonReadAll.Size = new Size(154, 52);
            buttonReadAll.TabIndex = 6;
            buttonReadAll.Text = "כל המבצעים";
            buttonReadAll.UseVisualStyleBackColor = true;
            buttonReadAll.Click += buttonReadAll_Click;
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(radioButtonAllCustomerUpdate);
            tabPageUpdate.Controls.Add(radioButtonFavoraiteCustomerUpdate);
            tabPageUpdate.Controls.Add(textBoxIdProductOfSale);
            tabPageUpdate.Controls.Add(comboBoxIdSaleUpdate);
            tabPageUpdate.Controls.Add(dateTimePickerStartSaleUpdate);
            tabPageUpdate.Controls.Add(dateTimePickerEndSaleUpdate);
            tabPageUpdate.Controls.Add(numericUpDownAmountToSaleUpdate);
            tabPageUpdate.Controls.Add(numericUpDownSumPriceUpdate);
            tabPageUpdate.Controls.Add(buttonUpdate);
            tabPageUpdate.Controls.Add(labelEndSaleUpdate);
            tabPageUpdate.Controls.Add(labelStartSaleUpdate);
            tabPageUpdate.Controls.Add(labelIsForAllCustomerUpdate);
            tabPageUpdate.Controls.Add(labelSumPriceUpdate);
            tabPageUpdate.Controls.Add(labelIdProductOfSaleUpdate);
            tabPageUpdate.Controls.Add(labelIdSale);
            tabPageUpdate.Controls.Add(labelAmountToSaleUpdate);
            tabPageUpdate.Location = new Point(4, 40);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Size = new Size(877, 438);
            tabPageUpdate.TabIndex = 3;
            tabPageUpdate.Text = "עריכה";
            tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // radioButtonAllCustomerUpdate
            // 
            radioButtonAllCustomerUpdate.AutoSize = true;
            radioButtonAllCustomerUpdate.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonAllCustomerUpdate.Location = new Point(321, 230);
            radioButtonAllCustomerUpdate.Name = "radioButtonAllCustomerUpdate";
            radioButtonAllCustomerUpdate.Size = new Size(161, 35);
            radioButtonAllCustomerUpdate.TabIndex = 23;
            radioButtonAllCustomerUpdate.TabStop = true;
            radioButtonAllCustomerUpdate.Text = "כלל הלקוחות";
            radioButtonAllCustomerUpdate.UseVisualStyleBackColor = true;
            // 
            // radioButtonFavoraiteCustomerUpdate
            // 
            radioButtonFavoraiteCustomerUpdate.AutoSize = true;
            radioButtonFavoraiteCustomerUpdate.Font = new Font("Algerian", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonFavoraiteCustomerUpdate.Location = new Point(159, 230);
            radioButtonFavoraiteCustomerUpdate.Name = "radioButtonFavoraiteCustomerUpdate";
            radioButtonFavoraiteCustomerUpdate.Size = new Size(143, 35);
            radioButtonFavoraiteCustomerUpdate.TabIndex = 24;
            radioButtonFavoraiteCustomerUpdate.TabStop = true;
            radioButtonFavoraiteCustomerUpdate.Text = "חברי מועדון";
            radioButtonFavoraiteCustomerUpdate.UseVisualStyleBackColor = true;
            // 
            // textBoxIdProductOfSale
            // 
            textBoxIdProductOfSale.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxIdProductOfSale.Location = new Point(299, 81);
            textBoxIdProductOfSale.Name = "textBoxIdProductOfSale";
            textBoxIdProductOfSale.Size = new Size(181, 38);
            textBoxIdProductOfSale.TabIndex = 22;
            // 
            // comboBoxIdSaleUpdate
            // 
            comboBoxIdSaleUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxIdSaleUpdate.FormattingEnabled = true;
            comboBoxIdSaleUpdate.Location = new Point(299, 32);
            comboBoxIdSaleUpdate.Name = "comboBoxIdSaleUpdate";
            comboBoxIdSaleUpdate.Size = new Size(181, 39);
            comboBoxIdSaleUpdate.TabIndex = 21;
            comboBoxIdSaleUpdate.SelectedIndexChanged += comboBoxIdSaleUpdate_SelectedIndexChanged;
            // 
            // dateTimePickerStartSaleUpdate
            // 
            dateTimePickerStartSaleUpdate.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStartSaleUpdate.Location = new Point(242, 280);
            dateTimePickerStartSaleUpdate.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePickerStartSaleUpdate.Name = "dateTimePickerStartSaleUpdate";
            dateTimePickerStartSaleUpdate.Size = new Size(238, 30);
            dateTimePickerStartSaleUpdate.TabIndex = 18;
            // 
            // dateTimePickerEndSaleUpdate
            // 
            dateTimePickerEndSaleUpdate.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEndSaleUpdate.Location = new Point(242, 324);
            dateTimePickerEndSaleUpdate.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePickerEndSaleUpdate.Name = "dateTimePickerEndSaleUpdate";
            dateTimePickerEndSaleUpdate.Size = new Size(238, 30);
            dateTimePickerEndSaleUpdate.TabIndex = 19;
            // 
            // numericUpDownAmountToSaleUpdate
            // 
            numericUpDownAmountToSaleUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAmountToSaleUpdate.Location = new Point(299, 127);
            numericUpDownAmountToSaleUpdate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAmountToSaleUpdate.Name = "numericUpDownAmountToSaleUpdate";
            numericUpDownAmountToSaleUpdate.Size = new Size(181, 38);
            numericUpDownAmountToSaleUpdate.TabIndex = 15;
            numericUpDownAmountToSaleUpdate.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownSumPriceUpdate
            // 
            numericUpDownSumPriceUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownSumPriceUpdate.Location = new Point(299, 179);
            numericUpDownSumPriceUpdate.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownSumPriceUpdate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSumPriceUpdate.Name = "numericUpDownSumPriceUpdate";
            numericUpDownSumPriceUpdate.Size = new Size(181, 38);
            numericUpDownSumPriceUpdate.TabIndex = 16;
            numericUpDownSumPriceUpdate.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(212, 379);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(151, 41);
            buttonUpdate.TabIndex = 14;
            buttonUpdate.Text = "עדכון";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelEndSaleUpdate
            // 
            labelEndSaleUpdate.AutoSize = true;
            labelEndSaleUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelEndSaleUpdate.Location = new Point(496, 322);
            labelEndSaleUpdate.Name = "labelEndSaleUpdate";
            labelEndSaleUpdate.Size = new Size(212, 33);
            labelEndSaleUpdate.TabIndex = 8;
            labelEndSaleUpdate.Text = "תאריך סיום המבצע:";
            // 
            // labelStartSaleUpdate
            // 
            labelStartSaleUpdate.AutoSize = true;
            labelStartSaleUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelStartSaleUpdate.Location = new Point(497, 279);
            labelStartSaleUpdate.Name = "labelStartSaleUpdate";
            labelStartSaleUpdate.Size = new Size(236, 33);
            labelStartSaleUpdate.TabIndex = 9;
            labelStartSaleUpdate.Text = "תאריך תחילת המבצע:";
            // 
            // labelIsForAllCustomerUpdate
            // 
            labelIsForAllCustomerUpdate.AutoSize = true;
            labelIsForAllCustomerUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIsForAllCustomerUpdate.Location = new Point(497, 230);
            labelIsForAllCustomerUpdate.Name = "labelIsForAllCustomerUpdate";
            labelIsForAllCustomerUpdate.Size = new Size(196, 33);
            labelIsForAllCustomerUpdate.TabIndex = 10;
            labelIsForAllCustomerUpdate.Text = "למי המבצע מיועד?";
            // 
            // labelSumPriceUpdate
            // 
            labelSumPriceUpdate.AutoSize = true;
            labelSumPriceUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelSumPriceUpdate.Location = new Point(496, 179);
            labelSumPriceUpdate.Name = "labelSumPriceUpdate";
            labelSumPriceUpdate.Size = new Size(197, 33);
            labelSumPriceUpdate.TabIndex = 11;
            labelSumPriceUpdate.Text = "מחיר כולל במבצע:";
            // 
            // labelIdProductOfSaleUpdate
            // 
            labelIdProductOfSaleUpdate.AutoSize = true;
            labelIdProductOfSaleUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdProductOfSaleUpdate.Location = new Point(497, 81);
            labelIdProductOfSaleUpdate.Name = "labelIdProductOfSaleUpdate";
            labelIdProductOfSaleUpdate.Size = new Size(180, 33);
            labelIdProductOfSaleUpdate.TabIndex = 12;
            labelIdProductOfSaleUpdate.Text = "קוד מוצר למבצע:";
            // 
            // labelIdSale
            // 
            labelIdSale.AutoSize = true;
            labelIdSale.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdSale.Location = new Point(497, 33);
            labelIdSale.Name = "labelIdSale";
            labelIdSale.Size = new Size(195, 33);
            labelIdSale.TabIndex = 12;
            labelIdSale.Text = "קוד מבצע לעריכה:";
            // 
            // labelAmountToSaleUpdate
            // 
            labelAmountToSaleUpdate.AutoSize = true;
            labelAmountToSaleUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelAmountToSaleUpdate.Location = new Point(496, 128);
            labelAmountToSaleUpdate.Name = "labelAmountToSaleUpdate";
            labelAmountToSaleUpdate.Size = new Size(300, 33);
            labelAmountToSaleUpdate.TabIndex = 13;
            labelAmountToSaleUpdate.Text = "כמות נדרשת לקבלת המבצע:";
            // 
            // tabPageDelete
            // 
            tabPageDelete.Controls.Add(comboBoxDelete);
            tabPageDelete.Controls.Add(buttonDelete);
            tabPageDelete.Controls.Add(labelSelectDeleteProduct);
            tabPageDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageDelete.Location = new Point(4, 40);
            tabPageDelete.Name = "tabPageDelete";
            tabPageDelete.Size = new Size(877, 438);
            tabPageDelete.TabIndex = 4;
            tabPageDelete.Text = "מחיקה";
            tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // comboBoxDelete
            // 
            comboBoxDelete.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxDelete.FormattingEnabled = true;
            comboBoxDelete.Location = new Point(295, 118);
            comboBoxDelete.Name = "comboBoxDelete";
            comboBoxDelete.Size = new Size(305, 30);
            comboBoxDelete.TabIndex = 8;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.Location = new Point(371, 218);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(151, 52);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "מחיקה";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click_1;
            // 
            // labelSelectDeleteProduct
            // 
            labelSelectDeleteProduct.AutoSize = true;
            labelSelectDeleteProduct.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectDeleteProduct.Location = new Point(318, 67);
            labelSelectDeleteProduct.Name = "labelSelectDeleteProduct";
            labelSelectDeleteProduct.Size = new Size(267, 33);
            labelSelectDeleteProduct.TabIndex = 6;
            labelSelectDeleteProduct.Text = "בחר מוצר למחיקת מבצע:";
            // 
            // labelSale
            // 
            labelSale.AutoSize = true;
            labelSale.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelSale.Location = new Point(382, 34);
            labelSale.Name = "labelSale";
            labelSale.Size = new Size(210, 69);
            labelSale.TabIndex = 2;
            labelSale.Text = "מבצעים";
            // 
            // FormSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(labelSale);
            Controls.Add(tabControlSale);
            Name = "FormSale";
            Text = "Sales";
            tabControlSale.ResumeLayout(false);
            tabPageCreate.ResumeLayout(false);
            tabPageCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmountToGetSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSumPrice).EndInit();
            tabPageRead.ResumeLayout(false);
            tabPageRead.PerformLayout();
            tabPageUpdate.ResumeLayout(false);
            tabPageUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmountToSaleUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSumPriceUpdate).EndInit();
            tabPageDelete.ResumeLayout(false);
            tabPageDelete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlSale;
        private TabPage tabPageCreate;
        private Button buttonCreate;
        private Label labelStartSale;
        private Label labelIsForAllCustomers;
        private Label labelSumPrice;
        private Label labelAmountToGetSale;
        private TabPage tabPageRead;
        private TabPage tabPageUpdate;
        private TabPage tabPageDelete;
        private Label labelSale;
        private NumericUpDown numericUpDownAmountToGetSale;
        private NumericUpDown numericUpDownSumPrice;
        private Label labelEndSale;
        private DateTimePicker dateTimePickerEndSale;
        private DateTimePicker dateTimePickerStartSale;
        private Label labelIdProductOfSaleCreate;
        private DateTimePicker dateTimePickerStartSaleUpdate;
        private DateTimePicker dateTimePickerEndSaleUpdate;
        private NumericUpDown numericUpDownAmountToSaleUpdate;
        private NumericUpDown numericUpDownSumPriceUpdate;
        private Button buttonUpdate;
        private Label labelEndSaleUpdate;
        private Label labelStartSaleUpdate;
        private Label labelIsForAllCustomerUpdate;
        private Label labelSumPriceUpdate;
        private Label labelIdSale;
        private Label labelAmountToSaleUpdate;
        private RadioButton radioButtonFavoriteCustomer;
        private RadioButton radioButtonAllCustomer;
        private Label labelSelectProduct;
        private ComboBox comboBoxReadOne;
        private ListBox listBoxRead;
        private Button buttonReadOne;
        private Button buttonReadAllWithFilter;
        private Button buttonReadAll;
        private ComboBox comboBoxDelete;
        private Button buttonDelete;
        private Label labelSelectDeleteProduct;
        private ComboBox comboBoxCreate;
        private ComboBox comboBoxIdSaleUpdate;
        private Label labelIdProductOfSaleUpdate;
        private TextBox textBoxIdProductOfSale;
        private RadioButton radioButtonAllCustomerUpdate;
        private RadioButton radioButtonFavoraiteCustomerUpdate;
        private Button buttonReadAllWithFilterClubCustomer;
    }
}