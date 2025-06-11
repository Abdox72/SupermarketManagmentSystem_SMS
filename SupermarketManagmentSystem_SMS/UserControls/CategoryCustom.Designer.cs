namespace SupermarketManagmentSystem_SMS
{
    partial class CategoryCustom
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
            panel1 = new Panel();
            DescriptionTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            CategoryDataGridView = new DataGridView();
            addButton = new ReaLTaiizor.Controls.DungeonButtonRight();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            NameTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackgroundImage = Properties.Resources._11;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(DescriptionTextBox);
            panel1.Controls.Add(foxLabel2);
            panel1.Controls.Add(CategoryDataGridView);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(foxLabel1);
            panel1.Controls.Add(NameTextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1168, 697);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BackColor = Color.White;
            DescriptionTextBox.BaseColor = Color.FromArgb(44, 55, 66);
            DescriptionTextBox.BorderColorA = Color.FromArgb(64, 158, 255);
            DescriptionTextBox.BorderColorB = Color.FromArgb(220, 223, 230);
            DescriptionTextBox.Font = new Font("Segoe UI", 12F);
            DescriptionTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            DescriptionTextBox.Hint = "";
            DescriptionTextBox.Location = new Point(703, 105);
            DescriptionTextBox.Margin = new Padding(3, 4, 3, 4);
            DescriptionTextBox.MaxLength = 32767;
            DescriptionTextBox.Multiline = false;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.PasswordChar = '\0';
            DescriptionTextBox.ScrollBars = ScrollBars.None;
            DescriptionTextBox.SelectedText = "";
            DescriptionTextBox.SelectionLength = 0;
            DescriptionTextBox.SelectionStart = 0;
            DescriptionTextBox.Size = new Size(290, 43);
            DescriptionTextBox.TabIndex = 21;
            DescriptionTextBox.TabStop = false;
            DescriptionTextBox.UseSystemPasswordChar = false;
            // 
            // foxLabel2
            // 
            foxLabel2.BackColor = Color.Transparent;
            foxLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel2.ForeColor = Color.Black;
            foxLabel2.Location = new Point(1016, 114);
            foxLabel2.Margin = new Padding(3, 4, 3, 4);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(53, 25);
            foxLabel2.TabIndex = 20;
            foxLabel2.Text = "وصف";
            // 
            // CategoryDataGridView
            // 
            CategoryDataGridView.AllowUserToAddRows = false;
            CategoryDataGridView.AllowUserToDeleteRows = false;
            CategoryDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoryDataGridView.BorderStyle = BorderStyle.Fixed3D;
            CategoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryDataGridView.Location = new Point(38, 15);
            CategoryDataGridView.Margin = new Padding(3, 4, 3, 4);
            CategoryDataGridView.Name = "CategoryDataGridView";
            CategoryDataGridView.ReadOnly = true;
            CategoryDataGridView.RightToLeft = RightToLeft.Yes;
            CategoryDataGridView.RowHeadersWidth = 51;
            CategoryDataGridView.Size = new Size(533, 527);
            CategoryDataGridView.TabIndex = 19;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Green;
            addButton.BackgroundImage = Properties.Resources._11;
            addButton.BorderColor = Color.FromArgb(162, 120, 101);
            addButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            addButton.Image = null;
            addButton.ImageAlign = ContentAlignment.MiddleLeft;
            addButton.InactiveColorA = Color.FromArgb(253, 175, 143);
            addButton.InactiveColorB = Color.FromArgb(244, 146, 106);
            addButton.Location = new Point(791, 318);
            addButton.Margin = new Padding(3, 5, 3, 5);
            addButton.Name = "addButton";
            addButton.PressedColorA = Color.FromArgb(244, 146, 106);
            addButton.PressedColorB = Color.FromArgb(244, 146, 106);
            addButton.PressedContourColorA = Color.FromArgb(162, 120, 101);
            addButton.PressedContourColorB = Color.FromArgb(162, 120, 101);
            addButton.Size = new Size(202, 40);
            addButton.TabIndex = 18;
            addButton.Text = "اضف";
            addButton.TextAlignment = StringAlignment.Center;
            addButton.Click += addButton_Click;
            // 
            // foxLabel1
            // 
            foxLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foxLabel1.ForeColor = Color.Black;
            foxLabel1.Location = new Point(989, 177);
            foxLabel1.Margin = new Padding(3, 5, 3, 5);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.RightToLeft = RightToLeft.Yes;
            foxLabel1.Size = new Size(127, 39);
            foxLabel1.TabIndex = 6;
            foxLabel1.Text = "اسم الصنف  ";
            foxLabel1.Click += foxLabel1_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NameTextBox.BackColor = Color.White;
            NameTextBox.BaseColor = Color.FromArgb(44, 55, 66);
            NameTextBox.BorderColorA = Color.FromArgb(64, 158, 255);
            NameTextBox.BorderColorB = Color.FromArgb(220, 223, 230);
            NameTextBox.Font = new Font("Segoe UI", 12F);
            NameTextBox.ForeColor = Color.FromArgb(48, 49, 51);
            NameTextBox.Hint = "";
            NameTextBox.Location = new Point(259, 381);
            NameTextBox.Margin = new Padding(3, 5, 3, 5);
            NameTextBox.MaxLength = 32767;
            NameTextBox.Multiline = false;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PasswordChar = '\0';
            NameTextBox.ScrollBars = ScrollBars.None;
            NameTextBox.SelectedText = "";
            NameTextBox.SelectionLength = 0;
            NameTextBox.SelectionStart = 0;
            NameTextBox.Size = new Size(290, 51);
            NameTextBox.TabIndex = 5;
            NameTextBox.TabStop = false;
            NameTextBox.UseSystemPasswordChar = false;
            // 
            // CategoryCustom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoryCustom";
            Size = new Size(1168, 697);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CategoryDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.HopeTextBox NameTextBox;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.DungeonButtonRight addButton;
        private DataGridView CategoryDataGridView;
        private ReaLTaiizor.Controls.HopeTextBox DescriptionTextBox;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.DungeonButtonRight EditButton;
    }
}
