namespace Softwen.Transaction
{
    partial class rptinvoice
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
            this.crystalinvoice = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalinvoice.ActiveViewIndex = -1;
            this.crystalinvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalinvoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalinvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalinvoice.Location = new System.Drawing.Point(20, 60);
            this.crystalinvoice.Name = "crystalReportViewer1";
            this.crystalinvoice.Size = new System.Drawing.Size(244, 181);
            this.crystalinvoice.TabIndex = 0;
            // 
            // rptinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.crystalinvoice);
            this.Name = "rptinvoice";
            this.Text = "Invoice";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptinvoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalinvoice;
    }
}