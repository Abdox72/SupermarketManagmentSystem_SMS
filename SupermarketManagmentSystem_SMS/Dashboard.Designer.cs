namespace SupermarketManagmentSystem_SMS
{
    partial class Dashboard
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
            panel1 = new Panel();
            productCustom = new ProductCustom();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(productCustom);
            panel1.Location = new Point(128, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 493);
            panel1.TabIndex = 0;
            // 
            // productCustom
            // 
            productCustom.Dock = DockStyle.Bottom;
            productCustom.Location = new Point(0, 0);
            productCustom.Name = "productCustom";
            productCustom.ProductBarcode = "";
            productCustom.ProductPrice = "hopeNumeric2";
            productCustom.ProductQuantity = "hopeNumeric1";
            productCustom.selectedImagePath = "";
            productCustom.Size = new Size(824, 493);
            productCustom.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 504);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ProductCustom product1;
        private ProductCustom productView1;
        private Panel panel1;
        private ProductCustom productCustom;
    }
}