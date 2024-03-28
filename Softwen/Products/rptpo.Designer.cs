namespace Softwen.Products
{
    partial class rptpo
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
            this.crystalpo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnexportexcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalpo
            // 
            this.crystalpo.ActiveViewIndex = -1;
            this.crystalpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalpo.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalpo.Location = new System.Drawing.Point(20, 60);
            this.crystalpo.Name = "crystalpo";
            this.crystalpo.Size = new System.Drawing.Size(832, 427);
            this.crystalpo.TabIndex = 0;
            // 
            // btnexportexcel
            // 
            this.btnexportexcel.Location = new System.Drawing.Point(493, 63);
            this.btnexportexcel.Name = "btnexportexcel";
            this.btnexportexcel.Size = new System.Drawing.Size(91, 23);
            this.btnexportexcel.TabIndex = 2;
            this.btnexportexcel.Text = "Export to Excel";
            this.btnexportexcel.UseVisualStyleBackColor = true;
            this.btnexportexcel.Click += new System.EventHandler(this.btnexportexcel_Click);
            // 
            // rptpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 507);
            this.Controls.Add(this.btnexportexcel);
            this.Controls.Add(this.crystalpo);
            this.Name = "rptpo";
            this.Text = "Purchase Order";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptpo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalpo;
        private System.Windows.Forms.Button btnexportexcel;
    }
}