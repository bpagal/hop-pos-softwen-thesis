namespace Softwen.Products
{
    partial class products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(products));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hOPDateSet = new Softwen.HOPDateSet();
            this.productsTableAdapter = new Softwen.HOPDateSetTableAdapters.productsTableAdapter();
            this.productstylemanager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lnkedit = new MetroFramework.Controls.MetroLink();
            this.lnkaddstock = new MetroFramework.Controls.MetroLink();
            this.lnkdelete = new MetroFramework.Controls.MetroLink();
            this.lnkadd = new MetroFramework.Controls.MetroLink();
            this.dgproducts = new MetroFramework.Controls.MetroGrid();
            this.producttabcontrol = new MetroFramework.Controls.MetroTabControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hOPDateSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstylemanager)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgproducts)).BeginInit();
            this.producttabcontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hOPDateSet
            // 
            this.hOPDateSet.DataSetName = "HOPDateSet";
            this.hOPDateSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productstylemanager
            // 
            this.productstylemanager.Owner = this;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lnkedit);
            this.metroTabPage1.Controls.Add(this.lnkaddstock);
            this.metroTabPage1.Controls.Add(this.lnkdelete);
            this.metroTabPage1.Controls.Add(this.lnkadd);
            this.metroTabPage1.Controls.Add(this.dgproducts);
            this.metroTabPage1.HorizontalScrollbarBarColor = false;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 20;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(854, 395);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Products";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // lnkedit
            // 
            this.lnkedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkedit.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkedit.Image = ((System.Drawing.Image)(resources.GetObject("lnkedit.Image")));
            this.lnkedit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkedit.ImageSize = 50;
            this.lnkedit.Location = new System.Drawing.Point(55, 89);
            this.lnkedit.Name = "lnkedit";
            this.lnkedit.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkedit.NoFocusImage")));
            this.lnkedit.Size = new System.Drawing.Size(117, 66);
            this.lnkedit.TabIndex = 6;
            this.lnkedit.Text = "Modify Product";
            this.lnkedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkedit.UseSelectable = true;
            this.lnkedit.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // lnkaddstock
            // 
            this.lnkaddstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkaddstock.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkaddstock.Image = ((System.Drawing.Image)(resources.GetObject("lnkaddstock.Image")));
            this.lnkaddstock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkaddstock.ImageSize = 50;
            this.lnkaddstock.Location = new System.Drawing.Point(55, 243);
            this.lnkaddstock.Name = "lnkaddstock";
            this.lnkaddstock.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkaddstock.NoFocusImage")));
            this.lnkaddstock.Size = new System.Drawing.Size(109, 66);
            this.lnkaddstock.TabIndex = 6;
            this.lnkaddstock.Text = "Add Stocks";
            this.lnkaddstock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkaddstock.UseSelectable = true;
            this.lnkaddstock.Click += new System.EventHandler(this.lnkaddstock_Click);
            // 
            // lnkdelete
            // 
            this.lnkdelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkdelete.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkdelete.Image = ((System.Drawing.Image)(resources.GetObject("lnkdelete.Image")));
            this.lnkdelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkdelete.ImageSize = 50;
            this.lnkdelete.Location = new System.Drawing.Point(55, 161);
            this.lnkdelete.Name = "lnkdelete";
            this.lnkdelete.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkdelete.NoFocusImage")));
            this.lnkdelete.Size = new System.Drawing.Size(109, 66);
            this.lnkdelete.TabIndex = 6;
            this.lnkdelete.Text = "Delete Product";
            this.lnkdelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkdelete.UseSelectable = true;
            this.lnkdelete.Click += new System.EventHandler(this.lnkdelete_Click);
            // 
            // lnkadd
            // 
            this.lnkadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkadd.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkadd.Image = ((System.Drawing.Image)(resources.GetObject("lnkadd.Image")));
            this.lnkadd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkadd.ImageSize = 50;
            this.lnkadd.Location = new System.Drawing.Point(64, 17);
            this.lnkadd.Name = "lnkadd";
            this.lnkadd.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkadd.NoFocusImage")));
            this.lnkadd.Size = new System.Drawing.Size(95, 66);
            this.lnkadd.TabIndex = 6;
            this.lnkadd.Text = "Add Product";
            this.lnkadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkadd.UseSelectable = true;
            this.lnkadd.Click += new System.EventHandler(this.lnkadd_Click);
            // 
            // dgproducts
            // 
            this.dgproducts.AllowUserToAddRows = false;
            this.dgproducts.AllowUserToDeleteRows = false;
            this.dgproducts.AllowUserToResizeColumns = false;
            this.dgproducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dgproducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgproducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgproducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgproducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgproducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgproducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgproducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgproducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgproducts.EnableHeadersVisualStyles = false;
            this.dgproducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgproducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgproducts.Location = new System.Drawing.Point(192, 14);
            this.dgproducts.Name = "dgproducts";
            this.dgproducts.ReadOnly = true;
            this.dgproducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgproducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgproducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgproducts.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgproducts.Size = new System.Drawing.Size(659, 359);
            this.dgproducts.TabIndex = 5;
            // 
            // producttabcontrol
            // 
            this.producttabcontrol.Controls.Add(this.metroTabPage1);
            this.producttabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.producttabcontrol.Location = new System.Drawing.Point(0, 0);
            this.producttabcontrol.Name = "producttabcontrol";
            this.producttabcontrol.SelectedIndex = 0;
            this.producttabcontrol.Size = new System.Drawing.Size(862, 437);
            this.producttabcontrol.TabIndex = 0;
            this.producttabcontrol.UseSelectable = true;
            this.producttabcontrol.Visible = false;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.hOPDateSet;
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
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "barcode";
            this.barcodeDataGridViewTextBoxColumn.FillWeight = 150F;
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.barcodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "productname";
            this.productnameDataGridViewTextBoxColumn.FillWeight = 160F;
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productnameDataGridViewTextBoxColumn.Width = 160;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "productid";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.producttabcontrol);
            this.Name = "products";
            this.Size = new System.Drawing.Size(862, 437);
            ((System.ComponentModel.ISupportInitialize)(this.hOPDateSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstylemanager)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgproducts)).EndInit();
            this.producttabcontrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HOPDateSet hOPDateSet;
        private HOPDateSetTableAdapters.productsTableAdapter productsTableAdapter;
        public MetroFramework.Components.MetroStyleManager productstylemanager;
        public MetroFramework.Controls.MetroTabControl producttabcontrol;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLink lnkedit;
        private MetroFramework.Controls.MetroLink lnkaddstock;
        private MetroFramework.Controls.MetroLink lnkdelete;
        private MetroFramework.Controls.MetroLink lnkadd;
        private MetroFramework.Controls.MetroGrid dgproducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productsBindingSource;
    }
}
