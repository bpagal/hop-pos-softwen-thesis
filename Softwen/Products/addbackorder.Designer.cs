namespace Softwen.Products
{
    partial class addbackorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addbackorder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lnkadd = new MetroFramework.Controls.MetroLink();
            this.txtquantity = new System.Windows.Forms.NumericUpDown();
            this.dgrestockbo = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkcomplete = new MetroFramework.Controls.MetroLink();
            this.labelquantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrestockbo)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkadd
            // 
            this.lnkadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkadd.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkadd.Image = ((System.Drawing.Image)(resources.GetObject("lnkadd.Image")));
            this.lnkadd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkadd.ImageSize = 50;
            this.lnkadd.Location = new System.Drawing.Point(503, 317);
            this.lnkadd.Name = "lnkadd";
            this.lnkadd.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkadd.NoFocusImage")));
            this.lnkadd.Size = new System.Drawing.Size(113, 66);
            this.lnkadd.TabIndex = 45;
            this.lnkadd.Text = "Save/Edit Qty";
            this.lnkadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkadd.UseSelectable = true;
            this.lnkadd.Click += new System.EventHandler(this.lnkadd_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(183, 319);
            this.txtquantity.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(104, 29);
            this.txtquantity.TabIndex = 44;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquantity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // dgrestockbo
            // 
            this.dgrestockbo.AllowUserToAddRows = false;
            this.dgrestockbo.AllowUserToDeleteRows = false;
            this.dgrestockbo.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.LightGray;
            this.dgrestockbo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgrestockbo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrestockbo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgrestockbo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgrestockbo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrestockbo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgrestockbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrestockbo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column5,
            this.Column4});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrestockbo.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgrestockbo.EnableHeadersVisualStyles = false;
            this.dgrestockbo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgrestockbo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgrestockbo.Location = new System.Drawing.Point(20, 63);
            this.dgrestockbo.MultiSelect = false;
            this.dgrestockbo.Name = "dgrestockbo";
            this.dgrestockbo.ReadOnly = true;
            this.dgrestockbo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgrestockbo.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgrestockbo.RowHeadersWidth = 45;
            this.dgrestockbo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgrestockbo.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgrestockbo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrestockbo.Size = new System.Drawing.Size(652, 250);
            this.dgrestockbo.TabIndex = 43;
            this.dgrestockbo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrestockbo_CellClick);
            this.dgrestockbo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrestockbo_CellContentClick);
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
            // Column6
            // 
            this.Column6.HeaderText = "Last Delivered Qty";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 174;
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
            dataGridViewCellStyle27.NullValue = "Not Specified";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle27;
            this.Column4.HeaderText = "Delivered Qty";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 138;
            // 
            // lnkcomplete
            // 
            this.lnkcomplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkcomplete.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.lnkcomplete.Image = ((System.Drawing.Image)(resources.GetObject("lnkcomplete.Image")));
            this.lnkcomplete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkcomplete.ImageSize = 50;
            this.lnkcomplete.Location = new System.Drawing.Point(622, 317);
            this.lnkcomplete.Name = "lnkcomplete";
            this.lnkcomplete.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkcomplete.NoFocusImage")));
            this.lnkcomplete.Size = new System.Drawing.Size(50, 66);
            this.lnkcomplete.TabIndex = 42;
            this.lnkcomplete.Text = "Add";
            this.lnkcomplete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkcomplete.UseSelectable = true;
            this.lnkcomplete.Click += new System.EventHandler(this.lnkcomplete_Click);
            // 
            // labelquantity
            // 
            this.labelquantity.AutoSize = true;
            this.labelquantity.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelquantity.Location = new System.Drawing.Point(16, 317);
            this.labelquantity.Name = "labelquantity";
            this.labelquantity.Size = new System.Drawing.Size(167, 22);
            this.labelquantity.TabIndex = 46;
            this.labelquantity.Text = "Specify Quantity for:";
            // 
            // addbackorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 384);
            this.Controls.Add(this.labelquantity);
            this.Controls.Add(this.lnkadd);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.dgrestockbo);
            this.Controls.Add(this.lnkcomplete);
            this.MaximizeBox = false;
            this.Name = "addbackorder";
            this.Resizable = false;
            this.Text = "Increase Qty";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.addbackorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrestockbo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkadd;
        public System.Windows.Forms.NumericUpDown txtquantity;
        public MetroFramework.Controls.MetroGrid dgrestockbo;
        public MetroFramework.Controls.MetroLink lnkcomplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label labelquantity;
    }
}