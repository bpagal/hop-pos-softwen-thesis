namespace Softwen.Dashboard
{
    partial class dashboard
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
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation9 = new BunifuAnimatorNS.Animation();
            this.panelmenu = new MetroFramework.Controls.MetroPanel();
            this.btnmaintenance = new MetroFramework.Controls.MetroTile();
            this.btnhome = new MetroFramework.Controls.MetroTile();
            this.lnkmenu = new MetroFramework.Controls.MetroLink();
            this.hoplogo = new System.Windows.Forms.PictureBox();
            this.btnreports = new MetroFramework.Controls.MetroTile();
            this.btnproducts = new MetroFramework.Controls.MetroTile();
            this.btnsales = new MetroFramework.Controls.MetroTile();
            this.btnuseract = new MetroFramework.Controls.MetroTile();
            this.generalpanel = new MetroFramework.Controls.MetroPanel();
            this.logoanimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.lnklogout = new MetroFramework.Controls.MetroLink();
            this.lnkminimize = new MetroFramework.Controls.MetroLink();
            this.lnkclose = new MetroFramework.Controls.MetroLink();
            this.labelname = new System.Windows.Forms.Label();
            this.labelstorename = new System.Windows.Forms.Label();
            this.labelmodule = new System.Windows.Forms.Label();
            this.sidemenuanimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.controlanimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoplogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.Transparent;
            this.panelmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelmenu.Controls.Add(this.btnmaintenance);
            this.panelmenu.Controls.Add(this.btnhome);
            this.panelmenu.Controls.Add(this.lnkmenu);
            this.panelmenu.Controls.Add(this.hoplogo);
            this.panelmenu.Controls.Add(this.btnreports);
            this.panelmenu.Controls.Add(this.btnproducts);
            this.panelmenu.Controls.Add(this.btnsales);
            this.panelmenu.Controls.Add(this.btnuseract);
            this.controlanimator.SetDecoration(this.panelmenu, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.panelmenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.panelmenu, BunifuAnimatorNS.DecorationType.None);
            this.panelmenu.HorizontalScrollbarBarColor = true;
            this.panelmenu.HorizontalScrollbarHighlightOnWheel = false;
            this.panelmenu.HorizontalScrollbarSize = 10;
            this.panelmenu.Location = new System.Drawing.Point(0, 5);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Padding = new System.Windows.Forms.Padding(20);
            this.panelmenu.Size = new System.Drawing.Size(165, 560);
            this.panelmenu.TabIndex = 1;
            this.panelmenu.VerticalScrollbarBarColor = true;
            this.panelmenu.VerticalScrollbarHighlightOnWheel = false;
            this.panelmenu.VerticalScrollbarSize = 10;
            // 
            // btnmaintenance
            // 
            this.btnmaintenance.ActiveControl = null;
            this.logoanimator.SetDecoration(this.btnmaintenance, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.btnmaintenance, BunifuAnimatorNS.DecorationType.None);
            this.controlanimator.SetDecoration(this.btnmaintenance, BunifuAnimatorNS.DecorationType.None);
            this.btnmaintenance.Location = new System.Drawing.Point(0, 495);
            this.btnmaintenance.Name = "btnmaintenance";
            this.btnmaintenance.Size = new System.Drawing.Size(163, 63);
            this.btnmaintenance.Style = MetroFramework.MetroColorStyle.Red;
            this.btnmaintenance.TabIndex = 1;
            this.btnmaintenance.Text = "       Maintenance";
            this.btnmaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnmaintenance.TileImage = ((System.Drawing.Image)(resources.GetObject("btnmaintenance.TileImage")));
            this.btnmaintenance.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmaintenance.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnmaintenance.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnmaintenance.UseSelectable = true;
            this.btnmaintenance.UseTileImage = true;
            this.btnmaintenance.Click += new System.EventHandler(this.btnmaintenance_Click);
            // 
            // btnhome
            // 
            this.btnhome.ActiveControl = null;
            this.logoanimator.SetDecoration(this.btnhome, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.btnhome, BunifuAnimatorNS.DecorationType.None);
            this.controlanimator.SetDecoration(this.btnhome, BunifuAnimatorNS.DecorationType.None);
            this.btnhome.Location = new System.Drawing.Point(0, 180);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(163, 63);
            this.btnhome.Style = MetroFramework.MetroColorStyle.Red;
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "       Dashboard";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnhome.TileImage = ((System.Drawing.Image)(resources.GetObject("btnhome.TileImage")));
            this.btnhome.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnhome.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnhome.UseSelectable = true;
            this.btnhome.UseTileImage = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // lnkmenu
            // 
            this.lnkmenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lnkmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoanimator.SetDecoration(this.lnkmenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.lnkmenu, BunifuAnimatorNS.DecorationType.None);
            this.controlanimator.SetDecoration(this.lnkmenu, BunifuAnimatorNS.DecorationType.None);
            this.lnkmenu.Image = ((System.Drawing.Image)(resources.GetObject("lnkmenu.Image")));
            this.lnkmenu.ImageSize = 32;
            this.lnkmenu.Location = new System.Drawing.Point(123, 3);
            this.lnkmenu.Name = "lnkmenu";
            this.lnkmenu.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkmenu.NoFocusImage")));
            this.lnkmenu.Size = new System.Drawing.Size(32, 32);
            this.lnkmenu.TabIndex = 5;
            this.lnkmenu.UseSelectable = true;
            this.lnkmenu.Click += new System.EventHandler(this.lnkmenu_Click);
            // 
            // hoplogo
            // 
            this.hoplogo.BackColor = System.Drawing.Color.Transparent;
            this.controlanimator.SetDecoration(this.hoplogo, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.hoplogo, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.hoplogo, BunifuAnimatorNS.DecorationType.None);
            this.hoplogo.Image = ((System.Drawing.Image)(resources.GetObject("hoplogo.Image")));
            this.hoplogo.Location = new System.Drawing.Point(6, 11);
            this.hoplogo.Name = "hoplogo";
            this.hoplogo.Size = new System.Drawing.Size(149, 156);
            this.hoplogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hoplogo.TabIndex = 2;
            this.hoplogo.TabStop = false;
            // 
            // btnreports
            // 
            this.btnreports.ActiveControl = null;
            this.logoanimator.SetDecoration(this.btnreports, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.btnreports, BunifuAnimatorNS.DecorationType.None);
            this.controlanimator.SetDecoration(this.btnreports, BunifuAnimatorNS.DecorationType.None);
            this.btnreports.Location = new System.Drawing.Point(0, 369);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(163, 63);
            this.btnreports.Style = MetroFramework.MetroColorStyle.Red;
            this.btnreports.TabIndex = 3;
            this.btnreports.Text = "Reports";
            this.btnreports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnreports.TileImage = ((System.Drawing.Image)(resources.GetObject("btnreports.TileImage")));
            this.btnreports.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreports.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnreports.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnreports.UseSelectable = true;
            this.btnreports.UseTileImage = true;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btnproducts
            // 
            this.btnproducts.ActiveControl = null;
            this.logoanimator.SetDecoration(this.btnproducts, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.btnproducts, BunifuAnimatorNS.DecorationType.None);
            this.controlanimator.SetDecoration(this.btnproducts, BunifuAnimatorNS.DecorationType.None);
            this.btnproducts.Location = new System.Drawing.Point(0, 243);
            this.btnproducts.Name = "btnproducts";
            this.btnproducts.Size = new System.Drawing.Size(163, 63);
            this.btnproducts.Style = MetroFramework.MetroColorStyle.Red;
            this.btnproducts.TabIndex = 2;
            this.btnproducts.Text = "    Products";
            this.btnproducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnproducts.TileImage = ((System.Drawing.Image)(resources.GetObject("btnproducts.TileImage")));
            this.btnproducts.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproducts.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnproducts.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnproducts.UseSelectable = true;
            this.btnproducts.UseTileImage = true;
            this.btnproducts.Click += new System.EventHandler(this.btnproducts_Click);
            // 
            // btnsales
            // 
            this.btnsales.ActiveControl = null;
            this.logoanimator.SetDecoration(this.btnsales, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.btnsales, BunifuAnimatorNS.DecorationType.None);
            this.controlanimator.SetDecoration(this.btnsales, BunifuAnimatorNS.DecorationType.None);
            this.btnsales.Location = new System.Drawing.Point(0, 306);
            this.btnsales.Name = "btnsales";
            this.btnsales.Size = new System.Drawing.Size(163, 63);
            this.btnsales.Style = MetroFramework.MetroColorStyle.Red;
            this.btnsales.TabIndex = 2;
            this.btnsales.Text = "     Transaction";
            this.btnsales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsales.TileImage = ((System.Drawing.Image)(resources.GetObject("btnsales.TileImage")));
            this.btnsales.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsales.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnsales.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnsales.UseSelectable = true;
            this.btnsales.UseTileImage = true;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // btnuseract
            // 
            this.btnuseract.ActiveControl = null;
            this.logoanimator.SetDecoration(this.btnuseract, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.btnuseract, BunifuAnimatorNS.DecorationType.None);
            this.controlanimator.SetDecoration(this.btnuseract, BunifuAnimatorNS.DecorationType.None);
            this.btnuseract.Location = new System.Drawing.Point(0, 432);
            this.btnuseract.Name = "btnuseract";
            this.btnuseract.Size = new System.Drawing.Size(163, 63);
            this.btnuseract.Style = MetroFramework.MetroColorStyle.Red;
            this.btnuseract.TabIndex = 1;
            this.btnuseract.Text = "       User Activity";
            this.btnuseract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnuseract.TileImage = ((System.Drawing.Image)(resources.GetObject("btnuseract.TileImage")));
            this.btnuseract.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuseract.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnuseract.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnuseract.UseSelectable = true;
            this.btnuseract.UseTileImage = true;
            this.btnuseract.Click += new System.EventHandler(this.btnuseract_Click);
            // 
            // generalpanel
            // 
            this.controlanimator.SetDecoration(this.generalpanel, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.generalpanel, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.generalpanel, BunifuAnimatorNS.DecorationType.None);
            this.generalpanel.HorizontalScrollbarBarColor = true;
            this.generalpanel.HorizontalScrollbarHighlightOnWheel = false;
            this.generalpanel.HorizontalScrollbarSize = 10;
            this.generalpanel.Location = new System.Drawing.Point(170, 43);
            this.generalpanel.Name = "generalpanel";
            this.generalpanel.Size = new System.Drawing.Size(1085, 518);
            this.generalpanel.TabIndex = 2;
            this.generalpanel.VerticalScrollbarBarColor = true;
            this.generalpanel.VerticalScrollbarHighlightOnWheel = false;
            this.generalpanel.VerticalScrollbarSize = 10;
            // 
            // logoanimator
            // 
            this.logoanimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.logoanimator.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(30);
            animation7.RotateCoeff = 0.5F;
            animation7.RotateLimit = 0.2F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.logoanimator.DefaultAnimation = animation7;
            // 
            // lnklogout
            // 
            this.lnklogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoanimator.SetDecoration(this.lnklogout, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.lnklogout, BunifuAnimatorNS.DecorationType.None);
            this.controlanimator.SetDecoration(this.lnklogout, BunifuAnimatorNS.DecorationType.None);
            this.lnklogout.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnklogout.Image = ((System.Drawing.Image)(resources.GetObject("lnklogout.Image")));
            this.lnklogout.ImageSize = 32;
            this.lnklogout.Location = new System.Drawing.Point(1147, 5);
            this.lnklogout.Name = "lnklogout";
            this.lnklogout.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnklogout.NoFocusImage")));
            this.lnklogout.Size = new System.Drawing.Size(32, 35);
            this.lnklogout.TabIndex = 3;
            this.lnklogout.UseCustomBackColor = true;
            this.lnklogout.UseCustomForeColor = true;
            this.lnklogout.UseSelectable = true;
            this.lnklogout.Click += new System.EventHandler(this.lnklogout_Click);
            // 
            // lnkminimize
            // 
            this.lnkminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkminimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoanimator.SetDecoration(this.lnkminimize, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.lnkminimize, BunifuAnimatorNS.DecorationType.None);
            this.controlanimator.SetDecoration(this.lnkminimize, BunifuAnimatorNS.DecorationType.None);
            this.lnkminimize.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkminimize.Image = ((System.Drawing.Image)(resources.GetObject("lnkminimize.Image")));
            this.lnkminimize.ImageSize = 32;
            this.lnkminimize.Location = new System.Drawing.Point(1185, 6);
            this.lnkminimize.Name = "lnkminimize";
            this.lnkminimize.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkminimize.NoFocusImage")));
            this.lnkminimize.Size = new System.Drawing.Size(32, 32);
            this.lnkminimize.TabIndex = 4;
            this.lnkminimize.UseCustomBackColor = true;
            this.lnkminimize.UseCustomForeColor = true;
            this.lnkminimize.UseSelectable = true;
            this.lnkminimize.Click += new System.EventHandler(this.lnkminimize_Click);
            // 
            // lnkclose
            // 
            this.lnkclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoanimator.SetDecoration(this.lnkclose, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.lnkclose, BunifuAnimatorNS.DecorationType.None);
            this.controlanimator.SetDecoration(this.lnkclose, BunifuAnimatorNS.DecorationType.None);
            this.lnkclose.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkclose.Image = ((System.Drawing.Image)(resources.GetObject("lnkclose.Image")));
            this.lnkclose.ImageSize = 32;
            this.lnkclose.Location = new System.Drawing.Point(1223, 6);
            this.lnkclose.Name = "lnkclose";
            this.lnkclose.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkclose.NoFocusImage")));
            this.lnkclose.Size = new System.Drawing.Size(32, 32);
            this.lnkclose.TabIndex = 5;
            this.lnkclose.UseCustomBackColor = true;
            this.lnkclose.UseCustomForeColor = true;
            this.lnkclose.UseSelectable = true;
            this.lnkclose.Click += new System.EventHandler(this.lnkclose_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.controlanimator.SetDecoration(this.labelname, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.labelname, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.labelname, BunifuAnimatorNS.DecorationType.None);
            this.labelname.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(966, 9);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(175, 28);
            this.labelname.TabIndex = 6;
            this.labelname.Text = "Name goes here";
            // 
            // labelstorename
            // 
            this.labelstorename.AutoSize = true;
            this.controlanimator.SetDecoration(this.labelstorename, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.labelstorename, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.labelstorename, BunifuAnimatorNS.DecorationType.None);
            this.labelstorename.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstorename.Location = new System.Drawing.Point(171, 9);
            this.labelstorename.Name = "labelstorename";
            this.labelstorename.Size = new System.Drawing.Size(230, 28);
            this.labelstorename.TabIndex = 6;
            this.labelstorename.Text = "Store name goes here";
            // 
            // labelmodule
            // 
            this.labelmodule.AutoSize = true;
            this.controlanimator.SetDecoration(this.labelmodule, BunifuAnimatorNS.DecorationType.None);
            this.sidemenuanimator.SetDecoration(this.labelmodule, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.labelmodule, BunifuAnimatorNS.DecorationType.None);
            this.labelmodule.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmodule.Location = new System.Drawing.Point(407, 9);
            this.labelmodule.Name = "labelmodule";
            this.labelmodule.Size = new System.Drawing.Size(122, 28);
            this.labelmodule.TabIndex = 6;
            this.labelmodule.Text = "Dashboard";
            this.labelmodule.Visible = false;
            // 
            // sidemenuanimator
            // 
            this.sidemenuanimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.sidemenuanimator.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 1;
            animation8.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 2F;
            animation8.TransparencyCoeff = 0F;
            this.sidemenuanimator.DefaultAnimation = animation8;
            // 
            // controlanimator
            // 
            this.controlanimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.controlanimator.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 0;
            animation9.Padding = new System.Windows.Forms.Padding(0);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 0F;
            animation9.TransparencyCoeff = 1F;
            this.controlanimator.DefaultAnimation = animation9;
            this.controlanimator.TimeStep = 0.06F;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackLocation = MetroFramework.Forms.BackLocation.BottomLeft;
            this.BackMaxSize = 150;
            this.ClientSize = new System.Drawing.Size(1257, 565);
            this.ControlBox = false;
            this.Controls.Add(this.labelmodule);
            this.Controls.Add(this.labelstorename);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.lnklogout);
            this.Controls.Add(this.lnkminimize);
            this.Controls.Add(this.lnkclose);
            this.Controls.Add(this.generalpanel);
            this.Controls.Add(this.panelmenu);
            this.sidemenuanimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.controlanimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dashboard";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 20, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = " ";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hoplogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnhome;
        private MetroFramework.Controls.MetroPanel panelmenu;
        private System.Windows.Forms.PictureBox hoplogo;
        private MetroFramework.Controls.MetroTile btnsales;
        private MetroFramework.Controls.MetroLink lnkmenu;
        private BunifuAnimatorNS.BunifuTransition logoanimator;
        private MetroFramework.Controls.MetroPanel generalpanel;
        private BunifuAnimatorNS.BunifuTransition sidemenuanimator;
        private BunifuAnimatorNS.BunifuTransition controlanimator;
        private MetroFramework.Controls.MetroLink lnklogout;
        private MetroFramework.Controls.MetroLink lnkminimize;
        private MetroFramework.Controls.MetroLink lnkclose;
        private MetroFramework.Controls.MetroTile btnuseract;
        public MetroFramework.Controls.MetroTile btnmaintenance;
        private MetroFramework.Controls.MetroTile btnproducts;
        public System.Windows.Forms.Label labelname;
        public System.Windows.Forms.Label labelstorename;
        public System.Windows.Forms.Label labelmodule;
        public MetroFramework.Controls.MetroTile btnreports;
    }
}