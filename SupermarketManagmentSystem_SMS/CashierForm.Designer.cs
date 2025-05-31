namespace SupermarketManagmentSystem_SMS
{
    partial class CashierForm
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
            panel1 = new ReaLTaiizor.Controls.Panel();
            lblCurrentTime = new Label();
            lblShiftStart = new Label();
            lblCashierName = new Label();
            timerClock = new System.Windows.Forms.Timer(components);
            txtBarcodeInput = new TextBox();
            label1 = new Label();
            dgvCart = new DataGridView();
            lblTotal = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblCurrentTime);
            panel1.Controls.Add(lblShiftStart);
            panel1.Controls.Add(lblCashierName);
            panel1.Dock = DockStyle.Top;
            panel1.EdgeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(1166, 91);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Location = new Point(796, 34);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(39, 20);
            lblCurrentTime.TabIndex = 2;
            lblCurrentTime.Text = "time";
            // 
            // lblShiftStart
            // 
            lblShiftStart.AutoSize = true;
            lblShiftStart.Location = new Point(471, 34);
            lblShiftStart.Name = "lblShiftStart";
            lblShiftStart.Size = new Size(73, 20);
            lblShiftStart.TabIndex = 3;
            lblShiftStart.Text = "shift start:";
            // 
            // lblCashierName
            // 
            lblCashierName.AutoSize = true;
            lblCashierName.Location = new Point(90, 34);
            lblCashierName.Name = "lblCashierName";
            lblCashierName.Size = new Size(57, 20);
            lblCashierName.TabIndex = 1;
            lblCashierName.Text = "Cashier";
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // txtBarcodeInput
            // 
            txtBarcodeInput.Location = new Point(748, 135);
            txtBarcodeInput.Name = "txtBarcodeInput";
            txtBarcodeInput.Size = new Size(226, 27);
            txtBarcodeInput.TabIndex = 7;
            txtBarcodeInput.KeyDown += txtBarcodeInput_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1019, 135);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "المنتج";
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeight = 29;
            dgvCart.Location = new Point(21, 115);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(693, 326);
            dgvCart.TabIndex = 6;
            dgvCart.CellClick += dgvCart_CellClick;
            dgvCart.CellEndEdit += dgvCart_CellEndEdit;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(841, 200);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1019, 200);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "الاجمالي";
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 530);
            Controls.Add(label3);
            Controls.Add(lblTotal);
            Controls.Add(dgvCart);
            Controls.Add(label1);
            Controls.Add(txtBarcodeInput);
            Controls.Add(panel1);
            Name = "CashierForm";
            Text = "CashierForm";
            Load += CashierForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private Label lblCurrentTime;
        private Label lblShiftStart;
        private Label lblCashierName;
        private System.Windows.Forms.Timer timerClock;
        private TextBox txtBarcodeInput;
        private Label label1;
        private DataGridView dgvCart;
        private Label lblTotal;
        private Label label3;
    }
}