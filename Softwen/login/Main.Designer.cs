namespace Softwen.login
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.msmmain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lnksettings = new MetroFramework.Controls.MetroLink();
            this.lnkminimize = new MetroFramework.Controls.MetroLink();
            this.lnkclose = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.msmmain)).BeginInit();
            this.SuspendLayout();
            // 
            // msmmain
            // 
            this.msmmain.Owner = this;
            this.msmmain.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // lnksettings
            // 
            this.lnksettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnksettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnksettings.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnksettings.Image = ((System.Drawing.Image)(resources.GetObject("lnksettings.Image")));
            this.lnksettings.ImageSize = 32;
            this.lnksettings.Location = new System.Drawing.Point(190, 17);
            this.lnksettings.Name = "lnksettings";
            this.lnksettings.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnksettings.NoFocusImage")));
            this.lnksettings.Size = new System.Drawing.Size(32, 32);
            this.lnksettings.TabIndex = 0;
            this.lnksettings.UseSelectable = true;
            this.lnksettings.Click += new System.EventHandler(this.lnksettings_Click);
            // 
            // lnkminimize
            // 
            this.lnkminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkminimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkminimize.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkminimize.Image = ((System.Drawing.Image)(resources.GetObject("lnkminimize.Image")));
            this.lnkminimize.ImageSize = 32;
            this.lnkminimize.Location = new System.Drawing.Point(228, 17);
            this.lnkminimize.Name = "lnkminimize";
            this.lnkminimize.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkminimize.NoFocusImage")));
            this.lnkminimize.Size = new System.Drawing.Size(32, 32);
            this.lnkminimize.TabIndex = 0;
            this.lnkminimize.UseSelectable = true;
            this.lnkminimize.Click += new System.EventHandler(this.lnkminimize_Click);
            // 
            // lnkclose
            // 
            this.lnkclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkclose.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkclose.Image = ((System.Drawing.Image)(resources.GetObject("lnkclose.Image")));
            this.lnkclose.ImageSize = 32;
            this.lnkclose.Location = new System.Drawing.Point(266, 17);
            this.lnkclose.Name = "lnkclose";
            this.lnkclose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkclose.NoFocusImage")));
            this.lnkclose.Size = new System.Drawing.Size(32, 32);
            this.lnkclose.TabIndex = 0;
            this.lnkclose.UseSelectable = true;
            this.lnkclose.Click += new System.EventHandler(this.lnkclose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lnksettings);
            this.Controls.Add(this.lnkminimize);
            this.Controls.Add(this.lnkclose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Resizable = false;
            this.RightToLeftLayout = true;
            this.Text = "LOG IN";
            ((System.ComponentModel.ISupportInitialize)(this.msmmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkclose;
        private MetroFramework.Controls.MetroLink lnksettings;
        private MetroFramework.Controls.MetroLink lnkminimize;
        public MetroFramework.Components.MetroStyleManager msmmain;
    }
}