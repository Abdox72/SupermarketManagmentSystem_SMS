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
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            bufferedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
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
            bufferedPanel1.Location = new Point(1211, 0);
            bufferedPanel1.Margin = new Padding(0);
            bufferedPanel1.Name = "bufferedPanel1";
            bufferedPanel1.Size = new Size(271, 1055);
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
            OrdersBtn.Location = new Point(109, 195);
            OrdersBtn.Margin = new Padding(0);
            OrdersBtn.Name = "OrdersBtn";
            OrdersBtn.Size = new Size(144, 54);
            OrdersBtn.TabIndex = 7;
            OrdersBtn.Text = "الطلبات";
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
            imageList1.Images.SetKeyName(5, "icons8-product-100.png");
            imageList1.Images.SetKeyName(6, "icons8-settings-48 (1).png");
            imageList1.Images.SetKeyName(7, "icons8-log-out-48.png");
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
            LogoutBtn.Location = new Point(123, 441);
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
            SettingsBtn.Location = new Point(76, 359);
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
            ProductsAndCategoriesBtn.ImageKey = "icons8-product-100.png";
            ProductsAndCategoriesBtn.ImageList = imageList1;
            ProductsAndCategoriesBtn.Location = new Point(17, 277);
            ProductsAndCategoriesBtn.Margin = new Padding(0);
            ProductsAndCategoriesBtn.Name = "ProductsAndCategoriesBtn";
            ProductsAndCategoriesBtn.Size = new Size(240, 54);
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
            pictureBox1.Location = new Point(62, 13);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // contentPanel
            // 
            contentPanel.AutoScroll = true;
            contentPanel.BackColor = Color.CornflowerBlue;
            contentPanel.Controls.Add(pictureBox2);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Margin = new Padding(0);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(10, 55, 10, 20);
            contentPanel.Size = new Size(1211, 1055);
            contentPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.ChatGPT_Image_Jun_15__2025__03_15_41_PM;
            pictureBox2.Location = new Point(10, 55);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1191, 980);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1211, 55);
            panel2.TabIndex = 3;
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
            button3.Location = new Point(50, 11);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(34, 32);
            button3.TabIndex = 12;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(91, 11);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(34, 32);
            button2.TabIndex = 9;
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
            button1.Location = new Point(9, 11);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(34, 32);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CashierMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1482, 1055);
            Controls.Add(panel2);
            Controls.Add(contentPanel);
            Controls.Add(bufferedPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CashierMainForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الرئيسية";
            bufferedPanel1.ResumeLayout(false);
            bufferedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
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
        private Panel panel2;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button3;
    }
}