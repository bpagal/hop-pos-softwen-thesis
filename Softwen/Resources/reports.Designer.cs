namespace Softwen.Reports
{
    partial class reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reportstabcontrol = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.chball = new MetroFramework.Controls.MetroCheckBox();
            this.dgdailysales = new MetroFramework.Controls.MetroGrid();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailysalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOPDateSet = new Softwen.HOPDateSet();
            this.combobxcashier = new MetroFramework.Controls.MetroComboBox();
            this.labelproductname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtdaily = new MetroFramework.Controls.MetroDateTime();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.dtto = new MetroFramework.Controls.MetroDateTime();
            this.dtfrom = new MetroFramework.Controls.MetroDateTime();
            this.reportsstylemanager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.dailysalesTableAdapter = new Softwen.HOPDateSetTableAdapters.dailysalesTableAdapter();
            this.reportstabcontrol.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdailysales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailysalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDateSet)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsstylemanager)).BeginInit();
            this.SuspendLayout();
            // 
            // reportstabcontrol
            // 
            this.reportstabcontrol.Controls.Add(this.metroTabPage1);
            this.reportstabcontrol.Controls.Add(this.metroTabPage2);
            this.reportstabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportstabcontrol.Location = new System.Drawing.Point(0, 0);
            this.reportstabcontrol.Name = "reportstabcontrol";
            this.reportstabcontrol.SelectedIndex = 0;
            this.reportstabcontrol.Size = new System.Drawing.Size(862, 437);
            this.reportstabcontrol.TabIndex = 0;
            this.reportstabcontrol.UseSelectable = true;
            this.reportstabcontrol.Visible = false;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.AutoScroll = true;
            this.metroTabPage1.Controls.Add(this.chball);
            this.metroTabPage1.Controls.Add(this.dgdailysales);
            this.metroTabPage1.Controls.Add(this.combobxcashier);
            this.metroTabPage1.Controls.Add(this.labelproductname);
            this.metroTabPage1.Controls.Add(this.button1);
            this.metroTabPage1.Controls.Add(this.dtdaily);
            this.metroTabPage1.HorizontalScrollbar = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(854, 395);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Daily Sales";
            this.metroTabPage1.VerticalScrollbar = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // chball
            // 
            this.chball.AutoSize = true;
            this.chball.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chball.Location = new System.Drawing.Point(586, 18);
            this.chball.Name = "chball";
            this.chball.Size = new System.Drawing.Size(48, 25);
            this.chball.TabIndex = 12;
            this.chball.Text = "All";
            this.chball.UseSelectable = true;
            this.chball.CheckedChanged += new System.EventHandler(this.chball_CheckedChanged);
            // 
            // dgdailysales
            // 
            this.dgdailysales.AllowUserToAddRows = false;
            this.dgdailysales.AllowUserToDeleteRows = false;
            this.dgdailysales.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgdailysales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdailysales.AutoGenerateColumns = false;
            this.dgdailysales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgdailysales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdailysales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgdailysales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgdailysales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgdailysales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdailysales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullname,
            this.productnameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgdailysales.DataSource = this.dailysalesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgdailysales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgdailysales.EnableHeadersVisualStyles = false;
            this.dgdailysales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgdailysales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgdailysales.Location = new System.Drawing.Point(100, 52);
            this.dgdailysales.Name = "dgdailysales";
            this.dgdailysales.ReadOnly = true;
            this.dgdailysales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdailysales.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgdailysales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgdailysales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdailysales.Size = new System.Drawing.Size(447, 319);
            this.dgdailysales.TabIndex = 11;
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Cashier";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "productname";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dailysalesBindingSource
            // 
            this.dailysalesBindingSource.DataMember = "dailysales";
            this.dailysalesBindingSource.DataSource = this.hOPDateSet;
            // 
            // hOPDateSet
            // 
            this.hOPDateSet.DataSetName = "HOPDateSet";
            this.hOPDateSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combobxcashier
            // 
            this.combobxcashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combobxcashier.FormattingEnabled = true;
            this.combobxcashier.ItemHeight = 23;
            this.combobxcashier.Location = new System.Drawing.Point(393, 17);
            this.combobxcashier.Name = "combobxcashier";
            this.combobxcashier.Size = new System.Drawing.Size(174, 29);
            this.combobxcashier.TabIndex = 9;
            this.combobxcashier.UseSelectable = true;
            this.combobxcashier.SelectedIndexChanged += new System.EventHandler(this.combobxcashier_SelectedIndexChanged);
            // 
            // labelproductname
            // 
            this.labelproductname.AutoSize = true;
            this.labelproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductname.Location = new System.Drawing.Point(312, 21);
            this.labelproductname.Name = "labelproductname";
            this.labelproductname.Size = new System.Drawing.Size(75, 20);
            this.labelproductname.TabIndex = 10;
            this.labelproductname.Text = "Cashier:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtdaily
            // 
            this.dtdaily.Checked = false;
            this.dtdaily.Location = new System.Drawing.Point(74, 17);
            this.dtdaily.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtdaily.Name = "dtdaily";
            this.dtdaily.Size = new System.Drawing.Size(210, 29);
            this.dtdaily.TabIndex = 2;
            this.dtdaily.ValueChanged += new System.EventHandler(this.dtdaily_ValueChanged);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroGrid1);
            this.metroTabPage2.Controls.Add(this.metroComboBox1);
            this.metroTabPage2.Controls.Add(this.dtto);
            this.metroTabPage2.Controls.Add(this.dtfrom);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(854, 395);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Monthly Sales";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.metroGrid1.DataSource = this.dailysalesBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(78, 73);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(447, 319);
            this.metroGrid1.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fullname";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cashier";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "productname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(578, 27);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(174, 29);
            this.metroComboBox1.TabIndex = 13;
            this.metroComboBox1.UseSelectable = true;
            // 
            // dtto
            // 
            this.dtto.Checked = false;
            this.dtto.Location = new System.Drawing.Point(315, 20);
            this.dtto.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtto.Name = "dtto";
            this.dtto.Size = new System.Drawing.Size(210, 29);
            this.dtto.TabIndex = 12;
            // 
            // dtfrom
            // 
            this.dtfrom.Checked = false;
            this.dtfrom.Location = new System.Drawing.Point(78, 20);
            this.dtfrom.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(210, 29);
            this.dtfrom.TabIndex = 12;
            // 
            // reportsstylemanager
            // 
            this.reportsstylemanager.Owner = this;
            // 
            // dailysalesTableAdapter
            // 
            this.dailysalesTableAdapter.ClearBeforeFill = true;
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportstabcontrol);
            this.Name = "reports";
            this.Size = new System.Drawing.Size(862, 437);
            this.reportstabcontrol.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdailysales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailysalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDateSet)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsstylemanager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        public MetroFramework.Components.MetroStyleManager reportsstylemanager;
        public MetroFramework.Controls.MetroTabControl reportstabcontrol;
        private System.Windows.Forms.Button button1;
        public MetroFramework.Controls.MetroDateTime dtdaily;
        private MetroFramework.Controls.MetroComboBox combobxcashier;
        private System.Windows.Forms.Label labelproductname;
        private MetroFramework.Controls.MetroGrid dgdailysales;
        private System.Windows.Forms.BindingSource dailysalesBindingSource;
        private HOPDateSet hOPDateSet;
        private HOPDateSetTableAdapters.dailysalesTableAdapter dailysalesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        public MetroFramework.Controls.MetroDateTime dtto;
        public MetroFramework.Controls.MetroDateTime dtfrom;
        private MetroFramework.Controls.MetroCheckBox chball;
    }
}
