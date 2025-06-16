namespace SupermarketManagmentSystem_SMS
{
    partial class AdminMainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            bufferedPanel1 = new UserControls.BufferedPanel();
            LogoutBtn = new Button();
            imageList1 = new ImageList(components);
            SettingsBtn = new Button();
            ReportsBtn = new Button();
            UsersBtn = new Button();
            CategoriesBtn = new Button();
            ProductsBtn = new Button();
            pictureBox1 = new PictureBox();
            contentPanel = new UserControls.BufferedPanel();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            bufferedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bufferedPanel1
            // 
            bufferedPanel1.BackColor = Color.MidnightBlue;
            bufferedPanel1.Controls.Add(LogoutBtn);
            bufferedPanel1.Controls.Add(SettingsBtn);
            bufferedPanel1.Controls.Add(ReportsBtn);
            bufferedPanel1.Controls.Add(UsersBtn);
            bufferedPanel1.Controls.Add(CategoriesBtn);
            bufferedPanel1.Controls.Add(ProductsBtn);
            bufferedPanel1.Controls.Add(pictureBox1);
            bufferedPanel1.Dock = DockStyle.Right;
            bufferedPanel1.Location = new Point(1269, 0);
            bufferedPanel1.Margin = new Padding(0);
            bufferedPanel1.Name = "bufferedPanel1";
            bufferedPanel1.Size = new Size(231, 1102);
            bufferedPanel1.TabIndex = 0;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LogoutBtn.AutoSize = true;
            LogoutBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LogoutBtn.BackColor = Color.Transparent;
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatAppearance.CheckedBackColor = Color.Transparent;
            LogoutBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            LogoutBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Andalus", 16.2F);
            LogoutBtn.ForeColor = SystemColors.HighlightText;
            LogoutBtn.ImageKey = "icons8-log-out-48.png";
            LogoutBtn.ImageList = imageList1;
            LogoutBtn.Location = new Point(75, 664);
            LogoutBtn.Margin = new Padding(0);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(131, 54);
            LogoutBtn.TabIndex = 6;
            LogoutBtn.Text = "الخروج";
            LogoutBtn.TextAlign = ContentAlignment.MiddleLeft;
            LogoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth24Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "products.png");
            imageList1.Images.SetKeyName(1, "box.png");
            imageList1.Images.SetKeyName(2, "categories.png");
            imageList1.Images.SetKeyName(3, "teamwork.png");
            imageList1.Images.SetKeyName(4, "teamwork.ico");
            imageList1.Images.SetKeyName(5, "man.png");
            imageList1.Images.SetKeyName(6, "report.png");
            imageList1.Images.SetKeyName(7, "gear.png");
            imageList1.Images.SetKeyName(8, "logout.png");
            imageList1.Images.SetKeyName(9, "icons8-product-100.png");
            imageList1.Images.SetKeyName(10, "icons8-product-48.png");
            imageList1.Images.SetKeyName(11, "icons8-category-48.png");
            imageList1.Images.SetKeyName(12, "icons8-sales-48.png");
            imageList1.Images.SetKeyName(13, "icons8-settings-48 (1).png");
            imageList1.Images.SetKeyName(14, "icons8-settings-48.png");
            imageList1.Images.SetKeyName(15, "icons8-report-48.png");
            imageList1.Images.SetKeyName(16, "icons8-user-48.png");
            imageList1.Images.SetKeyName(17, "icons8-category-48 (1).png");
            imageList1.Images.SetKeyName(18, "icons8-category-48.png");
            imageList1.Images.SetKeyName(19, "icons8-log-out-48.png");
            // 
            // SettingsBtn
            // 
            SettingsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SettingsBtn.AutoSize = true;
            SettingsBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SettingsBtn.BackColor = Color.Transparent;
            SettingsBtn.Cursor = Cursors.Hand;
            SettingsBtn.FlatAppearance.BorderSize = 0;
            SettingsBtn.FlatAppearance.CheckedBackColor = Color.Transparent;
            SettingsBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            SettingsBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            SettingsBtn.FlatStyle = FlatStyle.Flat;
            SettingsBtn.Font = new Font("Andalus", 16.2F);
            SettingsBtn.ForeColor = SystemColors.HighlightText;
            SettingsBtn.ImageKey = "icons8-settings-48 (1).png";
            SettingsBtn.ImageList = imageList1;
            SettingsBtn.Location = new Point(31, 578);
            SettingsBtn.Margin = new Padding(0);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(175, 54);
            SettingsBtn.TabIndex = 5;
            SettingsBtn.Text = "الإعدادات";
            SettingsBtn.TextAlign = ContentAlignment.MiddleLeft;
            SettingsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SettingsBtn.UseVisualStyleBackColor = false;
            SettingsBtn.Click += SettingsBtn_Click;
            // 
            // ReportsBtn
            // 
            ReportsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ReportsBtn.AutoSize = true;
            ReportsBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ReportsBtn.BackColor = Color.Transparent;
            ReportsBtn.Cursor = Cursors.Hand;
            ReportsBtn.FlatAppearance.BorderSize = 0;
            ReportsBtn.FlatAppearance.CheckedBackColor = Color.Transparent;
            ReportsBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ReportsBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ReportsBtn.FlatStyle = FlatStyle.Flat;
            ReportsBtn.Font = new Font("Andalus", 16.2F);
            ReportsBtn.ForeColor = SystemColors.HighlightText;
            ReportsBtn.ImageKey = "icons8-report-48.png";
            ReportsBtn.ImageList = imageList1;
            ReportsBtn.Location = new Point(60, 492);
            ReportsBtn.Margin = new Padding(0);
            ReportsBtn.Name = "ReportsBtn";
            ReportsBtn.Size = new Size(146, 54);
            ReportsBtn.TabIndex = 4;
            ReportsBtn.Text = "التقارير";
            ReportsBtn.TextAlign = ContentAlignment.MiddleLeft;
            ReportsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ReportsBtn.UseVisualStyleBackColor = false;
            ReportsBtn.Click += ReportsBtn_Click;
            // 
            // UsersBtn
            // 
            UsersBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UsersBtn.AutoSize = true;
            UsersBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UsersBtn.BackColor = Color.Transparent;
            UsersBtn.Cursor = Cursors.Hand;
            UsersBtn.FlatAppearance.BorderSize = 0;
            UsersBtn.FlatAppearance.CheckedBackColor = Color.Transparent;
            UsersBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            UsersBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            UsersBtn.FlatStyle = FlatStyle.Flat;
            UsersBtn.Font = new Font("Andalus", 16.2F);
            UsersBtn.ForeColor = SystemColors.HighlightText;
            UsersBtn.ImageKey = "icons8-user-48.png";
            UsersBtn.ImageList = imageList1;
            UsersBtn.Location = new Point(25, 406);
            UsersBtn.Margin = new Padding(0);
            UsersBtn.Name = "UsersBtn";
            UsersBtn.Size = new Size(181, 54);
            UsersBtn.TabIndex = 2;
            UsersBtn.Text = "المستخدمين";
            UsersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            UsersBtn.UseVisualStyleBackColor = false;
            UsersBtn.Click += UsersBtn_Click;
            // 
            // CategoriesBtn
            // 
            CategoriesBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoriesBtn.AutoSize = true;
            CategoriesBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CategoriesBtn.BackColor = Color.Transparent;
            CategoriesBtn.Cursor = Cursors.Hand;
            CategoriesBtn.FlatAppearance.BorderSize = 0;
            CategoriesBtn.FlatAppearance.CheckedBackColor = Color.Transparent;
            CategoriesBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CategoriesBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CategoriesBtn.FlatStyle = FlatStyle.Flat;
            CategoriesBtn.Font = new Font("Andalus", 16.2F);
            CategoriesBtn.ForeColor = SystemColors.HighlightText;
            CategoriesBtn.ImageKey = "icons8-category-48.png";
            CategoriesBtn.ImageList = imageList1;
            CategoriesBtn.Location = new Point(56, 320);
            CategoriesBtn.Margin = new Padding(0);
            CategoriesBtn.Name = "CategoriesBtn";
            CategoriesBtn.Size = new Size(150, 54);
            CategoriesBtn.TabIndex = 1;
            CategoriesBtn.Text = "الأصناف";
            CategoriesBtn.TextAlign = ContentAlignment.MiddleLeft;
            CategoriesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            CategoriesBtn.UseVisualStyleBackColor = false;
            CategoriesBtn.Click += CategoriesBtn_Click;
            // 
            // ProductsBtn
            // 
            ProductsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductsBtn.AutoSize = true;
            ProductsBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ProductsBtn.BackColor = Color.Transparent;
            ProductsBtn.Cursor = Cursors.Hand;
            ProductsBtn.FlatAppearance.BorderSize = 0;
            ProductsBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ProductsBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ProductsBtn.FlatStyle = FlatStyle.Flat;
            ProductsBtn.Font = new Font("Andalus", 16.2F);
            ProductsBtn.ForeColor = SystemColors.HighlightText;
            ProductsBtn.ImageKey = "icons8-product-48.png";
            ProductsBtn.ImageList = imageList1;
            ProductsBtn.Location = new Point(53, 234);
            ProductsBtn.Margin = new Padding(0);
            ProductsBtn.Name = "ProductsBtn";
            ProductsBtn.Size = new Size(153, 54);
            ProductsBtn.TabIndex = 0;
            ProductsBtn.Text = "المنتجات";
            ProductsBtn.TextAlign = ContentAlignment.MiddleLeft;
            ProductsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ProductsBtn.UseVisualStyleBackColor = false;
            ProductsBtn.Click += ProductsBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.admin_panel;
            pictureBox1.Location = new Point(39, 17);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.CornflowerBlue;
            contentPanel.Controls.Add(pictureBox2);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Margin = new Padding(0);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(10, 50, 10, 20);
            contentPanel.Size = new Size(1269, 1102);
            contentPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.ChatGPT_Image_Jun_15__2025__03_15_41_PM;
            pictureBox2.Location = new Point(10, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1249, 1032);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(93, 9);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(34, 32);
            button2.TabIndex = 7;
            button2.Text = "—";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(9, 9);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(34, 32);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1269, 50);
            panel1.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.MidnightBlue;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(51, 9);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(34, 32);
            button3.TabIndex = 8;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 1102);
            Controls.Add(panel1);
            Controls.Add(contentPanel);
            Controls.Add(bufferedPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminMainForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الرئيسية";
            bufferedPanel1.ResumeLayout(false);
            bufferedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UserControls.BufferedPanel bufferedPanel1;
        private UserControls.BufferedPanel contentPanel;
        private Button ProductsBtn;
        private ImageList imageList1;
        private Button UsersBtn;
        private Button CategoriesBtn;
        private PictureBox pictureBox1;
        private Button SettingsBtn;
        private Button ReportsBtn;
        private Button LogoutBtn;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button button3;
    }
}