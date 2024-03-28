namespace Softwen.Home
{
    partial class home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.homestylemanager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.homepanel = new System.Windows.Forms.Panel();
            this.topseller = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelsalescount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labeldaysales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.homestylemanager)).BeginInit();
            this.homepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topseller)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // homestylemanager
            // 
            this.homestylemanager.Owner = this;
            // 
            // homepanel
            // 
            this.homepanel.BackColor = System.Drawing.Color.Transparent;
            this.homepanel.Controls.Add(this.topseller);
            this.homepanel.Controls.Add(this.panel2);
            this.homepanel.Controls.Add(this.panel1);
            this.homepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homepanel.Location = new System.Drawing.Point(0, 0);
            this.homepanel.Name = "homepanel";
            this.homepanel.Size = new System.Drawing.Size(1085, 518);
            this.homepanel.TabIndex = 7;
            this.homepanel.Visible = false;
            // 
            // topseller
            // 
            chartArea1.Name = "ChartArea1";
            this.topseller.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.topseller.Legends.Add(legend1);
            this.topseller.Location = new System.Drawing.Point(555, 0);
            this.topseller.Name = "topseller";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.LegendText = "Products";
            series1.Name = "Products";
            this.topseller.Series.Add(series1);
            this.topseller.Size = new System.Drawing.Size(513, 472);
            this.topseller.TabIndex = 4;
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Top 5 best selling products";
            this.topseller.Titles.Add(title1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelsalescount);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(32, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 228);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(403, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 97);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sales Count";
            // 
            // labelsalescount
            // 
            this.labelsalescount.AutoSize = true;
            this.labelsalescount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.labelsalescount.Font = new System.Drawing.Font("Open Sans Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsalescount.ForeColor = System.Drawing.Color.White;
            this.labelsalescount.Location = new System.Drawing.Point(3, 83);
            this.labelsalescount.Name = "labelsalescount";
            this.labelsalescount.Size = new System.Drawing.Size(122, 47);
            this.labelsalescount.TabIndex = 2;
            this.labelsalescount.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labeldaysales);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(32, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 228);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 97);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales Today: Sunday";
            // 
            // labeldaysales
            // 
            this.labeldaysales.AutoSize = true;
            this.labeldaysales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.labeldaysales.Font = new System.Drawing.Font("Open Sans Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldaysales.Location = new System.Drawing.Point(3, 131);
            this.labeldaysales.Name = "labeldaysales";
            this.labeldaysales.Size = new System.Drawing.Size(122, 47);
            this.labeldaysales.TabIndex = 2;
            this.labeldaysales.Text = "label1";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.homepanel);
            this.Name = "home";
            this.Size = new System.Drawing.Size(1085, 518);
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homestylemanager)).EndInit();
            this.homepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topseller)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Components.MetroStyleManager homestylemanager;
        public System.Windows.Forms.Panel homepanel;
        private System.Windows.Forms.Label labeldaysales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelsalescount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataVisualization.Charting.Chart topseller;
    }
}
