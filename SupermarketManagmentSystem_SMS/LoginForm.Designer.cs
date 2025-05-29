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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(86, 117);
            label1.Name = "label1";
            label1.Size = new Size(91, 24);
            label1.TabIndex = 3;
            label1.Text = "الرقم القومي";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(86, 178);
            label2.Name = "label2";
            label2.Size = new Size(90, 24);
            label2.TabIndex = 4;
            label2.Text = "الرقم السري";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBox1.Location = new Point(192, 114);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "  أدخل الرقم القومي هنا";
            textBox1.Size = new Size(638, 35);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBox2.Location = new Point(192, 175);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "  أدخل الرقم القومي هنا";
            textBox2.Size = new Size(638, 35);
            textBox2.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = SupermarketManagmentSystem_SMS.Properties.Resources.tot;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(882, 430);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.No;
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            ImeMode = ImeMode.Hiragana;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "صفحة التسجيل";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
