namespace Softwen.Transaction
{
    partial class discount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(discount));
            this.labeldiscount = new System.Windows.Forms.Label();
            this.lnksave = new MetroFramework.Controls.MetroLink();
            this.rd1 = new MetroFramework.Controls.MetroRadioButton();
            this.rd2 = new MetroFramework.Controls.MetroRadioButton();
            this.rd4 = new MetroFramework.Controls.MetroRadioButton();
            this.txtdiscount = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd3 = new MetroFramework.Controls.MetroRadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeldiscount
            // 
            this.labeldiscount.AutoSize = true;
            this.labeldiscount.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldiscount.Location = new System.Drawing.Point(3, 6);
            this.labeldiscount.Name = "labeldiscount";
            this.labeldiscount.Size = new System.Drawing.Size(96, 22);
            this.labeldiscount.TabIndex = 21;
            this.labeldiscount.Text = "Discount %";
            // 
            // lnksave
            // 
            this.lnksave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnksave.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnksave.Image = ((System.Drawing.Image)(resources.GetObject("lnksave.Image")));
            this.lnksave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnksave.ImageSize = 50;
            this.lnksave.Location = new System.Drawing.Point(152, 193);
            this.lnksave.Name = "lnksave";
            this.lnksave.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnksave.NoFocusImage")));
            this.lnksave.Size = new System.Drawing.Size(63, 66);
            this.lnksave.TabIndex = 22;
            this.lnksave.Text = "Confirm";
            this.lnksave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnksave.UseSelectable = true;
            this.lnksave.Click += new System.EventHandler(this.lnksave_Click);
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Checked = true;
            this.rd1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rd1.Location = new System.Drawing.Point(23, 63);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(127, 25);
            this.rd1.TabIndex = 23;
            this.rd1.TabStop = true;
            this.rd1.Text = "No Discount";
            this.rd1.UseSelectable = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rd2.Location = new System.Drawing.Point(23, 94);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(135, 25);
            this.rd2.TabIndex = 23;
            this.rd2.Text = "Senior Citizen";
            this.rd2.UseSelectable = true;
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rd4.Location = new System.Drawing.Point(23, 156);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(85, 25);
            this.rd4.TabIndex = 23;
            this.rd4.Text = "Others:";
            this.rd4.UseSelectable = true;
            this.rd4.CheckedChanged += new System.EventHandler(this.metroRadioButton3_CheckedChanged);
            // 
            // txtdiscount
            // 
            // 
            // 
            // 
            this.txtdiscount.CustomButton.Image = null;
            this.txtdiscount.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.txtdiscount.CustomButton.Name = "";
            this.txtdiscount.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtdiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdiscount.CustomButton.TabIndex = 1;
            this.txtdiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdiscount.CustomButton.UseSelectable = true;
            this.txtdiscount.CustomButton.Visible = false;
            this.txtdiscount.DisplayIcon = true;
            this.txtdiscount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtdiscount.Icon = ((System.Drawing.Image)(resources.GetObject("txtdiscount.Icon")));
            this.txtdiscount.Lines = new string[0];
            this.txtdiscount.Location = new System.Drawing.Point(7, 31);
            this.txtdiscount.MaxLength = 2;
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.PasswordChar = '\0';
            this.txtdiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdiscount.SelectedText = "";
            this.txtdiscount.SelectionLength = 0;
            this.txtdiscount.SelectionStart = 0;
            this.txtdiscount.ShortcutsEnabled = false;
            this.txtdiscount.ShowClearButton = true;
            this.txtdiscount.Size = new System.Drawing.Size(106, 37);
            this.txtdiscount.TabIndex = 24;
            this.txtdiscount.UseSelectable = true;
            this.txtdiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdiscount.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtdiscount);
            this.panel1.Controls.Add(this.labeldiscount);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(16, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 72);
            this.panel1.TabIndex = 25;
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rd3.Location = new System.Drawing.Point(23, 125);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(181, 25);
            this.rd3.TabIndex = 23;
            this.rd3.Text = "Employee Discount";
            this.rd3.UseSelectable = true;
            // 
            // discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 266);
            this.Controls.Add(this.rd4);
            this.Controls.Add(this.rd3);
            this.Controls.Add(this.rd2);
            this.Controls.Add(this.rd1);
            this.Controls.Add(this.lnksave);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "discount";
            this.Resizable = false;
            this.Text = "Discount";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.discount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeldiscount;
        public MetroFramework.Controls.MetroLink lnksave;
        private MetroFramework.Controls.MetroRadioButton rd1;
        private MetroFramework.Controls.MetroRadioButton rd2;
        private MetroFramework.Controls.MetroRadioButton rd4;
        public MetroFramework.Controls.MetroTextBox txtdiscount;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroRadioButton rd3;
    }
}