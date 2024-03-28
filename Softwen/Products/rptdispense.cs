using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwen.Products
{
    public partial class rptdispense : MetroForm
    {
        dispense dsp = new dispense();
        public rptdispense()
        {
            InitializeComponent();
        }

        private void rptmissing_Load(object sender, EventArgs e)
        {
            dsp.Refresh();
            dsp.SetDatabaseLogon(ConfigurationManager.AppSettings["Username"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
            dsp.SetParameterValue("storename", Properties.Settings.Default.StoreName);
            dsp.SetParameterValue("storeaddress", Properties.Settings.Default.StoreAddess);
            crystaldispense.Refresh();
            crystaldispense.ReportSource = dsp;
        }
    }
}
