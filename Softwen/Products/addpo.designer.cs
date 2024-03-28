namespace Softwen.Products
{
    partial class addpo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addpo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgrestock = new MetroFramework.Controls.MetroGrid();
            this.panelrestock = new System.Windows.Forms.Panel();
            this.txtproductname = new MetroFramework.Controls.MetroTextBox();
            this.lnkadd = new MetroFramework.Controls.MetroLink();
            this.txtquantity = new System.Windows.Forms.NumericUpDown();
            this.labelproductname = new System.Windows.Forms.Label();
            this.labelquantity = new System.Windows.Forms.Label();
            this.lnksave = new MetroFramework.Controls.MetroLink();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrestock)).BeginInit();
            this.panelrestock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrestock
            // 
            this.dgrestock.AllowUserToAddRows = false;
            this.dgrestock.AllowUserToDeleteRows = false;
            this.dgrestock.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            this.dgrestock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgrestock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrestock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgrestock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrestock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgrestock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrestock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgrestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrestock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.Column2,
            this.Column1,
            this.Column3});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrestock.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgrestock.EnableHeadersVisualStyles = false;
            this.dgrestock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgrestock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgrestock.Location = new System.Drawing.Point(9, 134);
            this.dgrestock.MultiSelect = false;
            this.dgrestock.Name = "dgrestock";
            this.dgrestock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgrestock.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgrestock.RowHeadersWidth = 45;
            this.dgrestock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgrestock.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgrestock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrestock.Size = new System.Drawing.Size(688, 331);
            this.dgrestock.TabIndex = 26;
            this.dgrestock.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgrestock_RowsAdded);
            this.dgrestock.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgrestock_RowsRemoved);
            // 
            // panelrestock
            // 
            this.panelrestock.Controls.Add(this.txtproductname);
            this.panelrestock.Controls.Add(this.lnkadd);
            this.panelrestock.Controls.Add(this.txtquantity);
            this.panelrestock.Controls.Add(this.labelproductname);
            this.panelrestock.Controls.Add(this.labelquantity);
            this.panelrestock.Location = new System.Drawing.Point(83, 55);
            this.panelrestock.Name = "panelrestock";
            this.panelrestock.Size = new System.Drawing.Size(434, 73);
            this.panelrestock.TabIndex = 36;
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
            this.txtproductname.Location = new System.Drawing.Point(11, 28);
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
            this.txtproductname.TabIndex = 35;
            this.txtproductname.UseSelectable = true;
            this.txtproductname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtproductname.WaterMarkFont = new System.Drawing.Font("Open Sans Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lnkadd
            // 
            this.lnkadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkadd.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkadd.Image = ((System.Drawing.Image)(resources.GetObject("lnkadd.Image")));
            this.lnkadd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkadd.ImageSize = 50;
            this.lnkadd.Location = new System.Drawing.Point(352, 5);
            this.lnkadd.Name = "lnkadd";
            this.lnkadd.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkadd.NoFocusImage")));
            this.lnkadd.Size = new System.Drawing.Size(70, 66);
            this.lnkadd.TabIndex = 33;
            this.lnkadd.Text = "Edit Qty";
            this.lnkadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkadd.UseSelectable = true;
            this.lnkadd.Visible = false;
            this.lnkadd.Click += new System.EventHandler(this.lnkadd_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(237, 36);
            this.txtquantity.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(104, 29);
            this.txtquantity.TabIndex = 0;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquantity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtquantity.Visible = false;
            // 
            // labelproductname
            // 
            this.labelproductname.AutoSize = true;
            this.labelproductname.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductname.Location = new System.Drawing.Point(7, 5);
            this.labelproductname.Name = "labelproductname";
            this.labelproductname.Size = new System.Drawing.Size(71, 22);
            this.labelproductname.TabIndex = 16;
            this.labelproductname.Text = "Product";
            // 
            // labelquantity
            // 
            this.labelquantity.AutoSize = true;
            this.labelquantity.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelquantity.Location = new System.Drawing.Point(231, 5);
            this.labelquantity.Name = "labelquantity";
            this.labelquantity.Size = new System.Drawing.Size(77, 22);
            this.labelquantity.TabIndex = 17;
            this.labelquantity.Text = "Quantity";
            this.labelquantity.Visible = false;
            // 
            // lnksave
            // 
            this.lnksave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnksave.Enabled = false;
            this.lnksave.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnksave.Image = ((System.Drawing.Image)(resources.GetObject("lnksave.Image")));
            this.lnksave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnksave.ImageSize = 50;
            this.lnksave.Location = new System.Drawing.Point(523, 60);
            this.lnksave.Name = "lnksave";
            this.lnksave.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnksave.NoFocusImage")));
            this.lnksave.Size = new System.Drawing.Size(48, 66);
            this.lnksave.TabIndex = 34;
            this.lnksave.Text = "Save";
            this.lnksave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnksave.UseSelectable = true;
            this.lnksave.Click += new System.EventHandler(this.lnksave_Click);
            // 
            // Column4
            // 
            this.Column4.FalseValue = "";
            this.Column4.HeaderText = "Select";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 78;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "productid";
            this.productidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            this.productidDataGridViewTextBoxColumn.Width = 50;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "productname";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productnameDataGridViewTextBoxColumn.Width = 94;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "quantity";
            this.Column2.HeaderText = "Current Qty";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 124;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maxquantity";
            this.Column1.HeaderText = "Max Qty";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 98;
            // 
            // Column3
            // 
            dataGridViewCellStyle9.NullValue = "Not Specified";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column3.HeaderText = "Qty After Restock";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 168;
            // 
            // addpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 472);
            this.Controls.Add(this.panelrestock);
            this.Controls.Add(this.lnksave);
            this.Controls.Add(this.dgrestock);
            this.MaximizeBox = false;
            this.Name = "addpo";
            this.Resizable = false;
            this.Text = "Add Purchase Order";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.restock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrestock)).EndInit();
            this.panelrestock.ResumeLayout(false);
            this.panelrestock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Controls.MetroGrid dgrestock;
        private System.Windows.Forms.Panel panelrestock;
        public MetroFramework.Controls.MetroLink lnksave;
        private MetroFramework.Controls.MetroLink lnkadd;
        public System.Windows.Forms.NumericUpDown txtquantity;
        private System.Windows.Forms.Label labelproductname;
        private System.Windows.Forms.Label labelquantity;
        public MetroFramework.Controls.MetroTextBox txtproductname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}