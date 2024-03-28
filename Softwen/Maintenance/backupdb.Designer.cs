namespace Softwen.Maintenance
{
    partial class backupdb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backupdb));
            this.labelbarcode = new System.Windows.Forms.Label();
            this.txtserver = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdatabase = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.lblpercent = new System.Windows.Forms.Label();
            this.lnkbackup = new MetroFramework.Controls.MetroLink();
            this.txtusername = new MetroFramework.Controls.MetroTextBox();
            this.txtpassword = new MetroFramework.Controls.MetroTextBox();
            this.lnkrestore = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // labelbarcode
            // 
            this.labelbarcode.AutoSize = true;
            this.labelbarcode.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbarcode.Location = new System.Drawing.Point(22, 58);
            this.labelbarcode.Name = "labelbarcode";
            this.labelbarcode.Size = new System.Drawing.Size(60, 22);
            this.labelbarcode.TabIndex = 5;
            this.labelbarcode.Text = "Server";
            // 
            // txtserver
            // 
            // 
            // 
            // 
            this.txtserver.CustomButton.Image = null;
            this.txtserver.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtserver.CustomButton.Name = "";
            this.txtserver.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtserver.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtserver.CustomButton.TabIndex = 1;
            this.txtserver.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtserver.CustomButton.UseSelectable = true;
            this.txtserver.CustomButton.Visible = false;
            this.txtserver.DisplayIcon = true;
            this.txtserver.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtserver.Icon = ((System.Drawing.Image)(resources.GetObject("txtserver.Icon")));
            this.txtserver.Lines = new string[0];
            this.txtserver.Location = new System.Drawing.Point(26, 83);
            this.txtserver.MaxLength = 32767;
            this.txtserver.Name = "txtserver";
            this.txtserver.PasswordChar = '\0';
            this.txtserver.ReadOnly = true;
            this.txtserver.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtserver.SelectedText = "";
            this.txtserver.SelectionLength = 0;
            this.txtserver.SelectionStart = 0;
            this.txtserver.ShortcutsEnabled = true;
            this.txtserver.ShowClearButton = true;
            this.txtserver.Size = new System.Drawing.Size(219, 37);
            this.txtserver.TabIndex = 6;
            this.txtserver.UseSelectable = true;
            this.txtserver.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtserver.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Database";
            // 
            // txtdatabase
            // 
            // 
            // 
            // 
            this.txtdatabase.CustomButton.Image = null;
            this.txtdatabase.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtdatabase.CustomButton.Name = "";
            this.txtdatabase.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtdatabase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdatabase.CustomButton.TabIndex = 1;
            this.txtdatabase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdatabase.CustomButton.UseSelectable = true;
            this.txtdatabase.CustomButton.Visible = false;
            this.txtdatabase.DisplayIcon = true;
            this.txtdatabase.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtdatabase.Icon = ((System.Drawing.Image)(resources.GetObject("txtdatabase.Icon")));
            this.txtdatabase.Lines = new string[0];
            this.txtdatabase.Location = new System.Drawing.Point(26, 160);
            this.txtdatabase.MaxLength = 32767;
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.PasswordChar = '\0';
            this.txtdatabase.ReadOnly = true;
            this.txtdatabase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdatabase.SelectedText = "";
            this.txtdatabase.SelectionLength = 0;
            this.txtdatabase.SelectionStart = 0;
            this.txtdatabase.ShortcutsEnabled = true;
            this.txtdatabase.ShowClearButton = true;
            this.txtdatabase.Size = new System.Drawing.Size(219, 37);
            this.txtdatabase.TabIndex = 6;
            this.txtdatabase.UseSelectable = true;
            this.txtdatabase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdatabase.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(26, 213);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(462, 23);
            this.metroProgressBar1.TabIndex = 7;
            // 
            // lblpercent
            // 
            this.lblpercent.AutoSize = true;
            this.lblpercent.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpercent.Location = new System.Drawing.Point(238, 239);
            this.lblpercent.Name = "lblpercent";
            this.lblpercent.Size = new System.Drawing.Size(33, 22);
            this.lblpercent.TabIndex = 8;
            this.lblpercent.Text = "0%";
            // 
            // lnkbackup
            // 
            this.lnkbackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkbackup.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkbackup.Image = ((System.Drawing.Image)(resources.GetObject("lnkbackup.Image")));
            this.lnkbackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkbackup.ImageSize = 50;
            this.lnkbackup.Location = new System.Drawing.Point(426, 242);
            this.lnkbackup.Name = "lnkbackup";
            this.lnkbackup.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkbackup.NoFocusImage")));
            this.lnkbackup.Size = new System.Drawing.Size(62, 61);
            this.lnkbackup.TabIndex = 9;
            this.lnkbackup.Text = "Backup";
            this.lnkbackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkbackup.UseSelectable = true;
            this.lnkbackup.Click += new System.EventHandler(this.lnkbackup_Click);
            // 
            // txtusername
            // 
            // 
            // 
            // 
            this.txtusername.CustomButton.Image = null;
            this.txtusername.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtusername.CustomButton.Name = "";
            this.txtusername.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusername.CustomButton.TabIndex = 1;
            this.txtusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusername.CustomButton.UseSelectable = true;
            this.txtusername.CustomButton.Visible = false;
            this.txtusername.DisplayIcon = true;
            this.txtusername.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtusername.Icon = global::Softwen.Resource.User_40px;
            this.txtusername.Lines = new string[0];
            this.txtusername.Location = new System.Drawing.Point(269, 83);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.ReadOnly = true;
            this.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.ShortcutsEnabled = true;
            this.txtusername.ShowClearButton = true;
            this.txtusername.Size = new System.Drawing.Size(219, 37);
            this.txtusername.TabIndex = 10;
            this.txtusername.UseSelectable = true;
            this.txtusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtusername.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtpassword
            // 
            // 
            // 
            // 
            this.txtpassword.CustomButton.Image = null;
            this.txtpassword.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtpassword.CustomButton.Name = "";
            this.txtpassword.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpassword.CustomButton.TabIndex = 1;
            this.txtpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpassword.CustomButton.UseSelectable = true;
            this.txtpassword.CustomButton.Visible = false;
            this.txtpassword.DisplayIcon = true;
            this.txtpassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtpassword.Icon = global::Softwen.Resource.Key_2_30px;
            this.txtpassword.Lines = new string[0];
            this.txtpassword.Location = new System.Drawing.Point(269, 160);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '•';
            this.txtpassword.ReadOnly = true;
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.ShowClearButton = true;
            this.txtpassword.Size = new System.Drawing.Size(219, 37);
            this.txtpassword.TabIndex = 11;
            this.txtpassword.UseSelectable = true;
            this.txtpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpassword.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lnkrestore
            // 
            this.lnkrestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkrestore.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkrestore.Image = ((System.Drawing.Image)(resources.GetObject("lnkrestore.Image")));
            this.lnkrestore.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkrestore.ImageSize = 50;
            this.lnkrestore.Location = new System.Drawing.Point(358, 242);
            this.lnkrestore.Name = "lnkrestore";
            this.lnkrestore.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkrestore.NoFocusImage")));
            this.lnkrestore.Size = new System.Drawing.Size(62, 61);
            this.lnkrestore.TabIndex = 9;
            this.lnkrestore.Text = "Restore";
            this.lnkrestore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkrestore.UseSelectable = true;
            this.lnkrestore.Click += new System.EventHandler(this.lnkrestore_Click);
            // 
            // backupdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 312);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lnkrestore);
            this.Controls.Add(this.lnkbackup);
            this.Controls.Add(this.lblpercent);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.labelbarcode);
            this.MaximizeBox = false;
            this.Name = "backupdb";
            this.Resizable = false;
            this.Text = " Backup Database";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.backupdb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroTextBox txtserver;
        private System.Windows.Forms.Label labelbarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public MetroFramework.Controls.MetroTextBox txtdatabase;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Label lblpercent;
        public MetroFramework.Controls.MetroLink lnkbackup;
        private MetroFramework.Controls.MetroTextBox txtusername;
        private MetroFramework.Controls.MetroTextBox txtpassword;
        public MetroFramework.Controls.MetroLink lnkrestore;
    }
}