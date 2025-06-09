using SupermarketManagmentSystem_SMS.Data;
using SupermarketManagmentSystem_SMS.UserControls;

namespace SupermarketManagmentSystem_SMS
{
    partial class AdminDashboardForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ContentPanel = new BufferedPanel();
            SidebarPanel = new BufferedPanel();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            TobBarPanel = new BufferedPanel();
            tableLayoutPanel1.SuspendLayout();
            SidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(ContentPanel, 1, 1);
            tableLayoutPanel1.Controls.Add(SidebarPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(hopePictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(TobBarPanel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(982, 553);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ContentPanel
            // 
            ContentPanel.AutoScroll = true;
            ContentPanel.BackColor = Color.Transparent;
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(-47, 83);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1039, 677);
            ContentPanel.TabIndex = 0;
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.DarkGreen;
            SidebarPanel.Controls.Add(iconButton6);
            SidebarPanel.Controls.Add(iconButton5);
            SidebarPanel.Controls.Add(iconButton4);
            SidebarPanel.Controls.Add(iconButton3);
            SidebarPanel.Controls.Add(iconButton2);
            SidebarPanel.Controls.Add(iconButton1);
            SidebarPanel.Dock = DockStyle.Fill;
            SidebarPanel.Location = new Point(998, 83);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(194, 677);
            SidebarPanel.TabIndex = 2;
            // 
            // iconButton6
            // 
            iconButton6.BackColor = Color.DarkGoldenrod;
            iconButton6.Cursor = Cursors.Hand;
            iconButton6.Font = new Font("Andalus", 18F);
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton6.IconColor = Color.Black;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.Location = new Point(26, 440);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(143, 51);
            iconButton6.TabIndex = 5;
            iconButton6.Text = "التقارير";
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.DarkGoldenrod;
            iconButton5.Cursor = Cursors.Hand;
            iconButton5.Font = new Font("Andalus", 18F);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.Location = new Point(26, 343);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(143, 51);
            iconButton5.TabIndex = 4;
            iconButton5.Text = "المستخدمين";
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.DarkGoldenrod;
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.Font = new Font("Andalus", 18F);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(26, 537);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(143, 51);
            iconButton4.TabIndex = 3;
            iconButton4.Text = "الأعدادات";
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.DarkGoldenrod;
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.Font = new Font("Andalus", 18F);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(26, 246);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(143, 51);
            iconButton3.TabIndex = 2;
            iconButton3.Text = "الأصناف";
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.DarkGoldenrod;
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.Font = new Font("Andalus", 18F);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(26, 149);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(143, 51);
            iconButton2.TabIndex = 1;
            iconButton2.Text = "المنتجات";
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.DarkGoldenrod;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.Font = new Font("Andalus", 18F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(26, 52);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(143, 51);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "الرئيسية";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Dock = DockStyle.Fill;
            hopePictureBox1.Image = Properties.Resources.tot;
            hopePictureBox1.Location = new Point(998, 3);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(194, 74);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 3;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // TobBarPanel
            // 
            TobBarPanel.BackColor = Color.DarkCyan;
            TobBarPanel.Dock = DockStyle.Fill;
            TobBarPanel.Location = new Point(-47, 3);
            TobBarPanel.Name = "TobBarPanel";
            TobBarPanel.Size = new Size(1039, 74);
            TobBarPanel.TabIndex = 1;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(982, 553);
            Controls.Add(tableLayoutPanel1);
            Name = "AdminDashboardForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "AdminDashboardForm";
            tableLayoutPanel1.ResumeLayout(false);
            SidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private BufferedPanel SidebarPanel;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private BufferedPanel ContentPanel;
        private BufferedPanel TobBarPanel;
    }
}