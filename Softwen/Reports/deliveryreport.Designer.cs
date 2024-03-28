namespace Softwen.Reports
{
    partial class stockreport
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
            this.crystalstocks = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalstocks
            // 
            this.crystalstocks.ActiveViewIndex = -1;
            this.crystalstocks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalstocks.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalstocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalstocks.Location = new System.Drawing.Point(20, 60);
            this.crystalstocks.Name = "crystalstocks";
            this.crystalstocks.Size = new System.Drawing.Size(260, 220);
            this.crystalstocks.TabIndex = 0;
            // 
            // stockreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.crystalstocks);
            this.Name = "stockreport";
            this.Text = "Stocks In Report";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.stockreport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalstocks;
    }
}