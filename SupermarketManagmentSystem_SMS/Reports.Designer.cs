namespace SupermarketManagmentSystem_SMS
{
    partial class Reports
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
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnPrint;
        private void InitializeComponent()
        {
            btnDay = new Button();
            btnMonth = new Button();
            btnYear = new Button();
            btnPrint = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            lblTitle = new Label();
            dgvSales = new DataGridView();
            lblTotal = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // btnDay
            // 
            btnDay.Anchor = AnchorStyles.Top;
            btnDay.BackColor = Color.Crimson;
            btnDay.Cursor = Cursors.Hand;
            btnDay.FlatStyle = FlatStyle.Flat;
            btnDay.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDay.ForeColor = SystemColors.HighlightText;
            btnDay.Location = new Point(399, 22);
            btnDay.Name = "btnDay";
            btnDay.Size = new Size(157, 50);
            btnDay.TabIndex = 2;
            btnDay.Text = "اليوم";
            btnDay.UseVisualStyleBackColor = false;
            btnDay.Click += btnDay_Click;
            // 
            // btnMonth
            // 
            btnMonth.Anchor = AnchorStyles.Top;
            btnMonth.BackColor = Color.Crimson;
            btnMonth.Cursor = Cursors.Hand;
            btnMonth.FlatStyle = FlatStyle.Flat;
            btnMonth.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMonth.ForeColor = SystemColors.HighlightText;
            btnMonth.Location = new Point(586, 22);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(157, 50);
            btnMonth.TabIndex = 3;
            btnMonth.Text = "الشهر";
            btnMonth.UseVisualStyleBackColor = false;
            btnMonth.Click += btnMonth_Click;
            // 
            // btnYear
            // 
            btnYear.Anchor = AnchorStyles.Top;
            btnYear.BackColor = Color.Crimson;
            btnYear.Cursor = Cursors.Hand;
            btnYear.FlatStyle = FlatStyle.Flat;
            btnYear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnYear.ForeColor = SystemColors.HighlightText;
            btnYear.Location = new Point(765, 22);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(157, 50);
            btnYear.TabIndex = 4;
            btnYear.Text = "السنة";
            btnYear.UseVisualStyleBackColor = false;
            btnYear.Click += btnYear_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top;
            btnPrint.BackColor = Color.Crimson;
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnPrint.ForeColor = SystemColors.HighlightText;
            btnPrint.Location = new Point(60, 22);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(157, 50);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "طباعة";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnYear);
            panel1.Controls.Add(btnMonth);
            panel1.Controls.Add(btnDay);
            panel1.Controls.Add(btnPrint);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 440);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 113);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(dgvSales);
            panel2.Controls.Add(lblTotal);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 440);
            panel2.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.BackColor = Color.Brown;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(60, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(862, 55);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "تقارير المبيعات";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToOrderColumns = true;
            dgvSales.Anchor = AnchorStyles.None;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.BorderStyle = BorderStyle.None;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(60, 68);
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.RightToLeft = RightToLeft.Yes;
            dgvSales.RowHeadersWidth = 100;
            dgvSales.Size = new Size(862, 300);
            dgvSales.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.BackColor = Color.Firebrick;
            lblTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.HighlightText;
            lblTotal.Location = new Point(60, 378);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(862, 50);
            lblTotal.TabIndex = 9;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Reports";
            Text = "ReportsForm";
            Load += Reports_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblTitle;
        private DataGridView dgvSales;
        private Label lblTotal;
    }
}