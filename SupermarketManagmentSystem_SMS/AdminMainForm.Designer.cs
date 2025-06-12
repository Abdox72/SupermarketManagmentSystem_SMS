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
            bufferedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            bufferedPanel1.Location = new Point(1006, 0);
            bufferedPanel1.Margin = new Padding(0);
            bufferedPanel1.Name = "bufferedPanel1";
            bufferedPanel1.Size = new Size(231, 781);
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
            LogoutBtn.ImageKey = "logout.png";
            LogoutBtn.ImageList = imageList1;
            LogoutBtn.Location = new Point(75, 628);
            LogoutBtn.Margin = new Padding(0);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(129, 53);
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
            SettingsBtn.ImageKey = "gear.png";
            SettingsBtn.ImageList = imageList1;
            SettingsBtn.Location = new Point(31, 542);
            SettingsBtn.Margin = new Padding(0);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(173, 53);
            SettingsBtn.TabIndex = 5;
            SettingsBtn.Text = "الإعدادات";
            SettingsBtn.TextAlign = ContentAlignment.MiddleLeft;
            SettingsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SettingsBtn.UseVisualStyleBackColor = false;
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
            ReportsBtn.ImageKey = "report.png";
            ReportsBtn.ImageList = imageList1;
            ReportsBtn.Location = new Point(60, 456);
            ReportsBtn.Margin = new Padding(0);
            ReportsBtn.Name = "ReportsBtn";
            ReportsBtn.Size = new Size(144, 53);
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
            UsersBtn.ImageKey = "teamwork.png";
            UsersBtn.ImageList = imageList1;
            UsersBtn.Location = new Point(25, 370);
            UsersBtn.Margin = new Padding(0);
            UsersBtn.Name = "UsersBtn";
            UsersBtn.Size = new Size(179, 53);
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
            CategoriesBtn.ImageKey = "categories.png";
            CategoriesBtn.ImageList = imageList1;
            CategoriesBtn.Location = new Point(56, 284);
            CategoriesBtn.Margin = new Padding(0);
            CategoriesBtn.Name = "CategoriesBtn";
            CategoriesBtn.Size = new Size(148, 53);
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
            ProductsBtn.ImageKey = "box.png";
            ProductsBtn.ImageList = imageList1;
            ProductsBtn.Location = new Point(53, 198);
            ProductsBtn.Margin = new Padding(0);
            ProductsBtn.Name = "ProductsBtn";
            ProductsBtn.Size = new Size(151, 53);
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
            pictureBox1.Location = new Point(39, 7);
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
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Margin = new Padding(0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1006, 781);
            contentPanel.TabIndex = 2;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1237, 781);
            Controls.Add(contentPanel);
            Controls.Add(bufferedPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminMainForm";
            RightToLeft = RightToLeft.Yes;
            Text = "الرئيسية";
            bufferedPanel1.ResumeLayout(false);
            bufferedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}