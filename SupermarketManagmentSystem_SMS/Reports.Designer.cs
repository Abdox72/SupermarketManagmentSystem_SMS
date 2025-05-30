namespace SupermarketManagmentSystem_SMS
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            dataGridViewOrders = new DataGridView();
            Order = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
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
            dataGridViewTop = new DataGridView();
            product = new DataGridViewTextBoxColumn();
            Countity = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTop).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Columns.AddRange(new DataGridViewColumn[] { Order, Price });
            dataGridViewOrders.Location = new Point(27, 54);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RightToLeft = RightToLeft.Yes;
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(299, 341);
            dataGridViewOrders.TabIndex = 21;
            // 
            // Order
            // 
            Order.HeaderText = "Order";
            Order.MinimumWidth = 6;
            Order.Name = "Order";
            Order.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            AddButton.Location = new Point(507, 430);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(160, 50);
            AddButton.TabIndex = 20;
            AddButton.Text = "اليوم";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            DeleteButton.Location = new Point(264, 430);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(160, 50);
            DeleteButton.TabIndex = 19;
            DeleteButton.Text = "الشهر";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            UpdateButton.Location = new Point(27, 430);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(160, 50);
            UpdateButton.TabIndex = 18;
            UpdateButton.Text = "السنة";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LogoutButton);
            panel1.Controls.Add(ReportsButton);
            panel1.Controls.Add(CategoriesButton);
            panel1.Controls.Add(ProductsButton);
            panel1.Controls.Add(UsersButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 541);
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
            CategoriesButton.Click += CategoriesButton_Click;
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
            ProductsButton.Click += ProductsButton_Click;
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
            // dataGridViewTop
            // 
            dataGridViewTop.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewTop.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewTop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTop.Columns.AddRange(new DataGridViewColumn[] { product, Countity });
            dataGridViewTop.Location = new Point(368, 54);
            dataGridViewTop.Name = "dataGridViewTop";
            dataGridViewTop.RightToLeft = RightToLeft.Yes;
            dataGridViewTop.RowHeadersWidth = 51;
            dataGridViewTop.Size = new Size(299, 341);
            dataGridViewTop.TabIndex = 22;
            dataGridViewTop.CellContentClick += dataGridViewTop_CellContentClick;
            // 
            // product
            // 
            product.HeaderText = "المنتج";
            product.MinimumWidth = 6;
            product.Name = "product";
            product.Width = 125;
            // 
            // Countity
            // 
            Countity.HeaderText = "العدد";
            Countity.MinimumWidth = 6;
            Countity.Name = "Countity";
            Countity.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(129, 9);
            label2.Name = "label2";
            label2.Size = new Size(83, 31);
            label2.TabIndex = 23;
            label2.Text = "Orders";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(484, 9);
            label3.Name = "label3";
            label3.Size = new Size(134, 31);
            label3.TabIndex = 24;
            label3.Text = "الاعلى مبيعاً ";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewOrders);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dataGridViewTop);
            panel2.Controls.Add(UpdateButton);
            panel2.Controls.Add(AddButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(DeleteButton);
            panel2.Location = new Point(232, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 520);
            panel2.TabIndex = 25;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 541);
            Controls.Add(panel2);
            Controls.Add(controlBoxEdit1);
            Controls.Add(panel1);
            Name = "Reports";
            Text = "Repors";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTop).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewOrders;
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
        private DataGridViewTextBoxColumn Order;
        private DataGridViewTextBoxColumn Price;
        private DataGridView dataGridViewTop;
        private DataGridViewTextBoxColumn product;
        private DataGridViewTextBoxColumn Countity;
        private Label label2;
        private Label label3;
        private Panel panel2;
    }
}