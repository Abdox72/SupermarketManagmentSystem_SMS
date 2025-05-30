namespace Supermarket_Managment_System_SMS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginBtn = new ReaLTaiizor.Controls.RoyalButton();
            PasswordTextBox = new TextBox();
            NationalIdTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(243, 243, 243);
            LoginBtn.BorderColor = Color.FromArgb(180, 180, 180);
            LoginBtn.BorderThickness = 3;
            LoginBtn.DrawBorder = true;
            LoginBtn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            LoginBtn.ForeColor = Color.FromArgb(31, 31, 31);
            LoginBtn.HotTrackColor = Color.FromArgb(221, 221, 221);
            LoginBtn.Image = null;
            LoginBtn.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.TextOnly;
            LoginBtn.Location = new Point(370, 328);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.PressedColor = Color.FromArgb(51, 102, 255);
            LoginBtn.PressedForeColor = Color.White;
            LoginBtn.Size = new Size(150, 50);
            LoginBtn.TabIndex = 16;
            LoginBtn.Text = "تسجيل الدخول";
            LoginBtn.Click += LoginBtn_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.White;
            PasswordTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            PasswordTextBox.Location = new Point(87, 230);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "  أدخل الرقم السري هنا";
            PasswordTextBox.Size = new Size(433, 34);
            PasswordTextBox.TabIndex = 15;
            // 
            // NationalIdTextBox
            // 
            NationalIdTextBox.BackColor = Color.White;
            NationalIdTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            NationalIdTextBox.Location = new Point(87, 148);
            NationalIdTextBox.Multiline = true;
            NationalIdTextBox.Name = "NationalIdTextBox";
            NationalIdTextBox.PlaceholderText = "  أدخل الرقم القومي هنا";
            NationalIdTextBox.Size = new Size(433, 33);
            NationalIdTextBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(569, 234);
            label2.Name = "label2";
            label2.Size = new Size(90, 24);
            label2.TabIndex = 13;
            label2.Text = "الرقم السري";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(567, 150);
            label1.Name = "label1";
            label1.Size = new Size(91, 24);
            label1.TabIndex = 12;
            label1.Text = "الرقم القومي";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = SupermarketManagmentSystem_SMS.Properties.Resources.tot;
            ClientSize = new Size(747, 527);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTextBox);
            Controls.Add(NationalIdTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            ImeMode = ImeMode.Hiragana;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "صفحة التسجيل";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.RoyalButton LoginBtn;
        private TextBox PasswordTextBox;
        private TextBox NationalIdTextBox;
        private Label label2;
        private Label label1;
    }
}
