namespace Softwen.Products
{
    partial class missingproducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(missingproducts));
            this.lnksave = new MetroFramework.Controls.MetroLink();
            this.txtquantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lnksave
            // 
            this.lnksave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnksave.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnksave.Image = ((System.Drawing.Image)(resources.GetObject("lnksave.Image")));
            this.lnksave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnksave.ImageSize = 50;
            this.lnksave.Location = new System.Drawing.Point(155, 54);
            this.lnksave.Name = "lnksave";
            this.lnksave.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnksave.NoFocusImage")));
            this.lnksave.Size = new System.Drawing.Size(63, 66);
            this.lnksave.TabIndex = 23;
            this.lnksave.Text = "Confirm";
            this.lnksave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnksave.UseSelectable = true;
            this.lnksave.Click += new System.EventHandler(this.lnksave_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(34, 83);
            this.txtquantity.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(104, 29);
            this.txtquantity.TabIndex = 25;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quantity";
            // 
            // missingproducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 124);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnksave);
            this.MaximizeBox = false;
            this.Name = "missingproducts";
            this.Resizable = false;
            this.Text = "Missing Stocks";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLink lnksave;
        private System.Windows.Forms.NumericUpDown txtquantity;
        private System.Windows.Forms.Label label1;
    }
}