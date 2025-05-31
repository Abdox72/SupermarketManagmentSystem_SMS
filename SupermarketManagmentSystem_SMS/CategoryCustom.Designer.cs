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
            addButton = new ReaLTaiizor.Controls.DungeonButtonRight();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            NameTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.AddProduct;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(foxLabel1);
            panel1.Controls.Add(NameTextBox);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 502);
            panel1.TabIndex = 0;
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
            addButton.Location = new Point(413, 426);
            addButton.Name = "addButton";
            addButton.PressedColorA = Color.FromArgb(244, 146, 106);
            addButton.PressedColorB = Color.FromArgb(244, 146, 106);
            addButton.PressedContourColorA = Color.FromArgb(162, 120, 101);
            addButton.PressedContourColorB = Color.FromArgb(162, 120, 101);
            addButton.Size = new Size(177, 30);
            addButton.TabIndex = 18;
            addButton.Text = "اضف";
            addButton.TextAlignment = StringAlignment.Center;
            addButton.Click += addButton_Click;
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel1.ForeColor = Color.Black;
            foxLabel1.Location = new Point(757, 221);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(77, 19);
            foxLabel1.TabIndex = 6;
            foxLabel1.Text = "اسم الصنف";
            foxLabel1.Click += foxLabel1_Click;
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
            NameTextBox.Location = new Point(487, 211);
            NameTextBox.MaxLength = 32767;
            NameTextBox.Multiline = false;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PasswordChar = '\0';
            NameTextBox.ScrollBars = ScrollBars.None;
            NameTextBox.SelectedText = "";
            NameTextBox.SelectionLength = 0;
            NameTextBox.SelectionStart = 0;
            NameTextBox.Size = new Size(254, 38);
            NameTextBox.TabIndex = 5;
            NameTextBox.TabStop = false;
            NameTextBox.UseSystemPasswordChar = false;
            // 
            // CategoryCustom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "CategoryCustom";
            Size = new Size(891, 508);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.HopeTextBox NameTextBox;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.DungeonButtonRight addButton;
    }
}
