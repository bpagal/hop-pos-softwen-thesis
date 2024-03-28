namespace Softwen.Products
{
    partial class rptmissing
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
            this.crystalmissing = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalmissing
            // 
            this.crystalmissing.ActiveViewIndex = -1;
            this.crystalmissing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalmissing.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalmissing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalmissing.Location = new System.Drawing.Point(20, 60);
            this.crystalmissing.Name = "crystalmissing";
            this.crystalmissing.Size = new System.Drawing.Size(260, 220);
            this.crystalmissing.TabIndex = 0;
            // 
            // rptmissing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.crystalmissing);
            this.Name = "rptmissing";
            this.Text = "rptmissing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptmissing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalmissing;
    }
}