namespace Softwen.Reports
{
    partial class dailyreport
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
            this.crystaldaily = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnexportexcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystaldaily
            // 
            this.crystaldaily.ActiveViewIndex = -1;
            this.crystaldaily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystaldaily.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystaldaily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystaldaily.Location = new System.Drawing.Point(20, 60);
            this.crystaldaily.Name = "crystaldaily";
            this.crystaldaily.Size = new System.Drawing.Size(823, 405);
            this.crystaldaily.TabIndex = 0;
            // 
            // btnexportexcel
            // 
            this.btnexportexcel.Location = new System.Drawing.Point(497, 63);
            this.btnexportexcel.Name = "btnexportexcel";
            this.btnexportexcel.Size = new System.Drawing.Size(91, 23);
            this.btnexportexcel.TabIndex = 1;
            this.btnexportexcel.Text = "Export to Excel";
            this.btnexportexcel.UseVisualStyleBackColor = true;
            this.btnexportexcel.Click += new System.EventHandler(this.btnexportexcel_Click);
            // 
            // dailyreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 485);
            this.Controls.Add(this.btnexportexcel);
            this.Controls.Add(this.crystaldaily);
            this.Name = "dailyreport";
            this.Text = "Daily Report";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dailyreport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystaldaily;
        private System.Windows.Forms.Button btnexportexcel;
    }
}