namespace Softwen.login
{
    partial class login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pnlsettings = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtcsettings = new MetroFramework.Controls.MetroTabControl();
            this.mtpconnection = new MetroFramework.Controls.MetroTabPage();
            this.btnsaveconnection = new MetroFramework.Controls.MetroButton();
            this.btntestconnection = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbserver = new MetroFramework.Controls.MetroComboBox();
            this.txtserverpassword = new MetroFramework.Controls.MetroTextBox();
            this.txtserverusername = new MetroFramework.Controls.MetroTextBox();
            this.mtpctheme = new MetroFramework.Controls.MetroTabPage();
            this.flpcolors = new System.Windows.Forms.FlowLayoutPanel();
            this.mrblight = new MetroFramework.Controls.MetroRadioButton();
            this.mrbdark = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lnkback = new MetroFramework.Controls.MetroLink();
            this.lnkeye = new MetroFramework.Controls.MetroLink();
            this.txtpassword = new MetroFramework.Controls.MetroTextBox();
            this.txtusername = new MetroFramework.Controls.MetroTextBox();
            this.pnlcenter = new MetroFramework.Controls.MetroPanel();
            this.lnklogin = new MetroFramework.Controls.MetroLink();
            this.hoplogo = new System.Windows.Forms.PictureBox();
            this.pnlsettings.SuspendLayout();
            this.mtcsettings.SuspendLayout();
            this.mtpconnection.SuspendLayout();
            this.mtpctheme.SuspendLayout();
            this.pnlcenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoplogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlsettings
            // 
            this.pnlsettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlsettings.Controls.Add(this.panel1);
            this.pnlsettings.Controls.Add(this.mtcsettings);
            this.pnlsettings.Controls.Add(this.lnkback);
            this.pnlsettings.HorizontalScrollbarBarColor = true;
            this.pnlsettings.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlsettings.HorizontalScrollbarSize = 10;
            this.pnlsettings.Location = new System.Drawing.Point(406, 0);
            this.pnlsettings.Name = "pnlsettings";
            this.pnlsettings.Size = new System.Drawing.Size(252, 465);
            this.pnlsettings.TabIndex = 2;
            this.pnlsettings.VerticalScrollbarBarColor = true;
            this.pnlsettings.VerticalScrollbarHighlightOnWheel = false;
            this.pnlsettings.VerticalScrollbarSize = 10;
            this.pnlsettings.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1, 465);
            this.panel1.TabIndex = 4;
            // 
            // mtcsettings
            // 
            this.mtcsettings.Controls.Add(this.mtpconnection);
            this.mtcsettings.Controls.Add(this.mtpctheme);
            this.mtcsettings.Location = new System.Drawing.Point(3, 42);
            this.mtcsettings.Name = "mtcsettings";
            this.mtcsettings.SelectedIndex = 0;
            this.mtcsettings.Size = new System.Drawing.Size(246, 359);
            this.mtcsettings.TabIndex = 3;
            this.mtcsettings.UseSelectable = true;
            // 
            // mtpconnection
            // 
            this.mtpconnection.Controls.Add(this.btnsaveconnection);
            this.mtpconnection.Controls.Add(this.btntestconnection);
            this.mtpconnection.Controls.Add(this.metroLabel6);
            this.mtpconnection.Controls.Add(this.metroLabel5);
            this.mtpconnection.Controls.Add(this.metroLabel3);
            this.mtpconnection.Controls.Add(this.cbserver);
            this.mtpconnection.Controls.Add(this.txtserverpassword);
            this.mtpconnection.Controls.Add(this.txtserverusername);
            this.mtpconnection.HorizontalScrollbarBarColor = true;
            this.mtpconnection.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpconnection.HorizontalScrollbarSize = 10;
            this.mtpconnection.Location = new System.Drawing.Point(4, 38);
            this.mtpconnection.Name = "mtpconnection";
            this.mtpconnection.Size = new System.Drawing.Size(238, 317);
            this.mtpconnection.TabIndex = 0;
            this.mtpconnection.Text = "Connection";
            this.mtpconnection.VerticalScrollbarBarColor = true;
            this.mtpconnection.VerticalScrollbarHighlightOnWheel = false;
            this.mtpconnection.VerticalScrollbarSize = 10;
            // 
            // btnsaveconnection
            // 
            this.btnsaveconnection.Enabled = false;
            this.btnsaveconnection.Location = new System.Drawing.Point(114, 195);
            this.btnsaveconnection.Name = "btnsaveconnection";
            this.btnsaveconnection.Size = new System.Drawing.Size(103, 25);
            this.btnsaveconnection.TabIndex = 6;
            this.btnsaveconnection.Text = "Save";
            this.btnsaveconnection.UseSelectable = true;
            this.btnsaveconnection.Click += new System.EventHandler(this.btnsaveconnection_Click);
            // 
            // btntestconnection
            // 
            this.btntestconnection.Location = new System.Drawing.Point(6, 195);
            this.btntestconnection.Name = "btntestconnection";
            this.btntestconnection.Size = new System.Drawing.Size(103, 25);
            this.btntestconnection.TabIndex = 4;
            this.btntestconnection.Text = "Test Connection";
            this.btntestconnection.UseSelectable = true;
            this.btntestconnection.Click += new System.EventHandler(this.btntest_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(6, 146);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(70, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Password:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(6, 93);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(74, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Username:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(6, 43);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Server: ";
            // 
            // cbserver
            // 
            this.cbserver.FormattingEnabled = true;
            this.cbserver.ItemHeight = 23;
            this.cbserver.Location = new System.Drawing.Point(81, 43);
            this.cbserver.Name = "cbserver";
            this.cbserver.Size = new System.Drawing.Size(137, 29);
            this.cbserver.TabIndex = 0;
            this.cbserver.UseSelectable = true;
            // 
            // txtserverpassword
            // 
            // 
            // 
            // 
            this.txtserverpassword.CustomButton.Image = null;
            this.txtserverpassword.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtserverpassword.CustomButton.Name = "";
            this.txtserverpassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtserverpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtserverpassword.CustomButton.TabIndex = 1;
            this.txtserverpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtserverpassword.CustomButton.UseSelectable = true;
            this.txtserverpassword.CustomButton.Visible = false;
            this.txtserverpassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtserverpassword.Lines = new string[0];
            this.txtserverpassword.Location = new System.Drawing.Point(81, 146);
            this.txtserverpassword.MaxLength = 32767;
            this.txtserverpassword.Name = "txtserverpassword";
            this.txtserverpassword.PasswordChar = '•';
            this.txtserverpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtserverpassword.SelectedText = "";
            this.txtserverpassword.SelectionLength = 0;
            this.txtserverpassword.SelectionStart = 0;
            this.txtserverpassword.ShortcutsEnabled = true;
            this.txtserverpassword.Size = new System.Drawing.Size(137, 25);
            this.txtserverpassword.TabIndex = 3;
            this.txtserverpassword.UseSelectable = true;
            this.txtserverpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtserverpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtserverusername
            // 
            // 
            // 
            // 
            this.txtserverusername.CustomButton.Image = null;
            this.txtserverusername.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtserverusername.CustomButton.Name = "";
            this.txtserverusername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtserverusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtserverusername.CustomButton.TabIndex = 1;
            this.txtserverusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtserverusername.CustomButton.UseSelectable = true;
            this.txtserverusername.CustomButton.Visible = false;
            this.txtserverusername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtserverusername.Lines = new string[0];
            this.txtserverusername.Location = new System.Drawing.Point(81, 93);
            this.txtserverusername.MaxLength = 32767;
            this.txtserverusername.Name = "txtserverusername";
            this.txtserverusername.PasswordChar = '\0';
            this.txtserverusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtserverusername.SelectedText = "";
            this.txtserverusername.SelectionLength = 0;
            this.txtserverusername.SelectionStart = 0;
            this.txtserverusername.ShortcutsEnabled = true;
            this.txtserverusername.Size = new System.Drawing.Size(137, 25);
            this.txtserverusername.TabIndex = 2;
            this.txtserverusername.UseSelectable = true;
            this.txtserverusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtserverusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtpctheme
            // 
            this.mtpctheme.Controls.Add(this.flpcolors);
            this.mtpctheme.Controls.Add(this.mrblight);
            this.mtpctheme.Controls.Add(this.mrbdark);
            this.mtpctheme.Controls.Add(this.metroLabel2);
            this.mtpctheme.Controls.Add(this.metroLabel1);
            this.mtpctheme.HorizontalScrollbarBarColor = true;
            this.mtpctheme.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpctheme.HorizontalScrollbarSize = 10;
            this.mtpctheme.Location = new System.Drawing.Point(4, 38);
            this.mtpctheme.Name = "mtpctheme";
            this.mtpctheme.Size = new System.Drawing.Size(238, 317);
            this.mtpctheme.TabIndex = 1;
            this.mtpctheme.Text = "Theme";
            this.mtpctheme.VerticalScrollbarBarColor = true;
            this.mtpctheme.VerticalScrollbarHighlightOnWheel = false;
            this.mtpctheme.VerticalScrollbarSize = 10;
            // 
            // flpcolors
            // 
            this.flpcolors.BackColor = System.Drawing.Color.White;
            this.flpcolors.Location = new System.Drawing.Point(12, 134);
            this.flpcolors.Name = "flpcolors";
            this.flpcolors.Size = new System.Drawing.Size(160, 139);
            this.flpcolors.TabIndex = 4;
            // 
            // mrblight
            // 
            this.mrblight.AutoSize = true;
            this.mrblight.Checked = true;
            this.mrblight.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrblight.ForeColor = System.Drawing.Color.Black;
            this.mrblight.Location = new System.Drawing.Point(84, 55);
            this.mrblight.Name = "mrblight";
            this.mrblight.Size = new System.Drawing.Size(56, 19);
            this.mrblight.TabIndex = 3;
            this.mrblight.TabStop = true;
            this.mrblight.Text = "Light";
            this.mrblight.UseSelectable = true;
            this.mrblight.CheckedChanged += new System.EventHandler(this.mrblight_CheckedChanged);
            // 
            // mrbdark
            // 
            this.mrbdark.AutoSize = true;
            this.mrbdark.BackColor = System.Drawing.Color.White;
            this.mrbdark.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbdark.Location = new System.Drawing.Point(12, 55);
            this.mrbdark.Name = "mrbdark";
            this.mrbdark.Size = new System.Drawing.Size(54, 19);
            this.mrbdark.TabIndex = 3;
            this.mrbdark.Text = "Dark";
            this.mrbdark.UseSelectable = true;
            this.mrbdark.CheckedChanged += new System.EventHandler(this.mrbdark_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(3, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Color";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Theme";
            // 
            // lnkback
            // 
            this.lnkback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkback.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkback.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkback.Image = ((System.Drawing.Image)(resources.GetObject("lnkback.Image")));
            this.lnkback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkback.ImageSize = 32;
            this.lnkback.Location = new System.Drawing.Point(0, 0);
            this.lnkback.Name = "lnkback";
            this.lnkback.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkback.NoFocusImage")));
            this.lnkback.Size = new System.Drawing.Size(134, 36);
            this.lnkback.TabIndex = 2;
            this.lnkback.Text = " Settings";
            this.lnkback.UseSelectable = true;
            this.lnkback.Click += new System.EventHandler(this.lnkback_Click);
            // 
            // lnkeye
            // 
            this.lnkeye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkeye.Image = ((System.Drawing.Image)(resources.GetObject("lnkeye.Image")));
            this.lnkeye.ImageSize = 37;
            this.lnkeye.Location = new System.Drawing.Point(268, 269);
            this.lnkeye.Name = "lnkeye";
            this.lnkeye.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkeye.NoFocusImage")));
            this.lnkeye.Size = new System.Drawing.Size(37, 37);
            this.lnkeye.TabIndex = 2;
            this.lnkeye.UseSelectable = true;
            this.lnkeye.Click += new System.EventHandler(this.metroLink1_Click);
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
            this.txtpassword.Location = new System.Drawing.Point(43, 269);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '•';
            this.txtpassword.PromptText = "password";
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.ShowClearButton = true;
            this.txtpassword.Size = new System.Drawing.Size(219, 37);
            this.txtpassword.TabIndex = 0;
            this.txtpassword.UseSelectable = true;
            this.txtpassword.WaterMark = "password";
            this.txtpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpassword.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
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
            this.txtusername.Location = new System.Drawing.Point(43, 226);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PromptText = "username";
            this.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.ShortcutsEnabled = true;
            this.txtusername.ShowClearButton = true;
            this.txtusername.Size = new System.Drawing.Size(219, 37);
            this.txtusername.TabIndex = 0;
            this.txtusername.UseSelectable = true;
            this.txtusername.WaterMark = "username";
            this.txtusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtusername.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlcenter
            // 
            this.pnlcenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlcenter.Controls.Add(this.lnklogin);
            this.pnlcenter.Controls.Add(this.hoplogo);
            this.pnlcenter.Controls.Add(this.txtusername);
            this.pnlcenter.Controls.Add(this.txtpassword);
            this.pnlcenter.Controls.Add(this.lnkeye);
            this.pnlcenter.HorizontalScrollbarBarColor = true;
            this.pnlcenter.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlcenter.HorizontalScrollbarSize = 10;
            this.pnlcenter.Location = new System.Drawing.Point(0, 42);
            this.pnlcenter.Name = "pnlcenter";
            this.pnlcenter.Size = new System.Drawing.Size(661, 420);
            this.pnlcenter.TabIndex = 0;
            this.pnlcenter.VerticalScrollbarBarColor = true;
            this.pnlcenter.VerticalScrollbarHighlightOnWheel = false;
            this.pnlcenter.VerticalScrollbarSize = 10;
            // 
            // lnklogin
            // 
            this.lnklogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnklogin.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnklogin.Image = ((System.Drawing.Image)(resources.GetObject("lnklogin.Image")));
            this.lnklogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnklogin.ImageSize = 50;
            this.lnklogin.Location = new System.Drawing.Point(127, 308);
            this.lnklogin.Name = "lnklogin";
            this.lnklogin.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnklogin.NoFocusImage")));
            this.lnklogin.Size = new System.Drawing.Size(54, 67);
            this.lnklogin.TabIndex = 6;
            this.lnklogin.Text = "Log in";
            this.lnklogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnklogin.UseSelectable = true;
            this.lnklogin.Click += new System.EventHandler(this.lnklogin_Click);
            // 
            // hoplogo
            // 
            this.hoplogo.BackColor = System.Drawing.Color.Transparent;
            this.hoplogo.Image = ((System.Drawing.Image)(resources.GetObject("hoplogo.Image")));
            this.hoplogo.Location = new System.Drawing.Point(43, 2);
            this.hoplogo.Name = "hoplogo";
            this.hoplogo.Size = new System.Drawing.Size(219, 218);
            this.hoplogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hoplogo.TabIndex = 5;
            this.hoplogo.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlsettings);
            this.Controls.Add(this.pnlcenter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.Size = new System.Drawing.Size(655, 465);
            this.Load += new System.EventHandler(this.login_Load);
            this.pnlsettings.ResumeLayout(false);
            this.mtcsettings.ResumeLayout(false);
            this.mtpconnection.ResumeLayout(false);
            this.mtpconnection.PerformLayout();
            this.mtpctheme.ResumeLayout(false);
            this.mtpctheme.PerformLayout();
            this.pnlcenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hoplogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel pnlsettings;
        private MetroFramework.Controls.MetroLink lnkback;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl mtcsettings;
        private MetroFramework.Controls.MetroTabPage mtpctheme;
        private MetroFramework.Controls.MetroTabPage mtpconnection;
        private MetroFramework.Controls.MetroRadioButton mrblight;
        private MetroFramework.Controls.MetroRadioButton mrbdark;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel flpcolors;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtserverpassword;
        private MetroFramework.Controls.MetroTextBox txtserverusername;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbserver;
        private MetroFramework.Controls.MetroButton btntestconnection;
        private MetroFramework.Controls.MetroLink lnkeye;
        private MetroFramework.Controls.MetroTextBox txtpassword;
        private MetroFramework.Controls.MetroTextBox txtusername;
        private MetroFramework.Controls.MetroPanel pnlcenter;
        public MetroFramework.Controls.MetroLink lnklogin;
        private System.Windows.Forms.PictureBox hoplogo;
        private MetroFramework.Controls.MetroButton btnsaveconnection;
    }
}
