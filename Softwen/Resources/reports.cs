using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwen.Reports
{
    public partial class reports : UserControl
    {
        private static reports _reportsinstance;
        public static reports ReportsInstance
        {
            get
            {
                if (_reportsinstance == null)
                    _reportsinstance = new reports();

                return _reportsinstance;
            }
        }
        public reports()
        {
            InitializeComponent(); 
            populatecashier();
        }
        public void populatecashier()
        {
            Globals gs = new Globals();
            gs.populatecombobox(combobxcashier, "SELECT fullname from users", "fullname", "userid");
           
        }
        public void selectdaily()
        {
            //if (chball.Checked)
            //{
            //    combobxcashier.Enabled = false;
            //    this.dailysalesTableAdapter.FillByDailyAll(this.hOPDateSet.dailysales, this.dtdaily.Value.ToString());
            //}
            //else
            //{
            //    combobxcashier.Enabled = true;
            //    this.dailysalesTableAdapter.FillbyDaily(this.hOPDateSet.dailysales, this.dtdaily.Value.ToString(), combobxcashier.Text);
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rptdaily rpt = new rptdaily();
            rpt.date = this.dtdaily.Value.ToString();
            if (chball.Checked)
            {
                rpt.cashiername = chball.Text;
            }
            else
            {
                rpt.cashiername = this.combobxcashier.Text;
            }      
            rpt.ShowDialog();
        }

        private void dtdaily_ValueChanged(object sender, EventArgs e)
        {
            selectdaily();
        }

        private void combobxcashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectdaily();
        }
        private void chball_CheckedChanged(object sender, EventArgs e)
        {
            selectdaily();
        }
    }
}
