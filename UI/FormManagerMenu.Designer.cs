namespace UI
{
    partial class FormManagerMenu
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
            buttonProducts = new Button();
            buttonSales = new Button();
            buttonCustomers = new Button();
            labelSelect = new Label();
            SuspendLayout();
            // 
            // buttonProducts
            // 
            buttonProducts.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProducts.Location = new Point(560, 174);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(179, 80);
            buttonProducts.TabIndex = 0;
            buttonProducts.Text = "מוצרים";
            buttonProducts.UseVisualStyleBackColor = true;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // buttonSales
            // 
            buttonSales.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSales.Location = new Point(352, 174);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(179, 80);
            buttonSales.TabIndex = 0;
            buttonSales.Text = "מבצעים";
            buttonSales.UseVisualStyleBackColor = true;
            buttonSales.Click += buttonSales_Click;
            // 
            // buttonCustomers
            // 
            buttonCustomers.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCustomers.Location = new Point(144, 174);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(179, 80);
            buttonCustomers.TabIndex = 0;
            buttonCustomers.Text = "לקוחות";
            buttonCustomers.UseVisualStyleBackColor = true;
            buttonCustomers.Click += buttonCustomers_Click;
            // 
            // labelSelect
            // 
            labelSelect.AutoSize = true;
            labelSelect.Font = new Font("Arial Narrow", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelSelect.Location = new Point(242, 81);
            labelSelect.Name = "labelSelect";
            labelSelect.Size = new Size(384, 52);
            labelSelect.TabIndex = 1;
            labelSelect.Text = "בחר בקטגוריה הרצויה";
            // 
            // FormManagerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 503);
            Controls.Add(labelSelect);
            Controls.Add(buttonCustomers);
            Controls.Add(buttonSales);
            Controls.Add(buttonProducts);
            Name = "FormManagerMenu";
            Text = "Manager Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonProducts;
        private Button buttonSales;
        private Button buttonCustomers;
        private Label labelSelect;
    }
}