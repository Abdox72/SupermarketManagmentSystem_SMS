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
            panel1.AutoSize = true;
            panel1.BackgroundImage = Properties.Resources._11;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(foxLabel1);
            panel1.Controls.Add(NameTextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 523);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            addButton.Location = new Point(408, 479);
            addButton.Margin = new Padding(3, 4, 3, 4);
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
            foxLabel1.BackColor = Color.White;
            foxLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foxLabel1.ForeColor = Color.Black;
            foxLabel1.Location = new Point(547, 286);
            foxLabel1.Margin = new Padding(3, 4, 3, 4);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.RightToLeft = RightToLeft.Yes;
            foxLabel1.Size = new Size(127, 43);
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
            NameTextBox.Location = new Point(227, 286);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.MaxLength = 32767;
            NameTextBox.Multiline = false;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PasswordChar = '\0';
            NameTextBox.ScrollBars = ScrollBars.None;
            NameTextBox.SelectedText = "";
            NameTextBox.SelectionLength = 0;
            NameTextBox.SelectionStart = 0;
            NameTextBox.Size = new Size(290, 43);
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
            Size = new Size(1022, 523);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.HopeTextBox NameTextBox;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.DungeonButtonRight addButton;
    }
}
