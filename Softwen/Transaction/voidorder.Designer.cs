namespace Softwen.Transaction
{
    partial class voidorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(voidorder));
            this.txtkey = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lnkenter = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // txtkey
            // 
            // 
            // 
            // 
            this.txtkey.CustomButton.Image = null;
            this.txtkey.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtkey.CustomButton.Name = "";
            this.txtkey.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtkey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtkey.CustomButton.TabIndex = 1;
            this.txtkey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtkey.CustomButton.UseSelectable = true;
            this.txtkey.CustomButton.Visible = false;
            this.txtkey.DisplayIcon = true;
            this.txtkey.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtkey.Icon = ((System.Drawing.Image)(resources.GetObject("txtkey.Icon")));
            this.txtkey.Lines = new string[0];
            this.txtkey.Location = new System.Drawing.Point(12, 92);
            this.txtkey.MaxLength = 32767;
            this.txtkey.Name = "txtkey";
            this.txtkey.PasswordChar = '•';
            this.txtkey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtkey.SelectedText = "";
            this.txtkey.SelectionLength = 0;
            this.txtkey.SelectionStart = 0;
            this.txtkey.ShortcutsEnabled = true;
            this.txtkey.ShowClearButton = true;
            this.txtkey.Size = new System.Drawing.Size(219, 37);
            this.txtkey.TabIndex = 0;
            this.txtkey.UseSelectable = true;
            this.txtkey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtkey.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Void Key";
            // 
            // lnkenter
            // 
            this.lnkenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkenter.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkenter.Image = ((System.Drawing.Image)(resources.GetObject("lnkenter.Image")));
            this.lnkenter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkenter.ImageSize = 50;
            this.lnkenter.Location = new System.Drawing.Point(161, 135);
            this.lnkenter.Name = "lnkenter";
            this.lnkenter.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkenter.NoFocusImage")));
            this.lnkenter.Size = new System.Drawing.Size(70, 66);
            this.lnkenter.TabIndex = 1;
            this.lnkenter.Text = "Confirm";
            this.lnkenter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkenter.UseSelectable = true;
            this.lnkenter.Click += new System.EventHandler(this.lnkenter_Click);
            // 
            // voidorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 207);
            this.Controls.Add(this.txtkey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lnkenter);
            this.MaximizeBox = false;
            this.Name = "voidorder";
            this.Resizable = false;
            this.Text = "Void Order";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.voidorder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroTextBox txtkey;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroLink lnkenter;
    }
}