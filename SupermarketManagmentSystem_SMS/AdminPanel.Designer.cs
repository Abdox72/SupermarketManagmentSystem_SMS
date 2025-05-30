namespace SupermarketManagmentSystem_SMS
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            AddButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            controlBoxEdit1 = new ReaLTaiizor.Controls.ControlBoxEdit();
            panel1 = new Panel();
            label1 = new Label();
            LogoutButton = new Button();
            ReportsButton = new Button();
            CategoriesButton = new Button();
            ProductsButton = new Button();
            UsersButton = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Price, Stock, ID });
            dataGridView1.Location = new Point(269, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(700, 350);
            dataGridView1.TabIndex = 21;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 200;
            // 
            // Price
            // 
            Price.HeaderText = "price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.Width = 125;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 200;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            AddButton.Location = new Point(809, 440);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(160, 50);
            AddButton.TabIndex = 20;
            AddButton.Text = "اليوم";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            DeleteButton.Location = new Point(548, 440);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(160, 50);
            DeleteButton.TabIndex = 19;
            DeleteButton.Text = "الشهر";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            UpdateButton.Location = new Point(284, 440);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(160, 50);
            UpdateButton.TabIndex = 18;
            UpdateButton.Text = "السنة";
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // controlBoxEdit1
            // 
            controlBoxEdit1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBoxEdit1.BackColor = Color.Transparent;
            controlBoxEdit1.DefaultLocation = true;
            controlBoxEdit1.Location = new Point(892, -1);
            controlBoxEdit1.Name = "controlBoxEdit1";
            controlBoxEdit1.Size = new Size(77, 19);
            controlBoxEdit1.TabIndex = 17;
            controlBoxEdit1.Text = "controlBoxEdit1";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LogoutButton);
            panel1.Controls.Add(ReportsButton);
            panel1.Controls.Add(CategoriesButton);
            panel1.Controls.Add(ProductsButton);
            panel1.Controls.Add(UsersButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 553);
            panel1.TabIndex = 16;
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
            UsersButton.Click += UsersButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(548, 377);
            label2.Name = "label2";
            label2.Size = new Size(128, 41);
            label2.TabIndex = 22;
            label2.Text = "المبيعات";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 553);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(AddButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(controlBoxEdit1);
            Controls.Add(panel1);
            //Name = "AdminPanel";
            Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn ID;
        private Button AddButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private ReaLTaiizor.Controls.ControlBoxEdit controlBoxEdit1;
        private Panel panel1;
        private Label label1;
        private Button LogoutButton;
        private Button ReportsButton;
        private Button CategoriesButton;
        private Button ProductsButton;
        private Button UsersButton;
        private Label label2;
    }
}