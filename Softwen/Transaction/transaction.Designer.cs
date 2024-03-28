namespace Softwen.Transaction
{
    partial class transaction
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transaction));
            this.transactionstylemanager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.dgtransaction = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionpanel = new System.Windows.Forms.Panel();
            this.lnkfocusbc = new MetroFramework.Controls.MetroLink();
            this.lnkvoid = new MetroFramework.Controls.MetroLink();
            this.autopanel = new System.Windows.Forms.Panel();
            this.txtmodifyquantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkeditqty1 = new MetroFramework.Controls.MetroLink();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkdiscount = new MetroFramework.Controls.MetroLink();
            this.lnkpayment = new MetroFramework.Controls.MetroLink();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grandtotal = new MetroFramework.Controls.MetroTextBox();
            this.discountamount = new MetroFramework.Controls.MetroTextBox();
            this.discountpercent = new MetroFramework.Controls.MetroTextBox();
            this.vat = new MetroFramework.Controls.MetroTextBox();
            this.subtotal = new MetroFramework.Controls.MetroTextBox();
            this.cashier = new MetroFramework.Controls.MetroTextBox();
            this.labelcashier = new System.Windows.Forms.Label();
            this.labeldiscountamount = new System.Windows.Forms.Label();
            this.labelsubtotal = new System.Windows.Forms.Label();
            this.labelgrandtotal = new System.Windows.Forms.Label();
            this.labeldiscount = new System.Windows.Forms.Label();
            this.labelvat = new System.Windows.Forms.Label();
            this.manualpanel = new System.Windows.Forms.Panel();
            this.lnkeditqty2 = new MetroFramework.Controls.MetroLink();
            this.txtquantity = new System.Windows.Forms.NumericUpDown();
            this.combobxproduct = new MetroFramework.Controls.MetroComboBox();
            this.labelproductname = new System.Windows.Forms.Label();
            this.lnkaddorder = new MetroFramework.Controls.MetroLink();
            this.labelquantity = new System.Windows.Forms.Label();
            this.bctoggle = new MetroFramework.Controls.MetroToggle();
            this.txtautobc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.transactionstylemanager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtransaction)).BeginInit();
            this.transactionpanel.SuspendLayout();
            this.autopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmodifyquantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.manualpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionstylemanager
            // 
            this.transactionstylemanager.Owner = this;
            // 
            // dgtransaction
            // 
            this.dgtransaction.AllowUserToAddRows = false;
            this.dgtransaction.AllowUserToDeleteRows = false;
            this.dgtransaction.AllowUserToResizeColumns = false;
            this.dgtransaction.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dgtransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgtransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgtransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgtransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgtransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgtransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgtransaction.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgtransaction.EnableHeadersVisualStyles = false;
            this.dgtransaction.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgtransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgtransaction.Location = new System.Drawing.Point(14, 9);
            this.dgtransaction.Name = "dgtransaction";
            this.dgtransaction.ReadOnly = true;
            this.dgtransaction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtransaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgtransaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgtransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtransaction.Size = new System.Drawing.Size(648, 494);
            this.dgtransaction.TabIndex = 2;
            this.dgtransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtransaction_CellContentClick);
            this.dgtransaction.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtransaction_CellValueChanged);
            this.dgtransaction.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgtransaction_RowsAdded);
            this.dgtransaction.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgtransaction_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 144;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Unit Price ₱";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 123;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Category";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 102;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 121;
            // 
            // transactionpanel
            // 
            this.transactionpanel.Controls.Add(this.lnkfocusbc);
            this.transactionpanel.Controls.Add(this.lnkvoid);
            this.transactionpanel.Controls.Add(this.autopanel);
            this.transactionpanel.Controls.Add(this.label2);
            this.transactionpanel.Controls.Add(this.lnkdiscount);
            this.transactionpanel.Controls.Add(this.lnkpayment);
            this.transactionpanel.Controls.Add(this.groupBox1);
            this.transactionpanel.Controls.Add(this.manualpanel);
            this.transactionpanel.Controls.Add(this.bctoggle);
            this.transactionpanel.Controls.Add(this.dgtransaction);
            this.transactionpanel.Controls.Add(this.txtautobc);
            this.transactionpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionpanel.Location = new System.Drawing.Point(0, 0);
            this.transactionpanel.Name = "transactionpanel";
            this.transactionpanel.Size = new System.Drawing.Size(1085, 518);
            this.transactionpanel.TabIndex = 0;
            this.transactionpanel.Visible = false;
            // 
            // lnkfocusbc
            // 
            this.lnkfocusbc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkfocusbc.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkfocusbc.Image = ((System.Drawing.Image)(resources.GetObject("lnkfocusbc.Image")));
            this.lnkfocusbc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkfocusbc.ImageSize = 50;
            this.lnkfocusbc.Location = new System.Drawing.Point(972, 32);
            this.lnkfocusbc.Name = "lnkfocusbc";
            this.lnkfocusbc.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkfocusbc.NoFocusImage")));
            this.lnkfocusbc.Size = new System.Drawing.Size(107, 66);
            this.lnkfocusbc.TabIndex = 16;
            this.lnkfocusbc.Text = "Focus Barcode";
            this.lnkfocusbc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkfocusbc.UseSelectable = true;
            this.lnkfocusbc.Click += new System.EventHandler(this.lnkfocusbc_Click);
            // 
            // lnkvoid
            // 
            this.lnkvoid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkvoid.Enabled = false;
            this.lnkvoid.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkvoid.Image = ((System.Drawing.Image)(resources.GetObject("lnkvoid.Image")));
            this.lnkvoid.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkvoid.ImageSize = 50;
            this.lnkvoid.Location = new System.Drawing.Point(816, 437);
            this.lnkvoid.Name = "lnkvoid";
            this.lnkvoid.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkvoid.NoFocusImage")));
            this.lnkvoid.Size = new System.Drawing.Size(95, 66);
            this.lnkvoid.TabIndex = 18;
            this.lnkvoid.Text = "Void Order";
            this.lnkvoid.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkvoid.UseSelectable = true;
            this.lnkvoid.Click += new System.EventHandler(this.metroLink1_Click_1);
            // 
            // autopanel
            // 
            this.autopanel.Controls.Add(this.txtmodifyquantity);
            this.autopanel.Controls.Add(this.label1);
            this.autopanel.Controls.Add(this.lnkeditqty1);
            this.autopanel.Enabled = false;
            this.autopanel.Location = new System.Drawing.Point(672, 35);
            this.autopanel.Name = "autopanel";
            this.autopanel.Size = new System.Drawing.Size(213, 83);
            this.autopanel.TabIndex = 17;
            // 
            // txtmodifyquantity
            // 
            this.txtmodifyquantity.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodifyquantity.Location = new System.Drawing.Point(8, 34);
            this.txtmodifyquantity.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.txtmodifyquantity.Name = "txtmodifyquantity";
            this.txtmodifyquantity.Size = new System.Drawing.Size(104, 29);
            this.txtmodifyquantity.TabIndex = 13;
            this.txtmodifyquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmodifyquantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quantity";
            // 
            // lnkeditqty1
            // 
            this.lnkeditqty1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkeditqty1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkeditqty1.Image = ((System.Drawing.Image)(resources.GetObject("lnkeditqty1.Image")));
            this.lnkeditqty1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkeditqty1.ImageSize = 50;
            this.lnkeditqty1.Location = new System.Drawing.Point(130, 9);
            this.lnkeditqty1.Name = "lnkeditqty1";
            this.lnkeditqty1.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkeditqty1.NoFocusImage")));
            this.lnkeditqty1.Size = new System.Drawing.Size(68, 66);
            this.lnkeditqty1.TabIndex = 15;
            this.lnkeditqty1.Text = "Edit Qty";
            this.lnkeditqty1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkeditqty1.UseSelectable = true;
            this.lnkeditqty1.Click += new System.EventHandler(this.lnkeditqty1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Use Scanner";
            // 
            // lnkdiscount
            // 
            this.lnkdiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkdiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkdiscount.Enabled = false;
            this.lnkdiscount.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkdiscount.Image = ((System.Drawing.Image)(resources.GetObject("lnkdiscount.Image")));
            this.lnkdiscount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkdiscount.ImageSize = 50;
            this.lnkdiscount.Location = new System.Drawing.Point(917, 437);
            this.lnkdiscount.Name = "lnkdiscount";
            this.lnkdiscount.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkdiscount.NoFocusImage")));
            this.lnkdiscount.Size = new System.Drawing.Size(69, 66);
            this.lnkdiscount.TabIndex = 15;
            this.lnkdiscount.Text = "Discount";
            this.lnkdiscount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkdiscount.UseSelectable = true;
            this.lnkdiscount.Click += new System.EventHandler(this.lnkdiscount_Click);
            // 
            // lnkpayment
            // 
            this.lnkpayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkpayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkpayment.Enabled = false;
            this.lnkpayment.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkpayment.Image = ((System.Drawing.Image)(resources.GetObject("lnkpayment.Image")));
            this.lnkpayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkpayment.ImageSize = 50;
            this.lnkpayment.Location = new System.Drawing.Point(999, 437);
            this.lnkpayment.Name = "lnkpayment";
            this.lnkpayment.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkpayment.NoFocusImage")));
            this.lnkpayment.Size = new System.Drawing.Size(69, 66);
            this.lnkpayment.TabIndex = 15;
            this.lnkpayment.Text = "Payment";
            this.lnkpayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkpayment.UseSelectable = true;
            this.lnkpayment.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grandtotal);
            this.groupBox1.Controls.Add(this.discountamount);
            this.groupBox1.Controls.Add(this.discountpercent);
            this.groupBox1.Controls.Add(this.vat);
            this.groupBox1.Controls.Add(this.subtotal);
            this.groupBox1.Controls.Add(this.cashier);
            this.groupBox1.Controls.Add(this.labelcashier);
            this.groupBox1.Controls.Add(this.labeldiscountamount);
            this.groupBox1.Controls.Add(this.labelsubtotal);
            this.groupBox1.Controls.Add(this.labelgrandtotal);
            this.groupBox1.Controls.Add(this.labeldiscount);
            this.groupBox1.Controls.Add(this.labelvat);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(672, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 254);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary of Transaction";
            // 
            // grandtotal
            // 
            // 
            // 
            // 
            this.grandtotal.CustomButton.Image = null;
            this.grandtotal.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.grandtotal.CustomButton.Name = "";
            this.grandtotal.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.grandtotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.grandtotal.CustomButton.TabIndex = 1;
            this.grandtotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.grandtotal.CustomButton.UseSelectable = true;
            this.grandtotal.CustomButton.Visible = false;
            this.grandtotal.DisplayIcon = true;
            this.grandtotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.grandtotal.Icon = ((System.Drawing.Image)(resources.GetObject("grandtotal.Icon")));
            this.grandtotal.Lines = new string[0];
            this.grandtotal.Location = new System.Drawing.Point(167, 210);
            this.grandtotal.MaxLength = 32767;
            this.grandtotal.Name = "grandtotal";
            this.grandtotal.PasswordChar = '\0';
            this.grandtotal.ReadOnly = true;
            this.grandtotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grandtotal.SelectedText = "";
            this.grandtotal.SelectionLength = 0;
            this.grandtotal.SelectionStart = 0;
            this.grandtotal.ShortcutsEnabled = true;
            this.grandtotal.ShowClearButton = true;
            this.grandtotal.Size = new System.Drawing.Size(219, 37);
            this.grandtotal.TabIndex = 19;
            this.grandtotal.UseSelectable = true;
            this.grandtotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.grandtotal.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // discountamount
            // 
            // 
            // 
            // 
            this.discountamount.CustomButton.Image = null;
            this.discountamount.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.discountamount.CustomButton.Name = "";
            this.discountamount.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.discountamount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.discountamount.CustomButton.TabIndex = 1;
            this.discountamount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.discountamount.CustomButton.UseSelectable = true;
            this.discountamount.CustomButton.Visible = false;
            this.discountamount.DisplayIcon = true;
            this.discountamount.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.discountamount.Icon = ((System.Drawing.Image)(resources.GetObject("discountamount.Icon")));
            this.discountamount.Lines = new string[0];
            this.discountamount.Location = new System.Drawing.Point(167, 138);
            this.discountamount.MaxLength = 32767;
            this.discountamount.Name = "discountamount";
            this.discountamount.PasswordChar = '\0';
            this.discountamount.ReadOnly = true;
            this.discountamount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.discountamount.SelectedText = "";
            this.discountamount.SelectionLength = 0;
            this.discountamount.SelectionStart = 0;
            this.discountamount.ShortcutsEnabled = true;
            this.discountamount.ShowClearButton = true;
            this.discountamount.Size = new System.Drawing.Size(219, 37);
            this.discountamount.TabIndex = 19;
            this.discountamount.UseSelectable = true;
            this.discountamount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.discountamount.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // discountpercent
            // 
            // 
            // 
            // 
            this.discountpercent.CustomButton.Image = null;
            this.discountpercent.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.discountpercent.CustomButton.Name = "";
            this.discountpercent.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.discountpercent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.discountpercent.CustomButton.TabIndex = 1;
            this.discountpercent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.discountpercent.CustomButton.UseSelectable = true;
            this.discountpercent.CustomButton.Visible = false;
            this.discountpercent.DisplayIcon = true;
            this.discountpercent.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.discountpercent.Icon = ((System.Drawing.Image)(resources.GetObject("discountpercent.Icon")));
            this.discountpercent.Lines = new string[0];
            this.discountpercent.Location = new System.Drawing.Point(167, 102);
            this.discountpercent.MaxLength = 32767;
            this.discountpercent.Name = "discountpercent";
            this.discountpercent.PasswordChar = '\0';
            this.discountpercent.ReadOnly = true;
            this.discountpercent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.discountpercent.SelectedText = "";
            this.discountpercent.SelectionLength = 0;
            this.discountpercent.SelectionStart = 0;
            this.discountpercent.ShortcutsEnabled = true;
            this.discountpercent.ShowClearButton = true;
            this.discountpercent.Size = new System.Drawing.Size(219, 37);
            this.discountpercent.TabIndex = 19;
            this.discountpercent.UseSelectable = true;
            this.discountpercent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.discountpercent.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountpercent.TextChanged += new System.EventHandler(this.discountpercent_TextChanged);
            // 
            // vat
            // 
            // 
            // 
            // 
            this.vat.CustomButton.Image = null;
            this.vat.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.vat.CustomButton.Name = "";
            this.vat.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.vat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.vat.CustomButton.TabIndex = 1;
            this.vat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.vat.CustomButton.UseSelectable = true;
            this.vat.CustomButton.Visible = false;
            this.vat.DisplayIcon = true;
            this.vat.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.vat.Icon = ((System.Drawing.Image)(resources.GetObject("vat.Icon")));
            this.vat.Lines = new string[0];
            this.vat.Location = new System.Drawing.Point(167, 174);
            this.vat.MaxLength = 32767;
            this.vat.Name = "vat";
            this.vat.PasswordChar = '\0';
            this.vat.ReadOnly = true;
            this.vat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vat.SelectedText = "";
            this.vat.SelectionLength = 0;
            this.vat.SelectionStart = 0;
            this.vat.ShortcutsEnabled = true;
            this.vat.ShowClearButton = true;
            this.vat.Size = new System.Drawing.Size(219, 37);
            this.vat.TabIndex = 19;
            this.vat.UseSelectable = true;
            this.vat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.vat.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // subtotal
            // 
            // 
            // 
            // 
            this.subtotal.CustomButton.Image = null;
            this.subtotal.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.subtotal.CustomButton.Name = "";
            this.subtotal.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.subtotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subtotal.CustomButton.TabIndex = 1;
            this.subtotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subtotal.CustomButton.UseSelectable = true;
            this.subtotal.CustomButton.Visible = false;
            this.subtotal.DisplayIcon = true;
            this.subtotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.subtotal.Icon = ((System.Drawing.Image)(resources.GetObject("subtotal.Icon")));
            this.subtotal.Lines = new string[0];
            this.subtotal.Location = new System.Drawing.Point(167, 66);
            this.subtotal.MaxLength = 32767;
            this.subtotal.Name = "subtotal";
            this.subtotal.PasswordChar = '\0';
            this.subtotal.ReadOnly = true;
            this.subtotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subtotal.SelectedText = "";
            this.subtotal.SelectionLength = 0;
            this.subtotal.SelectionStart = 0;
            this.subtotal.ShortcutsEnabled = true;
            this.subtotal.ShowClearButton = true;
            this.subtotal.Size = new System.Drawing.Size(219, 37);
            this.subtotal.TabIndex = 19;
            this.subtotal.UseSelectable = true;
            this.subtotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subtotal.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cashier
            // 
            // 
            // 
            // 
            this.cashier.CustomButton.Image = null;
            this.cashier.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.cashier.CustomButton.Name = "";
            this.cashier.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.cashier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cashier.CustomButton.TabIndex = 1;
            this.cashier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cashier.CustomButton.UseSelectable = true;
            this.cashier.CustomButton.Visible = false;
            this.cashier.DisplayIcon = true;
            this.cashier.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.cashier.Icon = ((System.Drawing.Image)(resources.GetObject("cashier.Icon")));
            this.cashier.Lines = new string[0];
            this.cashier.Location = new System.Drawing.Point(167, 30);
            this.cashier.MaxLength = 32767;
            this.cashier.Name = "cashier";
            this.cashier.PasswordChar = '\0';
            this.cashier.ReadOnly = true;
            this.cashier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cashier.SelectedText = "";
            this.cashier.SelectionLength = 0;
            this.cashier.SelectionStart = 0;
            this.cashier.ShortcutsEnabled = true;
            this.cashier.ShowClearButton = true;
            this.cashier.Size = new System.Drawing.Size(219, 37);
            this.cashier.TabIndex = 19;
            this.cashier.UseSelectable = true;
            this.cashier.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cashier.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelcashier
            // 
            this.labelcashier.AutoSize = true;
            this.labelcashier.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcashier.Location = new System.Drawing.Point(3, 40);
            this.labelcashier.Name = "labelcashier";
            this.labelcashier.Size = new System.Drawing.Size(71, 22);
            this.labelcashier.TabIndex = 9;
            this.labelcashier.Text = "Cashier:";
            // 
            // labeldiscountamount
            // 
            this.labeldiscountamount.AutoSize = true;
            this.labeldiscountamount.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldiscountamount.Location = new System.Drawing.Point(3, 144);
            this.labeldiscountamount.Name = "labeldiscountamount";
            this.labeldiscountamount.Size = new System.Drawing.Size(167, 22);
            this.labeldiscountamount.TabIndex = 10;
            this.labeldiscountamount.Text = "Discounted Amount:";
            // 
            // labelsubtotal
            // 
            this.labelsubtotal.AutoSize = true;
            this.labelsubtotal.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsubtotal.Location = new System.Drawing.Point(3, 73);
            this.labelsubtotal.Name = "labelsubtotal";
            this.labelsubtotal.Size = new System.Drawing.Size(85, 22);
            this.labelsubtotal.TabIndex = 10;
            this.labelsubtotal.Text = "Sub Total:";
            // 
            // labelgrandtotal
            // 
            this.labelgrandtotal.AutoSize = true;
            this.labelgrandtotal.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgrandtotal.Location = new System.Drawing.Point(3, 217);
            this.labelgrandtotal.Name = "labelgrandtotal";
            this.labelgrandtotal.Size = new System.Drawing.Size(104, 22);
            this.labelgrandtotal.TabIndex = 10;
            this.labelgrandtotal.Text = "Grand Total:";
            // 
            // labeldiscount
            // 
            this.labeldiscount.AutoSize = true;
            this.labeldiscount.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldiscount.Location = new System.Drawing.Point(3, 109);
            this.labeldiscount.Name = "labeldiscount";
            this.labeldiscount.Size = new System.Drawing.Size(100, 22);
            this.labeldiscount.TabIndex = 10;
            this.labeldiscount.Text = "Discount %:";
            // 
            // labelvat
            // 
            this.labelvat.AutoSize = true;
            this.labelvat.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvat.Location = new System.Drawing.Point(3, 181);
            this.labelvat.Name = "labelvat";
            this.labelvat.Size = new System.Drawing.Size(0, 22);
            this.labelvat.TabIndex = 10;
            this.labelvat.TextChanged += new System.EventHandler(this.labelvat_TextChanged);
            // 
            // manualpanel
            // 
            this.manualpanel.Controls.Add(this.lnkeditqty2);
            this.manualpanel.Controls.Add(this.txtquantity);
            this.manualpanel.Controls.Add(this.combobxproduct);
            this.manualpanel.Controls.Add(this.labelproductname);
            this.manualpanel.Controls.Add(this.lnkaddorder);
            this.manualpanel.Controls.Add(this.labelquantity);
            this.manualpanel.Location = new System.Drawing.Point(672, 35);
            this.manualpanel.Name = "manualpanel";
            this.manualpanel.Size = new System.Drawing.Size(294, 136);
            this.manualpanel.TabIndex = 12;
            this.manualpanel.Visible = false;
            // 
            // lnkeditqty2
            // 
            this.lnkeditqty2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkeditqty2.Enabled = false;
            this.lnkeditqty2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkeditqty2.Image = ((System.Drawing.Image)(resources.GetObject("lnkeditqty2.Image")));
            this.lnkeditqty2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkeditqty2.ImageSize = 50;
            this.lnkeditqty2.Location = new System.Drawing.Point(219, 62);
            this.lnkeditqty2.Name = "lnkeditqty2";
            this.lnkeditqty2.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkeditqty2.NoFocusImage")));
            this.lnkeditqty2.Size = new System.Drawing.Size(68, 66);
            this.lnkeditqty2.TabIndex = 16;
            this.lnkeditqty2.Text = "Edit Qty";
            this.lnkeditqty2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkeditqty2.UseSelectable = true;
            this.lnkeditqty2.Click += new System.EventHandler(this.lnkeditqty2_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(8, 87);
            this.txtquantity.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(104, 29);
            this.txtquantity.TabIndex = 14;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // combobxproduct
            // 
            this.combobxproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combobxproduct.FormattingEnabled = true;
            this.combobxproduct.ItemHeight = 23;
            this.combobxproduct.Location = new System.Drawing.Point(8, 30);
            this.combobxproduct.Name = "combobxproduct";
            this.combobxproduct.Size = new System.Drawing.Size(186, 29);
            this.combobxproduct.TabIndex = 3;
            this.combobxproduct.UseSelectable = true;
            // 
            // labelproductname
            // 
            this.labelproductname.AutoSize = true;
            this.labelproductname.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductname.Location = new System.Drawing.Point(4, 5);
            this.labelproductname.Name = "labelproductname";
            this.labelproductname.Size = new System.Drawing.Size(71, 22);
            this.labelproductname.TabIndex = 8;
            this.labelproductname.Text = "Product";
            // 
            // lnkaddorder
            // 
            this.lnkaddorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkaddorder.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkaddorder.Image = ((System.Drawing.Image)(resources.GetObject("lnkaddorder.Image")));
            this.lnkaddorder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkaddorder.ImageSize = 50;
            this.lnkaddorder.Location = new System.Drawing.Point(130, 62);
            this.lnkaddorder.Name = "lnkaddorder";
            this.lnkaddorder.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkaddorder.NoFocusImage")));
            this.lnkaddorder.Size = new System.Drawing.Size(83, 66);
            this.lnkaddorder.TabIndex = 9;
            this.lnkaddorder.Text = "Add Order";
            this.lnkaddorder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkaddorder.UseSelectable = true;
            this.lnkaddorder.Click += new System.EventHandler(this.lnkaddorder_Click);
            // 
            // labelquantity
            // 
            this.labelquantity.AutoSize = true;
            this.labelquantity.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelquantity.Location = new System.Drawing.Point(4, 62);
            this.labelquantity.Name = "labelquantity";
            this.labelquantity.Size = new System.Drawing.Size(77, 22);
            this.labelquantity.TabIndex = 8;
            this.labelquantity.Text = "Quantity";
            // 
            // bctoggle
            // 
            this.bctoggle.AutoSize = true;
            this.bctoggle.Checked = true;
            this.bctoggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bctoggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bctoggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.bctoggle.Location = new System.Drawing.Point(778, 12);
            this.bctoggle.Name = "bctoggle";
            this.bctoggle.Size = new System.Drawing.Size(80, 17);
            this.bctoggle.TabIndex = 10;
            this.bctoggle.Text = "On";
            this.bctoggle.UseSelectable = true;
            this.bctoggle.CheckedChanged += new System.EventHandler(this.bctoggle_CheckedChanged);
            // 
            // txtautobc
            // 
            this.txtautobc.Location = new System.Drawing.Point(550, 10);
            this.txtautobc.Name = "txtautobc";
            this.txtautobc.Size = new System.Drawing.Size(100, 20);
            this.txtautobc.TabIndex = 5;
            this.txtautobc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown_1);
            // 
            // transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.transactionpanel);
            this.Name = "transaction";
            this.Size = new System.Drawing.Size(1085, 518);
            this.Load += new System.EventHandler(this.transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionstylemanager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtransaction)).EndInit();
            this.transactionpanel.ResumeLayout(false);
            this.transactionpanel.PerformLayout();
            this.autopanel.ResumeLayout(false);
            this.autopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmodifyquantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.manualpanel.ResumeLayout(false);
            this.manualpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Components.MetroStyleManager transactionstylemanager;
        public System.Windows.Forms.Panel transactionpanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelcashier;
        private System.Windows.Forms.Label labelgrandtotal;
        private System.Windows.Forms.Label labelsubtotal;
        private MetroFramework.Controls.MetroLink lnkpayment;
        public MetroFramework.Controls.MetroGrid dgtransaction;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroToggle bctoggle;
        private System.Windows.Forms.Panel autopanel;
        private System.Windows.Forms.NumericUpDown txtmodifyquantity;
        private MetroFramework.Controls.MetroLink lnkeditqty1;
        private System.Windows.Forms.Panel manualpanel;
        private MetroFramework.Controls.MetroLink lnkeditqty2;
        private System.Windows.Forms.NumericUpDown txtquantity;
        private MetroFramework.Controls.MetroComboBox combobxproduct;
        private System.Windows.Forms.Label labelproductname;
        private MetroFramework.Controls.MetroLink lnkaddorder;
        private System.Windows.Forms.Label labelquantity;
        private MetroFramework.Controls.MetroLink lnkdiscount;
        private System.Windows.Forms.Label labeldiscount;
        public MetroFramework.Controls.MetroTextBox grandtotal;
        public MetroFramework.Controls.MetroTextBox vat;
        public MetroFramework.Controls.MetroTextBox discountpercent;
        public MetroFramework.Controls.MetroTextBox subtotal;
        public MetroFramework.Controls.MetroTextBox cashier;
        public MetroFramework.Controls.MetroTextBox discountamount;
        private System.Windows.Forms.Label labeldiscountamount;
        public System.Windows.Forms.Label labelvat;
        private MetroFramework.Controls.MetroLink lnkvoid;
        public System.Windows.Forms.TextBox txtautobc;
        private System.Windows.Forms.Label label1;
        public MetroFramework.Controls.MetroLink lnkfocusbc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
