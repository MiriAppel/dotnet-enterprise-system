namespace UI
{
    partial class FormOrder
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
            listBoxOrder = new ListBox();
            labelNameProduct = new Label();
            comboBoxNameProduct = new ComboBox();
            label1 = new Label();
            numericUpDownAmountToOrder = new NumericUpDown();
            buttonAddToOrder = new Button();
            labelTotalPrice = new Label();
            labelSumPrice = new Label();
            buttonFinishOrder = new Button();
            labelHello = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmountToOrder).BeginInit();
            SuspendLayout();
            // 
            // listBoxOrder
            // 
            listBoxOrder.FormattingEnabled = true;
            listBoxOrder.ItemHeight = 20;
            listBoxOrder.Location = new Point(12, 43);
            listBoxOrder.Name = "listBoxOrder";
            listBoxOrder.RightToLeft = RightToLeft.Yes;
            listBoxOrder.Size = new Size(541, 504);
            listBoxOrder.TabIndex = 0;
            // 
            // labelNameProduct
            // 
            labelNameProduct.AutoSize = true;
            labelNameProduct.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelNameProduct.Location = new Point(781, 176);
            labelNameProduct.Name = "labelNameProduct";
            labelNameProduct.Size = new Size(117, 33);
            labelNameProduct.TabIndex = 1;
            labelNameProduct.Text = ":בחר מוצר";
            // 
            // comboBoxNameProduct
            // 
            comboBoxNameProduct.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxNameProduct.FormattingEnabled = true;
            comboBoxNameProduct.Location = new Point(614, 178);
            comboBoxNameProduct.Name = "comboBoxNameProduct";
            comboBoxNameProduct.RightToLeft = RightToLeft.Yes;
            comboBoxNameProduct.Size = new Size(151, 30);
            comboBoxNameProduct.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(781, 230);
            label1.Name = "label1";
            label1.Size = new Size(156, 33);
            label1.TabIndex = 1;
            label1.Text = ":כמות להזמנה";
            // 
            // numericUpDownAmountToOrder
            // 
            numericUpDownAmountToOrder.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAmountToOrder.Location = new Point(615, 230);
            numericUpDownAmountToOrder.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownAmountToOrder.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAmountToOrder.Name = "numericUpDownAmountToOrder";
            numericUpDownAmountToOrder.Size = new Size(150, 38);
            numericUpDownAmountToOrder.TabIndex = 3;
            numericUpDownAmountToOrder.TextAlign = HorizontalAlignment.Right;
            numericUpDownAmountToOrder.UpDownAlign = LeftRightAlignment.Left;
            numericUpDownAmountToOrder.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonAddToOrder
            // 
            buttonAddToOrder.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddToOrder.Location = new Point(685, 295);
            buttonAddToOrder.Name = "buttonAddToOrder";
            buttonAddToOrder.Size = new Size(170, 50);
            buttonAddToOrder.TabIndex = 4;
            buttonAddToOrder.Text = "הוספה לסל";
            buttonAddToOrder.UseVisualStyleBackColor = true;
            buttonAddToOrder.Click += buttonAddToOrder_Click;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalPrice.Location = new Point(715, 491);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.RightToLeft = RightToLeft.Yes;
            labelTotalPrice.Size = new Size(44, 31);
            labelTotalPrice.TabIndex = 5;
            labelTotalPrice.Text = "0 ₪";
            // 
            // labelSumPrice
            // 
            labelSumPrice.AutoSize = true;
            labelSumPrice.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelSumPrice.Location = new Point(781, 495);
            labelSumPrice.Name = "labelSumPrice";
            labelSumPrice.RightToLeft = RightToLeft.Yes;
            labelSumPrice.Size = new Size(64, 27);
            labelSumPrice.TabIndex = 6;
            labelSumPrice.Text = "סה\"כ:";
            // 
            // buttonFinishOrder
            // 
            buttonFinishOrder.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFinishOrder.Location = new Point(651, 397);
            buttonFinishOrder.Name = "buttonFinishOrder";
            buttonFinishOrder.Size = new Size(247, 68);
            buttonFinishOrder.TabIndex = 7;
            buttonFinishOrder.Text = "סיום הזמנה";
            buttonFinishOrder.UseVisualStyleBackColor = true;
            buttonFinishOrder.Click += buttonFinishOrder_Click;
            // 
            // labelHello
            // 
            labelHello.AutoSize = true;
            labelHello.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelHello.Location = new Point(703, 71);
            labelHello.Name = "labelHello";
            labelHello.RightToLeft = RightToLeft.Yes;
            labelHello.Size = new Size(75, 33);
            labelHello.TabIndex = 8;
            labelHello.Text = "שלום!";
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(labelHello);
            Controls.Add(buttonFinishOrder);
            Controls.Add(labelSumPrice);
            Controls.Add(labelTotalPrice);
            Controls.Add(buttonAddToOrder);
            Controls.Add(numericUpDownAmountToOrder);
            Controls.Add(comboBoxNameProduct);
            Controls.Add(label1);
            Controls.Add(labelNameProduct);
            Controls.Add(listBoxOrder);
            Name = "FormOrder";
            RightToLeft = RightToLeft.No;
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmountToOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxOrder;
        private Label labelNameProduct;
        private ComboBox comboBoxNameProduct;
        private Label label1;
        private NumericUpDown numericUpDownAmountToOrder;
        private Button buttonAddToOrder;
        private Label labelTotalPrice;
        private Label labelSumPrice;
        private Button buttonFinishOrder;
        private Label labelHello;
    }
}