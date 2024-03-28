namespace Softwen.Products
{
    partial class addstocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addstocks));
            this.labelproductname = new System.Windows.Forms.Label();
            this.txtproductname = new MetroFramework.Controls.MetroTextBox();
            this.txtquantity = new System.Windows.Forms.NumericUpDown();
            this.labelquantity = new System.Windows.Forms.Label();
            this.lnksave = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelproductname
            // 
            this.labelproductname.AutoSize = true;
            this.labelproductname.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductname.Location = new System.Drawing.Point(22, 87);
            this.labelproductname.Name = "labelproductname";
            this.labelproductname.Size = new System.Drawing.Size(125, 22);
            this.labelproductname.TabIndex = 6;
            this.labelproductname.Text = "Product Name:";
            // 
            // txtproductname
            // 
            // 
            // 
            // 
            this.txtproductname.CustomButton.Image = null;
            this.txtproductname.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtproductname.CustomButton.Name = "";
            this.txtproductname.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtproductname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtproductname.CustomButton.TabIndex = 1;
            this.txtproductname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtproductname.CustomButton.UseSelectable = true;
            this.txtproductname.CustomButton.Visible = false;
            this.txtproductname.DisplayIcon = true;
            this.txtproductname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtproductname.Icon = ((System.Drawing.Image)(resources.GetObject("txtproductname.Icon")));
            this.txtproductname.Lines = new string[0];
            this.txtproductname.Location = new System.Drawing.Point(149, 80);
            this.txtproductname.MaxLength = 32767;
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.PasswordChar = '\0';
            this.txtproductname.ReadOnly = true;
            this.txtproductname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtproductname.SelectedText = "";
            this.txtproductname.SelectionLength = 0;
            this.txtproductname.SelectionStart = 0;
            this.txtproductname.ShortcutsEnabled = true;
            this.txtproductname.ShowClearButton = true;
            this.txtproductname.Size = new System.Drawing.Size(219, 37);
            this.txtproductname.TabIndex = 2;
            this.txtproductname.UseSelectable = true;
            this.txtproductname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtproductname.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(149, 133);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(104, 29);
            this.txtquantity.TabIndex = 0;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelquantity
            // 
            this.labelquantity.AutoSize = true;
            this.labelquantity.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelquantity.Location = new System.Drawing.Point(66, 140);
            this.labelquantity.Name = "labelquantity";
            this.labelquantity.Size = new System.Drawing.Size(81, 22);
            this.labelquantity.TabIndex = 12;
            this.labelquantity.Text = "Quantity:";
            // 
            // lnksave
            // 
            this.lnksave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnksave.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnksave.Image = ((System.Drawing.Image)(resources.GetObject("lnksave.Image")));
            this.lnksave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnksave.ImageSize = 50;
            this.lnksave.Location = new System.Drawing.Point(311, 171);
            this.lnksave.Name = "lnksave";
            this.lnksave.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnksave.NoFocusImage")));
            this.lnksave.Size = new System.Drawing.Size(57, 66);
            this.lnksave.TabIndex = 1;
            this.lnksave.Text = "Save";
            this.lnksave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnksave.UseSelectable = true;
            this.lnksave.Click += new System.EventHandler(this.lnksave_Click);
            // 
            // addstocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 245);
            this.Controls.Add(this.lnksave);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.labelquantity);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.labelproductname);
            this.Name = "addstocks";
            this.Text = "Add Stocks";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroTextBox txtproductname;
        private System.Windows.Forms.Label labelproductname;
        private System.Windows.Forms.Label labelquantity;
        private MetroFramework.Controls.MetroLink lnksave;
        public System.Windows.Forms.NumericUpDown txtquantity;
    }
}