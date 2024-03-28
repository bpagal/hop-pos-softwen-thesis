namespace Softwen.Products
{
    partial class adddispense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adddispense));
            this.lnksave = new MetroFramework.Controls.MetroLink();
            this.txtquantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproductname = new MetroFramework.Controls.MetroTextBox();
            this.labelproductname = new System.Windows.Forms.Label();
            this.paneldispense = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcomment = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtreason = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            this.paneldispense.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnksave
            // 
            this.lnksave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnksave.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnksave.Image = ((System.Drawing.Image)(resources.GetObject("lnksave.Image")));
            this.lnksave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnksave.ImageSize = 50;
            this.lnksave.Location = new System.Drawing.Point(625, 15);
            this.lnksave.Name = "lnksave";
            this.lnksave.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnksave.NoFocusImage")));
            this.lnksave.Size = new System.Drawing.Size(63, 66);
            this.lnksave.TabIndex = 4;
            this.lnksave.Text = "Confirm";
            this.lnksave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnksave.UseSelectable = true;
            this.lnksave.Click += new System.EventHandler(this.lnksave_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(358, 48);
            this.txtquantity.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(104, 26);
            this.txtquantity.TabIndex = 1;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Physical Quantity";
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
            this.txtproductname.Location = new System.Drawing.Point(10, 40);
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
            this.txtproductname.TabIndex = 0;
            this.txtproductname.UseSelectable = true;
            this.txtproductname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtproductname.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelproductname
            // 
            this.labelproductname.AutoSize = true;
            this.labelproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductname.Location = new System.Drawing.Point(6, 15);
            this.labelproductname.Name = "labelproductname";
            this.labelproductname.Size = new System.Drawing.Size(122, 20);
            this.labelproductname.TabIndex = 27;
            this.labelproductname.Text = "Product Name";
            // 
            // paneldispense
            // 
            this.paneldispense.Controls.Add(this.txtreason);
            this.paneldispense.Controls.Add(this.label3);
            this.paneldispense.Controls.Add(this.lnksave);
            this.paneldispense.Controls.Add(this.txtcomment);
            this.paneldispense.Controls.Add(this.label2);
            this.paneldispense.Controls.Add(this.txtquantity);
            this.paneldispense.Controls.Add(this.txtproductname);
            this.paneldispense.Controls.Add(this.label1);
            this.paneldispense.Controls.Add(this.labelproductname);
            this.paneldispense.Location = new System.Drawing.Point(13, 63);
            this.paneldispense.Name = "paneldispense";
            this.paneldispense.Size = new System.Drawing.Size(694, 202);
            this.paneldispense.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Reason";
            // 
            // txtcomment
            // 
            // 
            // 
            // 
            this.txtcomment.CustomButton.Image = null;
            this.txtcomment.CustomButton.Location = new System.Drawing.Point(244, 2);
            this.txtcomment.CustomButton.Name = "";
            this.txtcomment.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.txtcomment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcomment.CustomButton.TabIndex = 1;
            this.txtcomment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcomment.CustomButton.UseSelectable = true;
            this.txtcomment.CustomButton.Visible = false;
            this.txtcomment.DisplayIcon = true;
            this.txtcomment.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtcomment.Icon = ((System.Drawing.Image)(resources.GetObject("txtcomment.Icon")));
            this.txtcomment.Lines = new string[0];
            this.txtcomment.Location = new System.Drawing.Point(10, 104);
            this.txtcomment.MaxLength = 32767;
            this.txtcomment.Multiline = true;
            this.txtcomment.Name = "txtcomment";
            this.txtcomment.PasswordChar = '\0';
            this.txtcomment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcomment.SelectedText = "";
            this.txtcomment.SelectionLength = 0;
            this.txtcomment.SelectionStart = 0;
            this.txtcomment.ShortcutsEnabled = true;
            this.txtcomment.ShowClearButton = true;
            this.txtcomment.Size = new System.Drawing.Size(330, 88);
            this.txtcomment.TabIndex = 2;
            this.txtcomment.UseSelectable = true;
            this.txtcomment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcomment.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Comment";
            // 
            // txtreason
            // 
            this.txtreason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtreason.FormattingEnabled = true;
            this.txtreason.ItemHeight = 23;
            this.txtreason.Items.AddRange(new object[] {
            "Missing",
            "Lost"});
            this.txtreason.Location = new System.Drawing.Point(358, 104);
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(186, 29);
            this.txtreason.TabIndex = 38;
            this.txtreason.UseSelectable = true;
            // 
            // adddispense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 270);
            this.Controls.Add(this.paneldispense);
            this.MaximizeBox = false;
            this.Name = "adddispense";
            this.Resizable = false;
            this.Text = "Missing";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            this.paneldispense.ResumeLayout(false);
            this.paneldispense.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroLink lnksave;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown txtquantity;
        public MetroFramework.Controls.MetroTextBox txtproductname;
        private System.Windows.Forms.Label labelproductname;
        private System.Windows.Forms.Panel paneldispense;
        private System.Windows.Forms.Label label3;
        public MetroFramework.Controls.MetroTextBox txtcomment;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox txtreason;
    }
}