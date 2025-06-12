namespace SupermarketManagmentSystem_SMS
{
    partial class CashierMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMainForm));
            bufferedPanel1 = new UserControls.BufferedPanel();
            panel1 = new Panel();
            OrdersBtn = new Button();
            imageList1 = new ImageList(components);
            LogoutBtn = new Button();
            SettingsBtn = new Button();
            ProductsAndCategoriesBtn = new Button();
            pictureBox1 = new PictureBox();
            contentPanel = new UserControls.BufferedPanel();
            bufferedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bufferedPanel1
            // 
            bufferedPanel1.BackColor = Color.MidnightBlue;
            bufferedPanel1.Controls.Add(panel1);
            bufferedPanel1.Controls.Add(OrdersBtn);
            bufferedPanel1.Controls.Add(LogoutBtn);
            bufferedPanel1.Controls.Add(SettingsBtn);
            bufferedPanel1.Controls.Add(ProductsAndCategoriesBtn);
            bufferedPanel1.Controls.Add(pictureBox1);
            bufferedPanel1.Dock = DockStyle.Right;
            bufferedPanel1.Location = new Point(966, 0);
            bufferedPanel1.Margin = new Padding(0);
            bufferedPanel1.Name = "bufferedPanel1";
            bufferedPanel1.Size = new Size(271, 781);
            bufferedPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Location = new Point(-3, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 10);
            panel1.TabIndex = 8;
            // 
            // OrdersBtn
            // 
            OrdersBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrdersBtn.AutoSize = true;
            OrdersBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            OrdersBtn.BackColor = Color.Transparent;
            OrdersBtn.Cursor = Cursors.Hand;
            OrdersBtn.FlatAppearance.BorderSize = 0;
            OrdersBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            OrdersBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            OrdersBtn.FlatStyle = FlatStyle.Flat;
            OrdersBtn.Font = new Font("Andalus", 16.2F);
            OrdersBtn.ForeColor = SystemColors.HighlightText;
            OrdersBtn.ImageKey = "shopping-list.png";
            OrdersBtn.ImageList = imageList1;
            OrdersBtn.Location = new Point(120, 182);
            OrdersBtn.Margin = new Padding(0);
            OrdersBtn.Name = "OrdersBtn";
            OrdersBtn.Size = new Size(129, 53);
            OrdersBtn.TabIndex = 7;
            OrdersBtn.Text = "طلبات";
            OrdersBtn.TextAlign = ContentAlignment.MiddleLeft;
            OrdersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            OrdersBtn.UseVisualStyleBackColor = false;
            OrdersBtn.Click += OrdersBtn_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth24Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "products.png");
            imageList1.Images.SetKeyName(1, "gear.png");
            imageList1.Images.SetKeyName(2, "logout.png");
            imageList1.Images.SetKeyName(3, "shopping-list.png");
            imageList1.Images.SetKeyName(4, "classification.png");
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
            LogoutBtn.Location = new Point(120, 432);
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
            SettingsBtn.Location = new Point(76, 346);
            SettingsBtn.Margin = new Padding(0);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(173, 53);
            SettingsBtn.TabIndex = 5;
            SettingsBtn.Text = "الإعدادات";
            SettingsBtn.TextAlign = ContentAlignment.MiddleLeft;
            SettingsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SettingsBtn.UseVisualStyleBackColor = false;
            // 
            // ProductsAndCategoriesBtn
            // 
            ProductsAndCategoriesBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductsAndCategoriesBtn.AutoSize = true;
            ProductsAndCategoriesBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ProductsAndCategoriesBtn.BackColor = Color.Transparent;
            ProductsAndCategoriesBtn.Cursor = Cursors.Hand;
            ProductsAndCategoriesBtn.FlatAppearance.BorderSize = 0;
            ProductsAndCategoriesBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ProductsAndCategoriesBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ProductsAndCategoriesBtn.FlatStyle = FlatStyle.Flat;
            ProductsAndCategoriesBtn.Font = new Font("Andalus", 16.2F);
            ProductsAndCategoriesBtn.ForeColor = SystemColors.HighlightText;
            ProductsAndCategoriesBtn.ImageKey = "classification.png";
            ProductsAndCategoriesBtn.ImageList = imageList1;
            ProductsAndCategoriesBtn.Location = new Point(11, 262);
            ProductsAndCategoriesBtn.Margin = new Padding(0);
            ProductsAndCategoriesBtn.Name = "ProductsAndCategoriesBtn";
            ProductsAndCategoriesBtn.Size = new Size(238, 53);
            ProductsAndCategoriesBtn.TabIndex = 0;
            ProductsAndCategoriesBtn.Text = "المنتجات والأصناف";
            ProductsAndCategoriesBtn.TextAlign = ContentAlignment.MiddleLeft;
            ProductsAndCategoriesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ProductsAndCategoriesBtn.UseVisualStyleBackColor = false;
            ProductsAndCategoriesBtn.Click += ProductsAndCategoriesBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 13);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 144);
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
            contentPanel.Size = new Size(966, 781);
            contentPanel.TabIndex = 2;
            // 
            // CashierMainForm
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
            Name = "CashierMainForm";
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
        private Button ProductsAndCategoriesBtn;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Button SettingsBtn;
        private Button LogoutBtn;
        private Button OrdersBtn;
        private Panel panel1;
    }
}