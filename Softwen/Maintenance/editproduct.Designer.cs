namespace Softwen.Products
{
    partial class modifyproduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifyproduct));
            this.lnksave = new MetroFramework.Controls.MetroLink();
            this.lnkclear = new MetroFramework.Controls.MetroLink();
            this.panelproduct = new System.Windows.Forms.Panel();
            this.txtbarcode = new MetroFramework.Controls.MetroTextBox();
            this.txtproductname = new MetroFramework.Controls.MetroTextBox();
            this.labelbarcode = new System.Windows.Forms.Label();
            this.txtprice = new MetroFramework.Controls.MetroTextBox();
            this.labelprice = new System.Windows.Forms.Label();
            this.labelproductname = new System.Windows.Forms.Label();
            this.panelproduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnksave
            // 
            this.lnksave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnksave.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnksave.Image = ((System.Drawing.Image)(resources.GetObject("lnksave.Image")));
            this.lnksave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnksave.ImageSize = 50;
            this.lnksave.Location = new System.Drawing.Point(321, 265);
            this.lnksave.Name = "lnksave";
            this.lnksave.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnksave.NoFocusImage")));
            this.lnksave.Size = new System.Drawing.Size(57, 66);
            this.lnksave.TabIndex = 8;
            this.lnksave.Text = "Save";
            this.lnksave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnksave.UseSelectable = true;
            this.lnksave.Click += new System.EventHandler(this.lnksave_Click);
            // 
            // lnkclear
            // 
            this.lnkclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkclear.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkclear.Image = ((System.Drawing.Image)(resources.GetObject("lnkclear.Image")));
            this.lnkclear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkclear.ImageSize = 50;
            this.lnkclear.Location = new System.Drawing.Point(247, 265);
            this.lnkclear.Name = "lnkclear";
            this.lnkclear.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkclear.NoFocusImage")));
            this.lnkclear.Size = new System.Drawing.Size(68, 66);
            this.lnkclear.TabIndex = 7;
            this.lnkclear.Text = "Clear All";
            this.lnkclear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkclear.UseSelectable = true;
            this.lnkclear.Click += new System.EventHandler(this.lnkclear_Click);
            // 
            // panelproduct
            // 
            this.panelproduct.Controls.Add(this.txtbarcode);
            this.panelproduct.Controls.Add(this.txtproductname);
            this.panelproduct.Controls.Add(this.labelbarcode);
            this.panelproduct.Controls.Add(this.txtprice);
            this.panelproduct.Controls.Add(this.labelprice);
            this.panelproduct.Controls.Add(this.labelproductname);
            this.panelproduct.Location = new System.Drawing.Point(13, 78);
            this.panelproduct.Name = "panelproduct";
            this.panelproduct.Size = new System.Drawing.Size(365, 167);
            this.panelproduct.TabIndex = 9;
            // 
            // txtbarcode
            // 
            // 
            // 
            // 
            this.txtbarcode.CustomButton.Image = null;
            this.txtbarcode.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtbarcode.CustomButton.Name = "";
            this.txtbarcode.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtbarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbarcode.CustomButton.TabIndex = 1;
            this.txtbarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbarcode.CustomButton.UseSelectable = true;
            this.txtbarcode.CustomButton.Visible = false;
            this.txtbarcode.DisplayIcon = true;
            this.txtbarcode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtbarcode.Icon = global::Softwen.Resource.Barcode_30px;
            this.txtbarcode.Lines = new string[0];
            this.txtbarcode.Location = new System.Drawing.Point(137, 126);
            this.txtbarcode.MaxLength = 32767;
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.PasswordChar = '\0';
            this.txtbarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbarcode.SelectedText = "";
            this.txtbarcode.SelectionLength = 0;
            this.txtbarcode.SelectionStart = 0;
            this.txtbarcode.ShortcutsEnabled = true;
            this.txtbarcode.ShowClearButton = true;
            this.txtbarcode.Size = new System.Drawing.Size(219, 37);
            this.txtbarcode.TabIndex = 4;
            this.txtbarcode.UseSelectable = true;
            this.txtbarcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbarcode.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtproductname.Location = new System.Drawing.Point(137, 12);
            this.txtproductname.MaxLength = 32767;
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.PasswordChar = '\0';
            this.txtproductname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtproductname.SelectedText = "";
            this.txtproductname.SelectionLength = 0;
            this.txtproductname.SelectionStart = 0;
            this.txtproductname.ShortcutsEnabled = true;
            this.txtproductname.ShowClearButton = true;
            this.txtproductname.Size = new System.Drawing.Size(219, 37);
            this.txtproductname.TabIndex = 1;
            this.txtproductname.UseSelectable = true;
            this.txtproductname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtproductname.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelbarcode
            // 
            this.labelbarcode.AutoSize = true;
            this.labelbarcode.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbarcode.Location = new System.Drawing.Point(57, 133);
            this.labelbarcode.Name = "labelbarcode";
            this.labelbarcode.Size = new System.Drawing.Size(78, 22);
            this.labelbarcode.TabIndex = 2;
            this.labelbarcode.Text = "Barcode:";
            // 
            // txtprice
            // 
            // 
            // 
            // 
            this.txtprice.CustomButton.Image = null;
            this.txtprice.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtprice.CustomButton.Name = "";
            this.txtprice.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtprice.CustomButton.TabIndex = 1;
            this.txtprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtprice.CustomButton.UseSelectable = true;
            this.txtprice.CustomButton.Visible = false;
            this.txtprice.DisplayIcon = true;
            this.txtprice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtprice.Icon = global::Softwen.Resource.US_Dollar_48px;
            this.txtprice.Lines = new string[0];
            this.txtprice.Location = new System.Drawing.Point(137, 71);
            this.txtprice.MaxLength = 32767;
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtprice.SelectedText = "";
            this.txtprice.SelectionLength = 0;
            this.txtprice.SelectionStart = 0;
            this.txtprice.ShortcutsEnabled = true;
            this.txtprice.ShowClearButton = true;
            this.txtprice.Size = new System.Drawing.Size(219, 37);
            this.txtprice.TabIndex = 2;
            this.txtprice.UseSelectable = true;
            this.txtprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtprice.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprice.Location = new System.Drawing.Point(83, 78);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(52, 22);
            this.labelprice.TabIndex = 2;
            this.labelprice.Text = "Price:";
            // 
            // labelproductname
            // 
            this.labelproductname.AutoSize = true;
            this.labelproductname.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductname.Location = new System.Drawing.Point(10, 19);
            this.labelproductname.Name = "labelproductname";
            this.labelproductname.Size = new System.Drawing.Size(125, 22);
            this.labelproductname.TabIndex = 2;
            this.labelproductname.Text = "Product Name:";
            // 
            // modifyproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 364);
            this.Controls.Add(this.panelproduct);
            this.Controls.Add(this.lnkclear);
            this.Controls.Add(this.lnksave);
            this.Name = "modifyproduct";
            this.Text = "Modify Product";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.panelproduct.ResumeLayout(false);
            this.panelproduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink lnksave;
        private MetroFramework.Controls.MetroLink lnkclear;
        public System.Windows.Forms.Panel panelproduct;
        public MetroFramework.Controls.MetroTextBox txtproductname;
        private System.Windows.Forms.Label labelbarcode;
        public MetroFramework.Controls.MetroTextBox txtprice;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Label labelproductname;
        public MetroFramework.Controls.MetroTextBox txtbarcode;
    }
}