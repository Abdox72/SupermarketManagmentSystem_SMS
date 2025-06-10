namespace SupermarketManagmentSystem_SMS
{
    partial class DoxForm
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
            ContentPanel = new Panel();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.AutoSize = true;
            ContentPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(0, 0);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1335, 904);
            ContentPanel.TabIndex = 0;
            // 
            // DoxForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1335, 904);
            Controls.Add(ContentPanel);
            DoubleBuffered = true;
            Name = "DoxForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "DoxForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ContentPanel;
    }
}