namespace UI
{
    partial class FormCustomer
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
            labelCustomer = new Label();
            tabPageDelete = new TabPage();
            comboBoxDelete = new ComboBox();
            buttonDelete = new Button();
            labelDeleteIdentity = new Label();
            tabPageUpdate = new TabPage();
            comboBoxIdentityUpdate = new ComboBox();
            textBoxPhoneUpdate = new TextBox();
            textBoxAddressUpdate = new TextBox();
            textBoxNameUpdate = new TextBox();
            labelPhoneUpdate = new Label();
            labelAddressUpdate = new Label();
            labelNameUpdate = new Label();
            labelIdententityUpdate = new Label();
            buttonUpdate = new Button();
            tabPageRead = new TabPage();
            labelSelectCustomer = new Label();
            comboBoxReadOne = new ComboBox();
            listBoxRead = new ListBox();
            buttonReadOne = new Button();
            buttonReadAllWithFilter = new Button();
            buttonReadAll = new Button();
            tabPageCreate = new TabPage();
            textBoxPhoneCreate = new TextBox();
            textBoxAddressCreate = new TextBox();
            textBoxNameCreate = new TextBox();
            textBoxIdentityCreate = new TextBox();
            buttonCreate = new Button();
            labelPhoneCreate = new Label();
            labelAddressCreate = new Label();
            labelNameCreate = new Label();
            labelIdentityCreate = new Label();
            tabControlCustomer = new TabControl();
            tabPageDelete.SuspendLayout();
            tabPageUpdate.SuspendLayout();
            tabPageRead.SuspendLayout();
            tabPageCreate.SuspendLayout();
            tabControlCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustomer.Location = new Point(383, 32);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(196, 69);
            labelCustomer.TabIndex = 3;
            labelCustomer.Text = "לקוחות";
            // 
            // tabPageDelete
            // 
            tabPageDelete.Controls.Add(comboBoxDelete);
            tabPageDelete.Controls.Add(buttonDelete);
            tabPageDelete.Controls.Add(labelDeleteIdentity);
            tabPageDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageDelete.Location = new Point(4, 40);
            tabPageDelete.Name = "tabPageDelete";
            tabPageDelete.Size = new Size(872, 414);
            tabPageDelete.TabIndex = 4;
            tabPageDelete.Text = "מחיקה";
            tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // comboBoxDelete
            // 
            comboBoxDelete.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxDelete.FormattingEnabled = true;
            comboBoxDelete.Location = new Point(271, 80);
            comboBoxDelete.Name = "comboBoxDelete";
            comboBoxDelete.Size = new Size(151, 30);
            comboBoxDelete.TabIndex = 5;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.Location = new Point(370, 151);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(151, 52);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "מחיקה";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelDeleteIdentity
            // 
            labelDeleteIdentity.AutoSize = true;
            labelDeleteIdentity.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDeleteIdentity.Location = new Point(428, 80);
            labelDeleteIdentity.Name = "labelDeleteIdentity";
            labelDeleteIdentity.Size = new Size(214, 33);
            labelDeleteIdentity.TabIndex = 1;
            labelDeleteIdentity.Text = "ת\"ז הלקוח למחיקה:";
            // 
            // tabPageUpdate
            // 
            tabPageUpdate.Controls.Add(comboBoxIdentityUpdate);
            tabPageUpdate.Controls.Add(textBoxPhoneUpdate);
            tabPageUpdate.Controls.Add(textBoxAddressUpdate);
            tabPageUpdate.Controls.Add(textBoxNameUpdate);
            tabPageUpdate.Controls.Add(labelPhoneUpdate);
            tabPageUpdate.Controls.Add(labelAddressUpdate);
            tabPageUpdate.Controls.Add(labelNameUpdate);
            tabPageUpdate.Controls.Add(labelIdententityUpdate);
            tabPageUpdate.Controls.Add(buttonUpdate);
            tabPageUpdate.Location = new Point(4, 40);
            tabPageUpdate.Name = "tabPageUpdate";
            tabPageUpdate.Size = new Size(872, 414);
            tabPageUpdate.TabIndex = 3;
            tabPageUpdate.Text = "עריכה";
            tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // comboBoxIdentityUpdate
            // 
            comboBoxIdentityUpdate.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxIdentityUpdate.FormattingEnabled = true;
            comboBoxIdentityUpdate.Location = new Point(288, 52);
            comboBoxIdentityUpdate.Name = "comboBoxIdentityUpdate";
            comboBoxIdentityUpdate.Size = new Size(181, 30);
            comboBoxIdentityUpdate.TabIndex = 22;
            comboBoxIdentityUpdate.SelectedIndexChanged += comboBoxIdentityUpdate_SelectedIndexChanged;
            // 
            // textBoxPhoneUpdate
            // 
            textBoxPhoneUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPhoneUpdate.Location = new Point(288, 243);
            textBoxPhoneUpdate.Name = "textBoxPhoneUpdate";
            textBoxPhoneUpdate.Size = new Size(181, 38);
            textBoxPhoneUpdate.TabIndex = 19;
            // 
            // textBoxAddressUpdate
            // 
            textBoxAddressUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxAddressUpdate.Location = new Point(288, 175);
            textBoxAddressUpdate.Name = "textBoxAddressUpdate";
            textBoxAddressUpdate.Size = new Size(181, 38);
            textBoxAddressUpdate.TabIndex = 20;
            // 
            // textBoxNameUpdate
            // 
            textBoxNameUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxNameUpdate.Location = new Point(288, 106);
            textBoxNameUpdate.Name = "textBoxNameUpdate";
            textBoxNameUpdate.Size = new Size(181, 38);
            textBoxNameUpdate.TabIndex = 21;
            // 
            // labelPhoneUpdate
            // 
            labelPhoneUpdate.AutoSize = true;
            labelPhoneUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhoneUpdate.Location = new Point(493, 243);
            labelPhoneUpdate.Name = "labelPhoneUpdate";
            labelPhoneUpdate.Size = new Size(77, 33);
            labelPhoneUpdate.TabIndex = 15;
            labelPhoneUpdate.Text = "טלפון:";
            // 
            // labelAddressUpdate
            // 
            labelAddressUpdate.AutoSize = true;
            labelAddressUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddressUpdate.Location = new Point(493, 180);
            labelAddressUpdate.Name = "labelAddressUpdate";
            labelAddressUpdate.Size = new Size(87, 33);
            labelAddressUpdate.TabIndex = 16;
            labelAddressUpdate.Text = "כתובת:";
            // 
            // labelNameUpdate
            // 
            labelNameUpdate.AutoSize = true;
            labelNameUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelNameUpdate.Location = new Point(493, 111);
            labelNameUpdate.Name = "labelNameUpdate";
            labelNameUpdate.Size = new Size(111, 33);
            labelNameUpdate.TabIndex = 17;
            labelNameUpdate.Text = "שם לקוח:";
            // 
            // labelIdententityUpdate
            // 
            labelIdententityUpdate.AutoSize = true;
            labelIdententityUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdententityUpdate.Location = new Point(493, 46);
            labelIdententityUpdate.Name = "labelIdententityUpdate";
            labelIdententityUpdate.Size = new Size(138, 33);
            labelIdententityUpdate.TabIndex = 18;
            labelIdententityUpdate.Text = "תעודת זהות:";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(210, 326);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(152, 50);
            buttonUpdate.TabIndex = 14;
            buttonUpdate.Text = "עדכון";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // tabPageRead
            // 
            tabPageRead.Controls.Add(labelSelectCustomer);
            tabPageRead.Controls.Add(comboBoxReadOne);
            tabPageRead.Controls.Add(listBoxRead);
            tabPageRead.Controls.Add(buttonReadOne);
            tabPageRead.Controls.Add(buttonReadAllWithFilter);
            tabPageRead.Controls.Add(buttonReadAll);
            tabPageRead.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageRead.Location = new Point(4, 40);
            tabPageRead.Name = "tabPageRead";
            tabPageRead.Padding = new Padding(3);
            tabPageRead.Size = new Size(872, 414);
            tabPageRead.TabIndex = 1;
            tabPageRead.Text = "תצוגה";
            tabPageRead.UseVisualStyleBackColor = true;
            // 
            // labelSelectCustomer
            // 
            labelSelectCustomer.AutoSize = true;
            labelSelectCustomer.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelSelectCustomer.Location = new Point(605, 224);
            labelSelectCustomer.Name = "labelSelectCustomer";
            labelSelectCustomer.Size = new Size(249, 27);
            labelSelectCustomer.TabIndex = 9;
            labelSelectCustomer.Text = "בחר ת\"ז לקוח מהרשימה:";
            // 
            // comboBoxReadOne
            // 
            comboBoxReadOne.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxReadOne.FormattingEnabled = true;
            comboBoxReadOne.Location = new Point(653, 254);
            comboBoxReadOne.Name = "comboBoxReadOne";
            comboBoxReadOne.Size = new Size(151, 30);
            comboBoxReadOne.TabIndex = 8;
            // 
            // listBoxRead
            // 
            listBoxRead.FormattingEnabled = true;
            listBoxRead.ItemHeight = 20;
            listBoxRead.Location = new Point(19, 3);
            listBoxRead.Name = "listBoxRead";
            listBoxRead.Size = new Size(567, 404);
            listBoxRead.TabIndex = 7;
            // 
            // buttonReadOne
            // 
            buttonReadOne.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReadOne.Location = new Point(650, 290);
            buttonReadOne.Name = "buttonReadOne";
            buttonReadOne.Size = new Size(157, 37);
            buttonReadOne.TabIndex = 4;
            buttonReadOne.Text = "הצגת לקוח זה";
            buttonReadOne.UseVisualStyleBackColor = true;
            buttonReadOne.Click += buttonReadOne_Click;
            // 
            // buttonReadAllWithFilter
            // 
            buttonReadAllWithFilter.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReadAllWithFilter.Location = new Point(605, 131);
            buttonReadAllWithFilter.Name = "buttonReadAllWithFilter";
            buttonReadAllWithFilter.Size = new Size(246, 69);
            buttonReadAllWithFilter.TabIndex = 5;
            buttonReadAllWithFilter.Text = "כל הלקוחות שגרים במודיעין עילית";
            buttonReadAllWithFilter.UseVisualStyleBackColor = true;
            buttonReadAllWithFilter.Click += buttonReadAllWithFilter_Click;
            // 
            // buttonReadAll
            // 
            buttonReadAll.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReadAll.Location = new Point(653, 60);
            buttonReadAll.Name = "buttonReadAll";
            buttonReadAll.Size = new Size(165, 49);
            buttonReadAll.TabIndex = 6;
            buttonReadAll.Text = "כל הלקוחות";
            buttonReadAll.UseVisualStyleBackColor = true;
            buttonReadAll.Click += buttonReadAll_Click;
            // 
            // tabPageCreate
            // 
            tabPageCreate.Controls.Add(textBoxPhoneCreate);
            tabPageCreate.Controls.Add(textBoxAddressCreate);
            tabPageCreate.Controls.Add(textBoxNameCreate);
            tabPageCreate.Controls.Add(textBoxIdentityCreate);
            tabPageCreate.Controls.Add(buttonCreate);
            tabPageCreate.Controls.Add(labelPhoneCreate);
            tabPageCreate.Controls.Add(labelAddressCreate);
            tabPageCreate.Controls.Add(labelNameCreate);
            tabPageCreate.Controls.Add(labelIdentityCreate);
            tabPageCreate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tabPageCreate.Location = new Point(4, 40);
            tabPageCreate.Name = "tabPageCreate";
            tabPageCreate.Padding = new Padding(3);
            tabPageCreate.Size = new Size(872, 414);
            tabPageCreate.TabIndex = 0;
            tabPageCreate.Text = "הוספה";
            tabPageCreate.UseVisualStyleBackColor = true;
            // 
            // textBoxPhoneCreate
            // 
            textBoxPhoneCreate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPhoneCreate.Location = new Point(313, 254);
            textBoxPhoneCreate.Name = "textBoxPhoneCreate";
            textBoxPhoneCreate.Size = new Size(181, 38);
            textBoxPhoneCreate.TabIndex = 7;
            // 
            // textBoxAddressCreate
            // 
            textBoxAddressCreate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxAddressCreate.Location = new Point(313, 186);
            textBoxAddressCreate.Name = "textBoxAddressCreate";
            textBoxAddressCreate.Size = new Size(181, 38);
            textBoxAddressCreate.TabIndex = 7;
            // 
            // textBoxNameCreate
            // 
            textBoxNameCreate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxNameCreate.Location = new Point(313, 117);
            textBoxNameCreate.Name = "textBoxNameCreate";
            textBoxNameCreate.Size = new Size(181, 38);
            textBoxNameCreate.TabIndex = 7;
            // 
            // textBoxIdentityCreate
            // 
            textBoxIdentityCreate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxIdentityCreate.Location = new Point(313, 52);
            textBoxIdentityCreate.Name = "textBoxIdentityCreate";
            textBoxIdentityCreate.Size = new Size(181, 38);
            textBoxIdentityCreate.TabIndex = 7;
            // 
            // buttonCreate
            // 
            buttonCreate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreate.Location = new Point(231, 321);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(151, 52);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "הוספה";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // labelPhoneCreate
            // 
            labelPhoneCreate.AutoSize = true;
            labelPhoneCreate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhoneCreate.Location = new Point(518, 254);
            labelPhoneCreate.Name = "labelPhoneCreate";
            labelPhoneCreate.Size = new Size(77, 33);
            labelPhoneCreate.TabIndex = 0;
            labelPhoneCreate.Text = "טלפון:";
            // 
            // labelAddressCreate
            // 
            labelAddressCreate.AutoSize = true;
            labelAddressCreate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddressCreate.Location = new Point(518, 191);
            labelAddressCreate.Name = "labelAddressCreate";
            labelAddressCreate.Size = new Size(87, 33);
            labelAddressCreate.TabIndex = 0;
            labelAddressCreate.Text = "כתובת:";
            // 
            // labelNameCreate
            // 
            labelNameCreate.AutoSize = true;
            labelNameCreate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelNameCreate.Location = new Point(518, 122);
            labelNameCreate.Name = "labelNameCreate";
            labelNameCreate.Size = new Size(111, 33);
            labelNameCreate.TabIndex = 0;
            labelNameCreate.Text = "שם לקוח:";
            // 
            // labelIdentityCreate
            // 
            labelIdentityCreate.AutoSize = true;
            labelIdentityCreate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdentityCreate.Location = new Point(518, 57);
            labelIdentityCreate.Name = "labelIdentityCreate";
            labelIdentityCreate.Size = new Size(138, 33);
            labelIdentityCreate.TabIndex = 0;
            labelIdentityCreate.Text = "תעודת זהות:";
            // 
            // tabControlCustomer
            // 
            tabControlCustomer.Controls.Add(tabPageCreate);
            tabControlCustomer.Controls.Add(tabPageRead);
            tabControlCustomer.Controls.Add(tabPageUpdate);
            tabControlCustomer.Controls.Add(tabPageDelete);
            tabControlCustomer.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlCustomer.Location = new Point(54, 127);
            tabControlCustomer.Name = "tabControlCustomer";
            tabControlCustomer.RightToLeft = RightToLeft.Yes;
            tabControlCustomer.RightToLeftLayout = true;
            tabControlCustomer.SelectedIndex = 0;
            tabControlCustomer.Size = new Size(880, 458);
            tabControlCustomer.TabIndex = 2;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(labelCustomer);
            Controls.Add(tabControlCustomer);
            Name = "FormCustomer";
            Text = "Customers";
            tabPageDelete.ResumeLayout(false);
            tabPageDelete.PerformLayout();
            tabPageUpdate.ResumeLayout(false);
            tabPageUpdate.PerformLayout();
            tabPageRead.ResumeLayout(false);
            tabPageRead.PerformLayout();
            tabPageCreate.ResumeLayout(false);
            tabPageCreate.PerformLayout();
            tabControlCustomer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelCustomer;
        private TabPage tabPageDelete;
        private Button buttonDelete;
        private Label labelDeleteIdentity;
        private TabPage tabPageUpdate;
        private Button buttonUpdate;
        private TabPage tabPageRead;
        private TabPage tabPageCreate;
        private TextBox textBoxPhoneCreate;
        private TextBox textBoxAddressCreate;
        private TextBox textBoxNameCreate;
        private TextBox textBoxIdentityCreate;
        private Button buttonCreate;
        private Label labelPhoneCreate;
        private Label labelAddressCreate;
        private Label labelNameCreate;
        private Label labelIdentityCreate;
        private TabControl tabControlCustomer;
        private TextBox textBoxPhoneUpdate;
        private TextBox textBoxAddressUpdate;
        private TextBox textBoxNameUpdate;
        private Label labelPhoneUpdate;
        private Label labelAddressUpdate;
        private Label labelNameUpdate;
        private Label labelIdententityUpdate;
        private Label labelSelectCustomer;
        private ComboBox comboBoxReadOne;
        private ListBox listBoxRead;
        private Button buttonReadOne;
        private Button buttonReadAllWithFilter;
        private Button buttonReadAll;
        private ComboBox comboBoxIdentityUpdate;
        private ComboBox comboBoxDelete;
    }
}