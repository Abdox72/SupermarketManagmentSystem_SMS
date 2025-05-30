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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            ContentPanel = new Panel();
            TobBarPanel = new Panel();
            SidebarPanel = new Panel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(ContentPanel, 1, 1);
            tableLayoutPanel1.Controls.Add(TobBarPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(SidebarPanel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(988, 506);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ContentPanel
            // 
            ContentPanel.BackColor = Color.DarkGoldenrod;
            ContentPanel.BackgroundImage = Properties.Resources.tot;
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(3, 63);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(832, 440);
            ContentPanel.TabIndex = 0;
            // 
            // TobBarPanel
            // 
            TobBarPanel.BackColor = Color.DarkCyan;
            TobBarPanel.BackgroundImage = (Image)resources.GetObject("TobBarPanel.BackgroundImage");
            TobBarPanel.Dock = DockStyle.Fill;
            TobBarPanel.Location = new Point(3, 3);
            TobBarPanel.Name = "TobBarPanel";
            TobBarPanel.Size = new Size(832, 54);
            TobBarPanel.TabIndex = 1;
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.DarkGreen;
            SidebarPanel.BackgroundImage = (Image)resources.GetObject("SidebarPanel.BackgroundImage");
            SidebarPanel.Dock = DockStyle.Fill;
            SidebarPanel.Location = new Point(841, 63);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(144, 440);
            SidebarPanel.TabIndex = 2;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(988, 506);
            Controls.Add(tableLayoutPanel1);
            Name = "AdminDashboardForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel ContentPanel;
        private Panel TobBarPanel;
        private Panel SidebarPanel;
    }
}