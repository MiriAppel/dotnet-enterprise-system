namespace UI
{
    partial class FormEnter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonManager = new Button();
            buttonShopkeeper = new Button();
            labelNameStore = new Label();
            SuspendLayout();
            // 
            // buttonManager
            // 
            buttonManager.Font = new Font("Arial Narrow", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonManager.Location = new Point(510, 265);
            buttonManager.Name = "buttonManager";
            buttonManager.Size = new Size(191, 74);
            buttonManager.TabIndex = 0;
            buttonManager.Text = "מנהל";
            buttonManager.UseVisualStyleBackColor = true;
            buttonManager.Click += buttonManager_Click;
            // 
            // buttonShopkeeper
            // 
            buttonShopkeeper.Font = new Font("Arial Narrow", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShopkeeper.Location = new Point(295, 265);
            buttonShopkeeper.Name = "buttonShopkeeper";
            buttonShopkeeper.Size = new Size(191, 74);
            buttonShopkeeper.TabIndex = 1;
            buttonShopkeeper.Text = "קופאי";
            buttonShopkeeper.UseVisualStyleBackColor = true;
            buttonShopkeeper.Click += buttonShopkeeper_Click;
            // 
            // labelNameStore
            // 
            labelNameStore.AutoSize = true;
            labelNameStore.Font = new Font("MV Boli", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelNameStore.Location = new Point(90, 61);
            labelNameStore.Name = "labelNameStore";
            labelNameStore.Size = new Size(780, 157);
            labelNameStore.TabIndex = 2;
            labelNameStore.Text = "Baby's World";
            // 
            // FormEnter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(labelNameStore);
            Controls.Add(buttonShopkeeper);
            Controls.Add(buttonManager);
            Name = "FormEnter";
            Text = "Baby's World";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonManager;
        private Button buttonShopkeeper;
        private Label labelNameStore;
    }
}