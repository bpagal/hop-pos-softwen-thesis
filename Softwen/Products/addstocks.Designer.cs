namespace Softwen.Products
{
    partial class addstocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addstocks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lnkcomplete = new MetroFramework.Controls.MetroLink();
            this.dgrestock = new MetroFramework.Controls.MetroGrid();
            this.lnkadd = new MetroFramework.Controls.MetroLink();
            this.txtquantity = new System.Windows.Forms.NumericUpDown();
            this.labelquantity = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrestock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkcomplete
            // 
            this.lnkcomplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkcomplete.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkcomplete.Image = ((System.Drawing.Image)(resources.GetObject("lnkcomplete.Image")));
            this.lnkcomplete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkcomplete.ImageSize = 50;
            this.lnkcomplete.Location = new System.Drawing.Point(445, 323);
            this.lnkcomplete.Name = "lnkcomplete";
            this.lnkcomplete.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkcomplete.NoFocusImage")));
            this.lnkcomplete.Size = new System.Drawing.Size(50, 66);
            this.lnkcomplete.TabIndex = 37;
            this.lnkcomplete.Text = "Add";
            this.lnkcomplete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkcomplete.UseSelectable = true;
            this.lnkcomplete.Click += new System.EventHandler(this.lnkcomplete_Click);
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
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
            this.dgrestock.Location = new System.Drawing.Point(20, 63);
            this.dgrestock.MultiSelect = false;
            this.dgrestock.Name = "dgrestock";
            this.dgrestock.ReadOnly = true;
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
            this.dgrestock.Size = new System.Drawing.Size(475, 250);
            this.dgrestock.TabIndex = 38;
            this.dgrestock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrestock_CellClick);
            this.dgrestock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrestock_CellContentClick_1);
            // 
            // lnkadd
            // 
            this.lnkadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkadd.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkadd.Image = ((System.Drawing.Image)(resources.GetObject("lnkadd.Image")));
            this.lnkadd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkadd.ImageSize = 50;
            this.lnkadd.Location = new System.Drawing.Point(326, 323);
            this.lnkadd.Name = "lnkadd";
            this.lnkadd.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkadd.NoFocusImage")));
            this.lnkadd.Size = new System.Drawing.Size(113, 66);
            this.lnkadd.TabIndex = 41;
            this.lnkadd.Text = "Save/Edit Qty";
            this.lnkadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkadd.UseSelectable = true;
            this.lnkadd.Click += new System.EventHandler(this.lnkadd_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(117, 360);
            this.txtquantity.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(104, 29);
            this.txtquantity.TabIndex = 39;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquantity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // labelquantity
            // 
            this.labelquantity.AutoSize = true;
            this.labelquantity.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelquantity.Location = new System.Drawing.Point(111, 329);
            this.labelquantity.Name = "labelquantity";
            this.labelquantity.Size = new System.Drawing.Size(0, 22);
            this.labelquantity.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 94;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Qty";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 61;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ordered Qty";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 50;
            // 
            // Column4
            // 
            dataGridViewCellStyle9.NullValue = "Not Specified";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column4.HeaderText = "Delivered Qty";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 138;
            // 
            // addstocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 454);
            this.Controls.Add(this.lnkadd);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.labelquantity);
            this.Controls.Add(this.dgrestock);
            this.Controls.Add(this.lnkcomplete);
            this.MaximizeBox = false;
            this.Name = "addstocks";
            this.Resizable = false;
            this.Text = "Increase Stocks";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.addstocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrestock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroLink lnkcomplete;
        public MetroFramework.Controls.MetroGrid dgrestock;
        private MetroFramework.Controls.MetroLink lnkadd;
        public System.Windows.Forms.NumericUpDown txtquantity;
        private System.Windows.Forms.Label labelquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}