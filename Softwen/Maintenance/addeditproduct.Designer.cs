namespace Softwen.Maintenance
{
    partial class addeditproduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addeditproduct));
            this.labelproductname = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.labelbarcode = new System.Windows.Forms.Label();
            this.lnkclear = new MetroFramework.Controls.MetroLink();
            this.lnksave = new MetroFramework.Controls.MetroLink();
            this.txtbarcode = new MetroFramework.Controls.MetroTextBox();
            this.txtproductname = new MetroFramework.Controls.MetroTextBox();
            this.panelproduct = new System.Windows.Forms.Panel();
            this.txtmaxquantity = new System.Windows.Forms.NumericUpDown();
            this.combobxcat = new MetroFramework.Controls.MetroComboBox();
            this.txtdesc = new MetroFramework.Controls.MetroTextBox();
            this.lnkupdate = new MetroFramework.Controls.MetroLink();
            this.labelpcode = new System.Windows.Forms.Label();
            this.labeldesc = new System.Windows.Forms.Label();
            this.txtproductcode = new MetroFramework.Controls.MetroTextBox();
            this.txtprice = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelproduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaxquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelproductname
            // 
            this.labelproductname.AutoSize = true;
            this.labelproductname.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductname.Location = new System.Drawing.Point(10, 8);
            this.labelproductname.Name = "labelproductname";
            this.labelproductname.Size = new System.Drawing.Size(121, 22);
            this.labelproductname.TabIndex = 2;
            this.labelproductname.Text = "Product Name";
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprice.Location = new System.Drawing.Point(10, 216);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(232, 22);
            this.labelprice.TabIndex = 2;
            this.labelprice.Text = "Unit Price (in Philippine Peso)";
            // 
            // labelbarcode
            // 
            this.labelbarcode.AutoSize = true;
            this.labelbarcode.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbarcode.Location = new System.Drawing.Point(257, 8);
            this.labelbarcode.Name = "labelbarcode";
            this.labelbarcode.Size = new System.Drawing.Size(74, 22);
            this.labelbarcode.TabIndex = 2;
            this.labelbarcode.Text = "Barcode";
            // 
            // lnkclear
            // 
            this.lnkclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkclear.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkclear.Image = ((System.Drawing.Image)(resources.GetObject("lnkclear.Image")));
            this.lnkclear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkclear.ImageSize = 50;
            this.lnkclear.Location = new System.Drawing.Point(263, 293);
            this.lnkclear.Name = "lnkclear";
            this.lnkclear.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkclear.NoFocusImage")));
            this.lnkclear.Size = new System.Drawing.Size(68, 66);
            this.lnkclear.TabIndex = 9;
            this.lnkclear.Text = "Clear All";
            this.lnkclear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkclear.UseSelectable = true;
            this.lnkclear.Click += new System.EventHandler(this.lnkclear_Click);
            // 
            // lnksave
            // 
            this.lnksave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnksave.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnksave.Image = ((System.Drawing.Image)(resources.GetObject("lnksave.Image")));
            this.lnksave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnksave.ImageSize = 50;
            this.lnksave.Location = new System.Drawing.Point(432, 293);
            this.lnksave.Name = "lnksave";
            this.lnksave.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnksave.NoFocusImage")));
            this.lnksave.Size = new System.Drawing.Size(48, 66);
            this.lnksave.TabIndex = 7;
            this.lnksave.Text = "Save";
            this.lnksave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnksave.UseSelectable = true;
            this.lnksave.Click += new System.EventHandler(this.lnksave_Click);
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
            this.txtbarcode.Location = new System.Drawing.Point(261, 33);
            this.txtbarcode.MaxLength = 15;
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.PasswordChar = '\0';
            this.txtbarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbarcode.SelectedText = "";
            this.txtbarcode.SelectionLength = 0;
            this.txtbarcode.SelectionStart = 0;
            this.txtbarcode.ShortcutsEnabled = false;
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
            this.txtproductname.Location = new System.Drawing.Point(14, 33);
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
            this.txtproductname.TabIndex = 0;
            this.txtproductname.UseSelectable = true;
            this.txtproductname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtproductname.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelproduct
            // 
            this.panelproduct.Controls.Add(this.txtmaxquantity);
            this.panelproduct.Controls.Add(this.combobxcat);
            this.panelproduct.Controls.Add(this.lnkclear);
            this.panelproduct.Controls.Add(this.txtdesc);
            this.panelproduct.Controls.Add(this.lnkupdate);
            this.panelproduct.Controls.Add(this.lnksave);
            this.panelproduct.Controls.Add(this.labelpcode);
            this.panelproduct.Controls.Add(this.txtbarcode);
            this.panelproduct.Controls.Add(this.labeldesc);
            this.panelproduct.Controls.Add(this.txtproductcode);
            this.panelproduct.Controls.Add(this.txtproductname);
            this.panelproduct.Controls.Add(this.labelbarcode);
            this.panelproduct.Controls.Add(this.txtprice);
            this.panelproduct.Controls.Add(this.label3);
            this.panelproduct.Controls.Add(this.label1);
            this.panelproduct.Controls.Add(this.labelprice);
            this.panelproduct.Controls.Add(this.labelproductname);
            this.panelproduct.Location = new System.Drawing.Point(10, 49);
            this.panelproduct.Name = "panelproduct";
            this.panelproduct.Size = new System.Drawing.Size(497, 364);
            this.panelproduct.TabIndex = 6;
            // 
            // txtmaxquantity
            // 
            this.txtmaxquantity.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaxquantity.Location = new System.Drawing.Point(261, 249);
            this.txtmaxquantity.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.txtmaxquantity.Name = "txtmaxquantity";
            this.txtmaxquantity.Size = new System.Drawing.Size(110, 29);
            this.txtmaxquantity.TabIndex = 6;
            this.txtmaxquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmaxquantity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // combobxcat
            // 
            this.combobxcat.FormattingEnabled = true;
            this.combobxcat.ItemHeight = 23;
            this.combobxcat.Location = new System.Drawing.Point(14, 112);
            this.combobxcat.Name = "combobxcat";
            this.combobxcat.Size = new System.Drawing.Size(219, 29);
            this.combobxcat.TabIndex = 1;
            this.combobxcat.UseSelectable = true;
            // 
            // txtdesc
            // 
            // 
            // 
            // 
            this.txtdesc.CustomButton.Image = null;
            this.txtdesc.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtdesc.CustomButton.Name = "";
            this.txtdesc.CustomButton.Size = new System.Drawing.Size(101, 101);
            this.txtdesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdesc.CustomButton.TabIndex = 1;
            this.txtdesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdesc.CustomButton.UseSelectable = true;
            this.txtdesc.CustomButton.Visible = false;
            this.txtdesc.DisplayIcon = true;
            this.txtdesc.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtdesc.Icon = ((System.Drawing.Image)(resources.GetObject("txtdesc.Icon")));
            this.txtdesc.Lines = new string[0];
            this.txtdesc.Location = new System.Drawing.Point(261, 107);
            this.txtdesc.MaxLength = 32767;
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.PasswordChar = '\0';
            this.txtdesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdesc.SelectedText = "";
            this.txtdesc.SelectionLength = 0;
            this.txtdesc.SelectionStart = 0;
            this.txtdesc.ShortcutsEnabled = true;
            this.txtdesc.ShowClearButton = true;
            this.txtdesc.Size = new System.Drawing.Size(219, 103);
            this.txtdesc.TabIndex = 5;
            this.txtdesc.UseSelectable = true;
            this.txtdesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdesc.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lnkupdate
            // 
            this.lnkupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkupdate.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkupdate.Image = ((System.Drawing.Image)(resources.GetObject("lnkupdate.Image")));
            this.lnkupdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkupdate.ImageSize = 50;
            this.lnkupdate.Location = new System.Drawing.Point(350, 293);
            this.lnkupdate.Name = "lnkupdate";
            this.lnkupdate.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkupdate.NoFocusImage")));
            this.lnkupdate.Size = new System.Drawing.Size(58, 66);
            this.lnkupdate.TabIndex = 8;
            this.lnkupdate.Text = "Update";
            this.lnkupdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkupdate.UseSelectable = true;
            this.lnkupdate.Click += new System.EventHandler(this.lnkupdate_Click);
            // 
            // labelpcode
            // 
            this.labelpcode.AutoSize = true;
            this.labelpcode.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpcode.Location = new System.Drawing.Point(10, 148);
            this.labelpcode.Name = "labelpcode";
            this.labelpcode.Size = new System.Drawing.Size(114, 22);
            this.labelpcode.TabIndex = 2;
            this.labelpcode.Text = "Product Code";
            // 
            // labeldesc
            // 
            this.labeldesc.AutoSize = true;
            this.labeldesc.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldesc.Location = new System.Drawing.Point(257, 82);
            this.labeldesc.Name = "labeldesc";
            this.labeldesc.Size = new System.Drawing.Size(98, 22);
            this.labeldesc.TabIndex = 2;
            this.labeldesc.Text = "Description";
            // 
            // txtproductcode
            // 
            // 
            // 
            // 
            this.txtproductcode.CustomButton.Image = null;
            this.txtproductcode.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtproductcode.CustomButton.Name = "";
            this.txtproductcode.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtproductcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtproductcode.CustomButton.TabIndex = 1;
            this.txtproductcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtproductcode.CustomButton.UseSelectable = true;
            this.txtproductcode.CustomButton.Visible = false;
            this.txtproductcode.DisplayIcon = true;
            this.txtproductcode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtproductcode.Icon = ((System.Drawing.Image)(resources.GetObject("txtproductcode.Icon")));
            this.txtproductcode.Lines = new string[0];
            this.txtproductcode.Location = new System.Drawing.Point(14, 173);
            this.txtproductcode.MaxLength = 32767;
            this.txtproductcode.Name = "txtproductcode";
            this.txtproductcode.PasswordChar = '\0';
            this.txtproductcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtproductcode.SelectedText = "";
            this.txtproductcode.SelectionLength = 0;
            this.txtproductcode.SelectionStart = 0;
            this.txtproductcode.ShortcutsEnabled = false;
            this.txtproductcode.ShowClearButton = true;
            this.txtproductcode.Size = new System.Drawing.Size(219, 37);
            this.txtproductcode.TabIndex = 2;
            this.txtproductcode.UseSelectable = true;
            this.txtproductcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtproductcode.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtprice.Icon = ((System.Drawing.Image)(resources.GetObject("txtprice.Icon")));
            this.txtprice.Lines = new string[0];
            this.txtprice.Location = new System.Drawing.Point(14, 241);
            this.txtprice.MaxLength = 3;
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtprice.SelectedText = "";
            this.txtprice.SelectionLength = 0;
            this.txtprice.SelectionStart = 0;
            this.txtprice.ShortcutsEnabled = false;
            this.txtprice.ShowClearButton = true;
            this.txtprice.Size = new System.Drawing.Size(219, 37);
            this.txtprice.TabIndex = 3;
            this.txtprice.UseSelectable = true;
            this.txtprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtprice.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max Quantity (Max: 900)";
            // 
            // addeditproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 420);
            this.Controls.Add(this.panelproduct);
            this.MaximizeBox = false;
            this.Name = "addeditproduct";
            this.Resizable = false;
            this.Text = "New Product";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.addeditproduct_Load);
            this.panelproduct.ResumeLayout(false);
            this.panelproduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmaxquantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelproductname;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Label labelbarcode;
        private MetroFramework.Controls.MetroLink lnkclear;
        public MetroFramework.Controls.MetroTextBox txtproductname;
        public MetroFramework.Controls.MetroTextBox txtbarcode;
        public System.Windows.Forms.Panel panelproduct;
        public MetroFramework.Controls.MetroTextBox txtprice;
        public MetroFramework.Controls.MetroTextBox txtdesc;
        private System.Windows.Forms.Label labeldesc;
        private System.Windows.Forms.Label label3;
        public MetroFramework.Controls.MetroLink lnksave;
        public MetroFramework.Controls.MetroLink lnkupdate;
        public MetroFramework.Controls.MetroComboBox combobxcat;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown txtmaxquantity;
        private System.Windows.Forms.Label labelpcode;
        public MetroFramework.Controls.MetroTextBox txtproductcode;
    }
}