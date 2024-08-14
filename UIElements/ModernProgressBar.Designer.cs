namespace NukUX_ModernUI
{
    partial class ModernProgressBar
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel progressBarPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.progressBarPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // progressBarPanel
            // 
            this.progressBarPanel.BackColor = System.Drawing.Color.Blue;
            this.progressBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBarPanel.Location = new System.Drawing.Point(0, 0);
            this.progressBarPanel.Name = "progressBarPanel";
            this.progressBarPanel.Size = new System.Drawing.Size(0, 30);
            this.progressBarPanel.TabIndex = 0;
            // 
            // ModernProgressBar
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.progressBarPanel);
            this.Name = "ModernProgressBar";
            this.Size = new System.Drawing.Size(300, 30);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label progressLabel;
    }
}
