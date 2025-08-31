namespace UI
{
    partial class FormLogin
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
            buttonStartOrder = new Button();
            textBoxIdentityCustomer = new TextBox();
            labelIdentityCustomer = new Label();
            SuspendLayout();
            // 
            // buttonStartOrder
            // 
            buttonStartOrder.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStartOrder.Location = new Point(320, 177);
            buttonStartOrder.Name = "buttonStartOrder";
            buttonStartOrder.Size = new Size(188, 53);
            buttonStartOrder.TabIndex = 13;
            buttonStartOrder.Text = "התחל הזמנה";
            buttonStartOrder.UseVisualStyleBackColor = true;
            buttonStartOrder.Click += buttonStartOrder_Click;
            // 
            // textBoxIdentityCustomer
            // 
            textBoxIdentityCustomer.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxIdentityCustomer.Location = new Point(216, 107);
            textBoxIdentityCustomer.Name = "textBoxIdentityCustomer";
            textBoxIdentityCustomer.Size = new Size(184, 38);
            textBoxIdentityCustomer.TabIndex = 12;
            // 
            // labelIdentityCustomer
            // 
            labelIdentityCustomer.AutoSize = true;
            labelIdentityCustomer.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdentityCustomer.Location = new Point(421, 107);
            labelIdentityCustomer.Name = "labelIdentityCustomer";
            labelIdentityCustomer.Size = new Size(171, 33);
            labelIdentityCustomer.TabIndex = 11;
            labelIdentityCustomer.Text = ":הכנס ת\"ז לקוח";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(buttonStartOrder);
            Controls.Add(textBoxIdentityCustomer);
            Controls.Add(labelIdentityCustomer);
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStartOrder;
        private TextBox textBoxIdentityCustomer;
        private Label labelIdentityCustomer;
    }
}