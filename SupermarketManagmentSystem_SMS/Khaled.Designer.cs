namespace SupermarketManagmentSystem_SMS
{
    partial class Khaled
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khaled));
            panel1 = new Panel();
            label1 = new Label();
            LogoutButton = new Button();
            ReportsButton = new Button();
            CategoriesButton = new Button();
            ProductsButton = new Button();
            UsersButton = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LogoutButton);
            panel1.Controls.Add(ReportsButton);
            panel1.Controls.Add(CategoriesButton);
            panel1.Controls.Add(ProductsButton);
            panel1.Controls.Add(UsersButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 600);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 10);
            label1.Name = "label1";
            label1.Size = new Size(70, 31);
            label1.TabIndex = 5;
            label1.Text = "مرحباً ";
            // 
            // LogoutButton
            // 
            LogoutButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutButton.Location = new Point(35, 440);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(151, 40);
            LogoutButton.TabIndex = 4;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // ReportsButton
            // 
            ReportsButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReportsButton.Location = new Point(35, 325);
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(151, 40);
            ReportsButton.TabIndex = 3;
            ReportsButton.Text = "Reports";
            ReportsButton.UseVisualStyleBackColor = true;
            // 
            // CategoriesButton
            // 
            CategoriesButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoriesButton.Location = new Point(35, 250);
            CategoriesButton.Name = "CategoriesButton";
            CategoriesButton.Size = new Size(151, 40);
            CategoriesButton.TabIndex = 2;
            CategoriesButton.Text = "Categories";
            CategoriesButton.UseVisualStyleBackColor = true;
            // 
            // ProductsButton
            // 
            ProductsButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductsButton.Location = new Point(35, 167);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(151, 40);
            ProductsButton.TabIndex = 1;
            ProductsButton.Text = "Products";
            ProductsButton.UseVisualStyleBackColor = true;
            // 
            // UsersButton
            // 
            UsersButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsersButton.Location = new Point(35, 89);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(151, 40);
            UsersButton.TabIndex = 0;
            UsersButton.Text = "Users";
            UsersButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(226, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 600);
            panel2.TabIndex = 18;
            // 
            // Khaled
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Khaled";
            Size = new Size(1000, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button LogoutButton;
        private Button ReportsButton;
        private Button CategoriesButton;
        private Button ProductsButton;
        private Button UsersButton;
        private Panel panel2;
    }
}
