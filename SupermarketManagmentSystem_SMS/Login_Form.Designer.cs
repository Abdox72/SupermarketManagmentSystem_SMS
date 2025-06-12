namespace SupermarketManagmentSystem_SMS
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            PasswordTextBox = new TextBox();
            NationalIdTextBox = new TextBox();
            LoginBtn = new Button();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(329, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 151);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(549, 272);
            label4.Name = "label4";
            label4.Size = new Size(127, 33);
            label4.TabIndex = 46;
            label4.Text = "الرقم السري";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(548, 210);
            label3.Name = "label3";
            label3.Size = new Size(130, 33);
            label3.TabIndex = 45;
            label3.Text = "الرقم القومى";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.White;
            PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordTextBox.Font = new Font("Akhbar MT", 13.8F, FontStyle.Bold);
            PasswordTextBox.Location = new Point(123, 266);
            PasswordTextBox.Margin = new Padding(0);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "  أدخل الرقم السري هنا";
            PasswordTextBox.Size = new Size(412, 46);
            PasswordTextBox.TabIndex = 43;
            // 
            // NationalIdTextBox
            // 
            NationalIdTextBox.BackColor = Color.White;
            NationalIdTextBox.BorderStyle = BorderStyle.FixedSingle;
            NationalIdTextBox.Font = new Font("Akhbar MT", 13.8F, FontStyle.Bold);
            NationalIdTextBox.Location = new Point(123, 204);
            NationalIdTextBox.Margin = new Padding(0);
            NationalIdTextBox.Name = "NationalIdTextBox";
            NationalIdTextBox.PlaceholderText = "  أدخل الرقم القومي هنا";
            NationalIdTextBox.Size = new Size(412, 46);
            NationalIdTextBox.TabIndex = 42;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.RoyalBlue;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatAppearance.BorderColor = Color.MidnightBlue;
            LoginBtn.FlatAppearance.MouseDownBackColor = Color.Navy;
            LoginBtn.FlatAppearance.MouseOverBackColor = Color.Navy;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = SystemColors.HighlightText;
            LoginBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LoginBtn.ImageKey = "user.png";
            LoginBtn.ImageList = imageList1;
            LoginBtn.Location = new Point(343, 335);
            LoginBtn.Margin = new Padding(0);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(192, 58);
            LoginBtn.TabIndex = 48;
            LoginBtn.Text = "تسجيل الدخول";
            LoginBtn.TextAlign = ContentAlignment.MiddleRight;
            LoginBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "person.png");
            imageList1.Images.SetKeyName(1, "login.png");
            imageList1.Images.SetKeyName(2, "user.png");
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(809, 460);
            Controls.Add(LoginBtn);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PasswordTextBox);
            Controls.Add(NationalIdTextBox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login_Form";
            RightToLeft = RightToLeft.Yes;
            Text = "تسجيل الدخول";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private TextBox PasswordTextBox;
        private TextBox NationalIdTextBox;
        private Button LoginBtn;
        private ImageList imageList1;
    }
}