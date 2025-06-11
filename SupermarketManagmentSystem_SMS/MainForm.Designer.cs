namespace SupermarketManagmentSystem_SMS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bufferedPanel1 = new UserControls.BufferedPanel();
            bufferedPanel3 = new UserControls.BufferedPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            bufferedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // bufferedPanel1
            // 
            bufferedPanel1.BackColor = Color.MidnightBlue;
            bufferedPanel1.Controls.Add(iconButton1);
            bufferedPanel1.Dock = DockStyle.Right;
            bufferedPanel1.Location = new Point(1035, 0);
            bufferedPanel1.Margin = new Padding(0);
            bufferedPanel1.Name = "bufferedPanel1";
            bufferedPanel1.Size = new Size(160, 502);
            bufferedPanel1.TabIndex = 0;
            // 
            // bufferedPanel3
            // 
            bufferedPanel3.BackColor = Color.CornflowerBlue;
            bufferedPanel3.Dock = DockStyle.Fill;
            bufferedPanel3.Location = new Point(0, 0);
            bufferedPanel3.Margin = new Padding(0);
            bufferedPanel3.Name = "bufferedPanel3";
            bufferedPanel3.Size = new Size(1035, 502);
            bufferedPanel3.TabIndex = 2;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.DarkCyan;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Cooper Arabic", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            iconButton1.ForeColor = SystemColors.HighlightText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Odysee;
            iconButton1.IconColor = Color.BurlyWood;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(0, 96);
            iconButton1.Margin = new Padding(0, 0, 0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(160, 46);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "وحدة التحكم";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1195, 502);
            Controls.Add(bufferedPanel3);
            Controls.Add(bufferedPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            Text = "الرئيسية";
            Load += MainForm_Load;
            bufferedPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UserControls.BufferedPanel bufferedPanel1;
        private UserControls.BufferedPanel bufferedPanel3;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}