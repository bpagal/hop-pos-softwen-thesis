namespace Softwen.Products
{
    partial class rptbo
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
            this.crystalbo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalbo
            // 
            this.crystalbo.ActiveViewIndex = -1;
            this.crystalbo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalbo.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalbo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalbo.Location = new System.Drawing.Point(20, 60);
            this.crystalbo.Name = "crystalbo";
            this.crystalbo.Size = new System.Drawing.Size(260, 220);
            this.crystalbo.TabIndex = 0;
            // 
            // rptbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.crystalbo);
            this.Name = "rptbo";
            this.Text = "Back Order";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptbo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalbo;
    }
}