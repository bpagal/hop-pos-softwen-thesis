namespace Softwen.Maintenance
{
    partial class addedituser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addedituser));
            this.paneluser = new System.Windows.Forms.Panel();
            this.combobxut = new MetroFramework.Controls.MetroComboBox();
            this.lnkclear = new MetroFramework.Controls.MetroLink();
            this.txtlname = new MetroFramework.Controls.MetroTextBox();
            this.lnkupdate = new MetroFramework.Controls.MetroLink();
            this.lnksave = new MetroFramework.Controls.MetroLink();
            this.txtuname = new MetroFramework.Controls.MetroTextBox();
            this.labeldesc = new System.Windows.Forms.Label();
            this.txtfname = new MetroFramework.Controls.MetroTextBox();
            this.labelbarcode = new System.Windows.Forms.Label();
            this.txtpass = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.labelproductname = new System.Windows.Forms.Label();
            this.paneluser.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneluser
            // 
            this.paneluser.Controls.Add(this.combobxut);
            this.paneluser.Controls.Add(this.lnkclear);
            this.paneluser.Controls.Add(this.txtlname);
            this.paneluser.Controls.Add(this.lnkupdate);
            this.paneluser.Controls.Add(this.lnksave);
            this.paneluser.Controls.Add(this.txtuname);
            this.paneluser.Controls.Add(this.labeldesc);
            this.paneluser.Controls.Add(this.txtfname);
            this.paneluser.Controls.Add(this.labelbarcode);
            this.paneluser.Controls.Add(this.txtpass);
            this.paneluser.Controls.Add(this.label3);
            this.paneluser.Controls.Add(this.labelprice);
            this.paneluser.Controls.Add(this.labelproductname);
            this.paneluser.Location = new System.Drawing.Point(18, 63);
            this.paneluser.Name = "paneluser";
            this.paneluser.Size = new System.Drawing.Size(490, 250);
            this.paneluser.TabIndex = 7;
            // 
            // combobxut
            // 
            this.combobxut.FormattingEnabled = true;
            this.combobxut.ItemHeight = 23;
            this.combobxut.Items.AddRange(new object[] {
            "Cashier",
            "Manager",
            "Supervisor",
            "Admin"});
            this.combobxut.Location = new System.Drawing.Point(14, 190);
            this.combobxut.Name = "combobxut";
            this.combobxut.Size = new System.Drawing.Size(219, 29);
            this.combobxut.TabIndex = 2;
            this.combobxut.UseSelectable = true;
            this.combobxut.SelectedIndexChanged += new System.EventHandler(this.combobxut_SelectedIndexChanged);
            // 
            // lnkclear
            // 
            this.lnkclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkclear.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkclear.Image = ((System.Drawing.Image)(resources.GetObject("lnkclear.Image")));
            this.lnkclear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkclear.ImageSize = 50;
            this.lnkclear.Location = new System.Drawing.Point(290, 171);
            this.lnkclear.Name = "lnkclear";
            this.lnkclear.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkclear.NoFocusImage")));
            this.lnkclear.Size = new System.Drawing.Size(68, 66);
            this.lnkclear.TabIndex = 7;
            this.lnkclear.Text = "Clear All";
            this.lnkclear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkclear.UseSelectable = true;
            this.lnkclear.Click += new System.EventHandler(this.lnkclear_Click);
            // 
            // txtlname
            // 
            // 
            // 
            // 
            this.txtlname.CustomButton.Image = null;
            this.txtlname.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtlname.CustomButton.Name = "";
            this.txtlname.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtlname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtlname.CustomButton.TabIndex = 1;
            this.txtlname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtlname.CustomButton.UseSelectable = true;
            this.txtlname.CustomButton.Visible = false;
            this.txtlname.DisplayIcon = true;
            this.txtlname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtlname.Icon = ((System.Drawing.Image)(resources.GetObject("txtlname.Icon")));
            this.txtlname.Lines = new string[0];
            this.txtlname.Location = new System.Drawing.Point(14, 124);
            this.txtlname.MaxLength = 32767;
            this.txtlname.Name = "txtlname";
            this.txtlname.PasswordChar = '\0';
            this.txtlname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtlname.SelectedText = "";
            this.txtlname.SelectionLength = 0;
            this.txtlname.SelectionStart = 0;
            this.txtlname.ShortcutsEnabled = false;
            this.txtlname.ShowClearButton = true;
            this.txtlname.Size = new System.Drawing.Size(219, 37);
            this.txtlname.TabIndex = 1;
            this.txtlname.UseSelectable = true;
            this.txtlname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtlname.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lnkupdate
            // 
            this.lnkupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkupdate.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkupdate.Image = ((System.Drawing.Image)(resources.GetObject("lnkupdate.Image")));
            this.lnkupdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkupdate.ImageSize = 50;
            this.lnkupdate.Location = new System.Drawing.Point(364, 171);
            this.lnkupdate.Name = "lnkupdate";
            this.lnkupdate.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkupdate.NoFocusImage")));
            this.lnkupdate.Size = new System.Drawing.Size(62, 66);
            this.lnkupdate.TabIndex = 6;
            this.lnkupdate.Text = "Update";
            this.lnkupdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkupdate.UseSelectable = true;
            this.lnkupdate.Click += new System.EventHandler(this.lnkupdate_Click);
            // 
            // lnksave
            // 
            this.lnksave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnksave.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnksave.Image = ((System.Drawing.Image)(resources.GetObject("lnksave.Image")));
            this.lnksave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnksave.ImageSize = 50;
            this.lnksave.Location = new System.Drawing.Point(432, 171);
            this.lnksave.Name = "lnksave";
            this.lnksave.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnksave.NoFocusImage")));
            this.lnksave.Size = new System.Drawing.Size(48, 66);
            this.lnksave.TabIndex = 5;
            this.lnksave.Text = "Save";
            this.lnksave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnksave.UseSelectable = true;
            this.lnksave.Click += new System.EventHandler(this.lnksave_Click);
            // 
            // txtuname
            // 
            // 
            // 
            // 
            this.txtuname.CustomButton.Image = null;
            this.txtuname.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtuname.CustomButton.Name = "";
            this.txtuname.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtuname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtuname.CustomButton.TabIndex = 1;
            this.txtuname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtuname.CustomButton.UseSelectable = true;
            this.txtuname.CustomButton.Visible = false;
            this.txtuname.DisplayIcon = true;
            this.txtuname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtuname.Icon = ((System.Drawing.Image)(resources.GetObject("txtuname.Icon")));
            this.txtuname.Lines = new string[0];
            this.txtuname.Location = new System.Drawing.Point(261, 50);
            this.txtuname.MaxLength = 32767;
            this.txtuname.Name = "txtuname";
            this.txtuname.PasswordChar = '\0';
            this.txtuname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtuname.SelectedText = "";
            this.txtuname.SelectionLength = 0;
            this.txtuname.SelectionStart = 0;
            this.txtuname.ShortcutsEnabled = true;
            this.txtuname.ShowClearButton = true;
            this.txtuname.Size = new System.Drawing.Size(219, 37);
            this.txtuname.TabIndex = 3;
            this.txtuname.UseSelectable = true;
            this.txtuname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtuname.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labeldesc
            // 
            this.labeldesc.AutoSize = true;
            this.labeldesc.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldesc.Location = new System.Drawing.Point(257, 99);
            this.labeldesc.Name = "labeldesc";
            this.labeldesc.Size = new System.Drawing.Size(85, 22);
            this.labeldesc.TabIndex = 2;
            this.labeldesc.Text = "Password";
            // 
            // txtfname
            // 
            // 
            // 
            // 
            this.txtfname.CustomButton.Image = null;
            this.txtfname.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtfname.CustomButton.Name = "";
            this.txtfname.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtfname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtfname.CustomButton.TabIndex = 1;
            this.txtfname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtfname.CustomButton.UseSelectable = true;
            this.txtfname.CustomButton.Visible = false;
            this.txtfname.DisplayIcon = true;
            this.txtfname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtfname.Icon = ((System.Drawing.Image)(resources.GetObject("txtfname.Icon")));
            this.txtfname.Lines = new string[0];
            this.txtfname.Location = new System.Drawing.Point(14, 50);
            this.txtfname.MaxLength = 32767;
            this.txtfname.Name = "txtfname";
            this.txtfname.PasswordChar = '\0';
            this.txtfname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfname.SelectedText = "";
            this.txtfname.SelectionLength = 0;
            this.txtfname.SelectionStart = 0;
            this.txtfname.ShortcutsEnabled = false;
            this.txtfname.ShowClearButton = true;
            this.txtfname.Size = new System.Drawing.Size(219, 37);
            this.txtfname.TabIndex = 0;
            this.txtfname.UseSelectable = true;
            this.txtfname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtfname.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelbarcode
            // 
            this.labelbarcode.AutoSize = true;
            this.labelbarcode.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbarcode.Location = new System.Drawing.Point(257, 25);
            this.labelbarcode.Name = "labelbarcode";
            this.labelbarcode.Size = new System.Drawing.Size(89, 22);
            this.labelbarcode.TabIndex = 2;
            this.labelbarcode.Text = "Username";
            // 
            // txtpass
            // 
            // 
            // 
            // 
            this.txtpass.CustomButton.Image = null;
            this.txtpass.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtpass.CustomButton.Name = "";
            this.txtpass.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpass.CustomButton.TabIndex = 1;
            this.txtpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpass.CustomButton.UseSelectable = true;
            this.txtpass.CustomButton.Visible = false;
            this.txtpass.DisplayIcon = true;
            this.txtpass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtpass.Icon = ((System.Drawing.Image)(resources.GetObject("txtpass.Icon")));
            this.txtpass.Lines = new string[0];
            this.txtpass.Location = new System.Drawing.Point(261, 124);
            this.txtpass.MaxLength = 32767;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '•';
            this.txtpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.ShortcutsEnabled = true;
            this.txtpass.ShowClearButton = true;
            this.txtpass.Size = new System.Drawing.Size(219, 37);
            this.txtpass.TabIndex = 4;
            this.txtpass.UseSelectable = true;
            this.txtpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpass.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprice.Location = new System.Drawing.Point(10, 165);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(87, 22);
            this.labelprice.TabIndex = 2;
            this.labelprice.Text = "User Type";
            // 
            // labelproductname
            // 
            this.labelproductname.AutoSize = true;
            this.labelproductname.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductname.Location = new System.Drawing.Point(10, 25);
            this.labelproductname.Name = "labelproductname";
            this.labelproductname.Size = new System.Drawing.Size(94, 22);
            this.labelproductname.TabIndex = 2;
            this.labelproductname.Text = "First Name";
            // 
            // addedituser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 323);
            this.Controls.Add(this.paneluser);
            this.MaximizeBox = false;
            this.Name = "addedituser";
            this.Resizable = false;
            this.Text = "New User";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.addedituser_Load);
            this.paneluser.ResumeLayout(false);
            this.paneluser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel paneluser;
        public MetroFramework.Controls.MetroComboBox combobxut;
        private MetroFramework.Controls.MetroLink lnkclear;
        public MetroFramework.Controls.MetroTextBox txtlname;
        public MetroFramework.Controls.MetroLink lnkupdate;
        public MetroFramework.Controls.MetroLink lnksave;
        public MetroFramework.Controls.MetroTextBox txtuname;
        private System.Windows.Forms.Label labeldesc;
        public MetroFramework.Controls.MetroTextBox txtfname;
        private System.Windows.Forms.Label labelbarcode;
        public MetroFramework.Controls.MetroTextBox txtpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Label labelproductname;
    }
}