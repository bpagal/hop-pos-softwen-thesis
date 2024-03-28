namespace Softwen.UserActivity
{
    partial class useract
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            this.useractstylemanager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.paneluseract = new System.Windows.Forms.Panel();
            this.rmonthly = new MetroFramework.Controls.MetroRadioButton();
            this.rdaily = new MetroFramework.Controls.MetroRadioButton();
            this.panelmonthlyua = new MetroFramework.Controls.MetroPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtendua = new MetroFramework.Controls.MetroDateTime();
            this.dtstartua = new MetroFramework.Controls.MetroDateTime();
            this.paneldailyua = new MetroFramework.Controls.MetroPanel();
            this.dtuseract = new MetroFramework.Controls.MetroDateTime();
            this.label7 = new System.Windows.Forms.Label();
            this.dguseractivity = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.useractstylemanager)).BeginInit();
            this.paneluseract.SuspendLayout();
            this.panelmonthlyua.SuspendLayout();
            this.paneldailyua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dguseractivity)).BeginInit();
            this.SuspendLayout();
            // 
            // useractstylemanager
            // 
            this.useractstylemanager.Owner = this;
            // 
            // paneluseract
            // 
            this.paneluseract.Controls.Add(this.rmonthly);
            this.paneluseract.Controls.Add(this.rdaily);
            this.paneluseract.Controls.Add(this.panelmonthlyua);
            this.paneluseract.Controls.Add(this.paneldailyua);
            this.paneluseract.Controls.Add(this.dguseractivity);
            this.paneluseract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneluseract.Location = new System.Drawing.Point(0, 0);
            this.paneluseract.Name = "paneluseract";
            this.paneluseract.Size = new System.Drawing.Size(1085, 518);
            this.paneluseract.TabIndex = 0;
            this.paneluseract.Visible = false;
            // 
            // rmonthly
            // 
            this.rmonthly.AutoSize = true;
            this.rmonthly.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rmonthly.Location = new System.Drawing.Point(733, 60);
            this.rmonthly.Name = "rmonthly";
            this.rmonthly.Size = new System.Drawing.Size(94, 25);
            this.rmonthly.TabIndex = 26;
            this.rmonthly.Text = "Monthly";
            this.rmonthly.UseSelectable = true;
            this.rmonthly.CheckedChanged += new System.EventHandler(this.rmonthly_CheckedChanged);
            // 
            // rdaily
            // 
            this.rdaily.AutoSize = true;
            this.rdaily.Checked = true;
            this.rdaily.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdaily.Location = new System.Drawing.Point(733, 29);
            this.rdaily.Name = "rdaily";
            this.rdaily.Size = new System.Drawing.Size(67, 25);
            this.rdaily.TabIndex = 27;
            this.rdaily.TabStop = true;
            this.rdaily.Text = "Daily";
            this.rdaily.UseSelectable = true;
            this.rdaily.CheckedChanged += new System.EventHandler(this.rdaily_CheckedChanged);
            // 
            // panelmonthlyua
            // 
            this.panelmonthlyua.Controls.Add(this.label4);
            this.panelmonthlyua.Controls.Add(this.label5);
            this.panelmonthlyua.Controls.Add(this.dtendua);
            this.panelmonthlyua.Controls.Add(this.dtstartua);
            this.panelmonthlyua.HorizontalScrollbarBarColor = true;
            this.panelmonthlyua.HorizontalScrollbarHighlightOnWheel = false;
            this.panelmonthlyua.HorizontalScrollbarSize = 10;
            this.panelmonthlyua.Location = new System.Drawing.Point(255, 26);
            this.panelmonthlyua.Name = "panelmonthlyua";
            this.panelmonthlyua.Size = new System.Drawing.Size(448, 60);
            this.panelmonthlyua.TabIndex = 30;
            this.panelmonthlyua.VerticalScrollbarBarColor = true;
            this.panelmonthlyua.VerticalScrollbarHighlightOnWheel = false;
            this.panelmonthlyua.VerticalScrollbarSize = 10;
            this.panelmonthlyua.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Start Date";
            // 
            // dtendua
            // 
            this.dtendua.Checked = false;
            this.dtendua.Location = new System.Drawing.Point(229, 27);
            this.dtendua.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtendua.Name = "dtendua";
            this.dtendua.Size = new System.Drawing.Size(215, 29);
            this.dtendua.TabIndex = 22;
            this.dtendua.Value = new System.DateTime(2017, 9, 30, 0, 0, 0, 0);
            this.dtendua.ValueChanged += new System.EventHandler(this.dtuseract_ValueChanged);
            // 
            // dtstartua
            // 
            this.dtstartua.Checked = false;
            this.dtstartua.Location = new System.Drawing.Point(8, 27);
            this.dtstartua.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtstartua.Name = "dtstartua";
            this.dtstartua.Size = new System.Drawing.Size(215, 29);
            this.dtstartua.TabIndex = 23;
            this.dtstartua.Value = new System.DateTime(2018, 1, 16, 0, 0, 0, 0);
            this.dtstartua.ValueChanged += new System.EventHandler(this.dtuseract_ValueChanged);
            // 
            // paneldailyua
            // 
            this.paneldailyua.Controls.Add(this.dtuseract);
            this.paneldailyua.Controls.Add(this.label7);
            this.paneldailyua.HorizontalScrollbarBarColor = true;
            this.paneldailyua.HorizontalScrollbarHighlightOnWheel = false;
            this.paneldailyua.HorizontalScrollbarSize = 10;
            this.paneldailyua.Location = new System.Drawing.Point(21, 26);
            this.paneldailyua.Name = "paneldailyua";
            this.paneldailyua.Size = new System.Drawing.Size(228, 60);
            this.paneldailyua.TabIndex = 29;
            this.paneldailyua.VerticalScrollbarBarColor = true;
            this.paneldailyua.VerticalScrollbarHighlightOnWheel = false;
            this.paneldailyua.VerticalScrollbarSize = 10;
            // 
            // dtuseract
            // 
            this.dtuseract.Checked = false;
            this.dtuseract.Location = new System.Drawing.Point(9, 27);
            this.dtuseract.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtuseract.Name = "dtuseract";
            this.dtuseract.Size = new System.Drawing.Size(215, 29);
            this.dtuseract.TabIndex = 2;
            this.dtuseract.Value = new System.DateTime(2017, 9, 30, 0, 0, 0, 0);
            this.dtuseract.ValueChanged += new System.EventHandler(this.dtuseract_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date";
            // 
            // dguseractivity
            // 
            this.dguseractivity.AllowUserToAddRows = false;
            this.dguseractivity.AllowUserToDeleteRows = false;
            this.dguseractivity.AllowUserToResizeColumns = false;
            this.dguseractivity.AllowUserToResizeRows = false;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dguseractivity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle57;
            this.dguseractivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dguseractivity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dguseractivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dguseractivity.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dguseractivity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dguseractivity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
            this.dguseractivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dguseractivity.DefaultCellStyle = dataGridViewCellStyle59;
            this.dguseractivity.EnableHeadersVisualStyles = false;
            this.dguseractivity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dguseractivity.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dguseractivity.Location = new System.Drawing.Point(21, 104);
            this.dguseractivity.Name = "dguseractivity";
            this.dguseractivity.ReadOnly = true;
            this.dguseractivity.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dguseractivity.RowHeadersDefaultCellStyle = dataGridViewCellStyle60;
            this.dguseractivity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dguseractivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dguseractivity.Size = new System.Drawing.Size(729, 391);
            this.dguseractivity.TabIndex = 3;
            // 
            // useract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paneluseract);
            this.Name = "useract";
            this.Size = new System.Drawing.Size(1085, 518);
            this.Load += new System.EventHandler(this.useract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.useractstylemanager)).EndInit();
            this.paneluseract.ResumeLayout(false);
            this.paneluseract.PerformLayout();
            this.panelmonthlyua.ResumeLayout(false);
            this.panelmonthlyua.PerformLayout();
            this.paneldailyua.ResumeLayout(false);
            this.paneldailyua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dguseractivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Components.MetroStyleManager useractstylemanager;
        public MetroFramework.Controls.MetroGrid dguseractivity;
        public System.Windows.Forms.Panel paneluseract;
        private MetroFramework.Controls.MetroPanel panelmonthlyua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public MetroFramework.Controls.MetroDateTime dtendua;
        public MetroFramework.Controls.MetroDateTime dtstartua;
        private MetroFramework.Controls.MetroPanel paneldailyua;
        public MetroFramework.Controls.MetroDateTime dtuseract;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroRadioButton rmonthly;
        private MetroFramework.Controls.MetroRadioButton rdaily;
    }
}
