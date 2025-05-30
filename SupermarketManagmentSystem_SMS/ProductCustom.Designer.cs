namespace SupermarketManagmentSystem_SMS
{
    partial class ProductCustom
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            PriceNumeric1 = new NumericUpDown();
            QuantityNumeric = new NumericUpDown();
            addButton = new ReaLTaiizor.Controls.DungeonButtonRight();
            ProductPictureBox = new PictureBox();
            SelectImageButton = new ReaLTaiizor.Controls.DungeonButtonLeft();
            CategoryComboBox = new ComboBox();
            ProductGridView = new DataGridView();
            foxLabel5 = new ReaLTaiizor.Controls.FoxLabel();
            BarcodeTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            NameTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            foxLabel4 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            categoryBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PriceNumeric1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuantityNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.AddProduct;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(PriceNumeric1);
            panel1.Controls.Add(QuantityNumeric);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(ProductPictureBox);
            panel1.Controls.Add(SelectImageButton);
            panel1.Controls.Add(CategoryComboBox);
            panel1.Controls.Add(ProductGridView);
            panel1.Controls.Add(foxLabel5);
            panel1.Controls.Add(BarcodeTextBox);
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(foxLabel4);
            panel1.Controls.Add(foxLabel3);
            panel1.Controls.Add(foxLabel2);
            panel1.Controls.Add(foxLabel1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(816, 485);
            panel1.TabIndex = 0;
            // 
            // PriceNumeric1
            // 
            PriceNumeric1.Location = new Point(438, 309);
            PriceNumeric1.Name = "PriceNumeric1";
            PriceNumeric1.Size = new Size(254, 23);
            PriceNumeric1.TabIndex = 21;
            // 
            // QuantityNumeric
            // 
            QuantityNumeric.Location = new Point(438, 244);
            QuantityNumeric.Name = "QuantityNumeric";
            QuantityNumeric.Size = new Size(254, 23);
            QuantityNumeric.TabIndex = 20;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Transparent;
            addButton.BorderColor = Color.FromArgb(162, 120, 101);
            addButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addButton.Image = null;
            addButton.ImageAlign = ContentAlignment.MiddleLeft;
            addButton.InactiveColorA = Color.FromArgb(253, 175, 143);
            addButton.InactiveColorB = Color.FromArgb(244, 146, 106);
            addButton.Location = new Point(300, 431);
            addButton.Name = "addButton";
            addButton.PressedColorA = Color.FromArgb(244, 146, 106);
            addButton.PressedColorB = Color.FromArgb(244, 146, 106);
            addButton.PressedContourColorA = Color.FromArgb(162, 120, 101);
            addButton.PressedContourColorB = Color.FromArgb(162, 120, 101);
            addButton.Size = new Size(177, 30);
            addButton.TabIndex = 17;
            addButton.Text = "اضف";
            addButton.TextAlignment = StringAlignment.Center;
            addButton.Click += addButton_Click;
            // 
            // ProductPictureBox
            // 
            ProductPictureBox.Location = new Point(20, 338);
            ProductPictureBox.Name = "ProductPictureBox";
            ProductPictureBox.Size = new Size(175, 123);
            ProductPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductPictureBox.TabIndex = 15;
            ProductPictureBox.TabStop = false;
            ProductPictureBox.Visible = false;
            // 
            // SelectImageButton
            // 
            SelectImageButton.BackColor = Color.Transparent;
            SelectImageButton.BorderColor = Color.FromArgb(180, 180, 180);
            SelectImageButton.Font = new Font("Segoe UI", 12F);
            SelectImageButton.Image = null;
            SelectImageButton.ImageAlign = ContentAlignment.MiddleLeft;
            SelectImageButton.InactiveColorA = Color.FromArgb(253, 252, 252);
            SelectImageButton.InactiveColorB = Color.FromArgb(239, 237, 236);
            SelectImageButton.Location = new Point(438, 373);
            SelectImageButton.Name = "SelectImageButton";
            SelectImageButton.PressedColorA = Color.FromArgb(226, 226, 226);
            SelectImageButton.PressedColorB = Color.FromArgb(237, 237, 237);
            SelectImageButton.PressedContourColorA = Color.FromArgb(167, 167, 167);
            SelectImageButton.PressedContourColorB = Color.FromArgb(167, 167, 167);
            SelectImageButton.Size = new Size(254, 30);
            SelectImageButton.TabIndex = 14;
            SelectImageButton.Text = "اختار صوره المنتج";
            SelectImageButton.TextAlignment = StringAlignment.Center;
            SelectImageButton.Click += SelectImageButton_Click;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(438, 112);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(254, 23);
            CategoryComboBox.TabIndex = 12;
            // 
            // ProductGridView
            // 
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.Location = new Point(20, 39);
            ProductGridView.Name = "ProductGridView";
            ProductGridView.Size = new Size(412, 293);
            ProductGridView.TabIndex = 11;
            // 
            // foxLabel5
            // 
            foxLabel5.BackColor = Color.Transparent;
            foxLabel5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel5.ForeColor = Color.Black;
            foxLabel5.Location = new Point(736, 185);
            foxLabel5.Name = "foxLabel5";
            foxLabel5.Size = new Size(77, 19);
            foxLabel5.TabIndex = 9;
            foxLabel5.Text = "الباركود";
            // 
            // BarcodeTextBox
            // 
            BarcodeTextBox.BackColor = Color.White;
            BarcodeTextBox.BaseColor = Color.FromArgb(44, 55, 66);
            BarcodeTextBox.BorderColorA = Color.FromArgb(64, 158, 255);
            BarcodeTextBox.BorderColorB = Color.FromArgb(220, 223, 230);
            BarcodeTextBox.Font = new Font("Segoe UI", 12F);
            BarcodeTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            BarcodeTextBox.Hint = "";
            BarcodeTextBox.Location = new Point(438, 166);
            BarcodeTextBox.MaxLength = 32767;
            BarcodeTextBox.Multiline = false;
            BarcodeTextBox.Name = "BarcodeTextBox";
            BarcodeTextBox.PasswordChar = '\0';
            BarcodeTextBox.ScrollBars = ScrollBars.None;
            BarcodeTextBox.SelectedText = "";
            BarcodeTextBox.SelectionLength = 0;
            BarcodeTextBox.SelectionStart = 0;
            BarcodeTextBox.Size = new Size(254, 38);
            BarcodeTextBox.TabIndex = 5;
            BarcodeTextBox.TabStop = false;
            BarcodeTextBox.UseSystemPasswordChar = false;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.White;
            NameTextBox.BaseColor = Color.FromArgb(44, 55, 66);
            NameTextBox.BorderColorA = Color.FromArgb(64, 158, 255);
            NameTextBox.BorderColorB = Color.FromArgb(220, 223, 230);
            NameTextBox.Font = new Font("Segoe UI", 12F);
            NameTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            NameTextBox.Hint = "";
            NameTextBox.Location = new Point(438, 39);
            NameTextBox.MaxLength = 32767;
            NameTextBox.Multiline = false;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PasswordChar = '\0';
            NameTextBox.ScrollBars = ScrollBars.None;
            NameTextBox.SelectedText = "";
            NameTextBox.SelectionLength = 0;
            NameTextBox.SelectionStart = 0;
            NameTextBox.Size = new Size(254, 38);
            NameTextBox.TabIndex = 4;
            NameTextBox.TabStop = false;
            NameTextBox.UseSystemPasswordChar = false;
            // 
            // foxLabel4
            // 
            foxLabel4.BackColor = Color.Transparent;
            foxLabel4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel4.ForeColor = Color.Black;
            foxLabel4.Location = new Point(736, 244);
            foxLabel4.Name = "foxLabel4";
            foxLabel4.Size = new Size(77, 19);
            foxLabel4.TabIndex = 3;
            foxLabel4.Text = "الكميه";
            // 
            // foxLabel3
            // 
            foxLabel3.BackColor = Color.Transparent;
            foxLabel3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel3.ForeColor = Color.Black;
            foxLabel3.Location = new Point(736, 300);
            foxLabel3.Name = "foxLabel3";
            foxLabel3.Size = new Size(77, 19);
            foxLabel3.TabIndex = 2;
            foxLabel3.Text = "السعر";
            // 
            // foxLabel2
            // 
            foxLabel2.BackColor = Color.Transparent;
            foxLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel2.ForeColor = Color.Black;
            foxLabel2.Location = new Point(736, 112);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(77, 19);
            foxLabel2.TabIndex = 1;
            foxLabel2.Text = "الصنف";
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel1.ForeColor = Color.Black;
            foxLabel1.Location = new Point(736, 48);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(77, 19);
            foxLabel1.TabIndex = 0;
            foxLabel1.Text = "اسم المنتج";
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Models.Category);
            // 
            // ProductCustom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ProductCustom";
            Size = new Size(821, 491);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PriceNumeric1).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuantityNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel4;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.HopeTextBox BarcodeTextBox;
        private ReaLTaiizor.Controls.HopeTextBox NameTextBox;
        private ReaLTaiizor.Controls.FoxLabel foxLabel5;
        private DataGridView ProductGridView;
        private ComboBox CategoryComboBox;
        private BindingSource categoryBindingSource;
        private PictureBox ProductPictureBox;
        private ReaLTaiizor.Controls.DungeonButtonLeft SelectImageButton;
        private ReaLTaiizor.Controls.DungeonButtonRight addButton;
        private ReaLTaiizor.Controls.HopeTextBox PriceNumeric;
        private NumericUpDown QuantityNumeric;
        private NumericUpDown PriceNumeric1;
    }
}
