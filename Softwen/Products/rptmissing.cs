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
    public partial class rptmissing : MetroForm
    {
        public rptmissing()
        {
            InitializeComponent();
        }

        private void rptmissing_Load(object sender, EventArgs e)
        {
            missing missingproducts = new missing();
            missingproducts.Load(@"C:\Users\Brian\Documents\Visual Studio 2015\Projects\Softwen\Softwen\Softwen\Softwen\Products\missing.rpt");
            missingproducts.Refresh();
            missingproducts.SetDatabaseLogon(ConfigurationManager.AppSettings["Username"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
            missingproducts.SetParameterValue("storename", Properties.Settings.Default.StoreName);
            missingproducts.SetParameterValue("storeaddress", Properties.Settings.Default.StoreAddess);
            crystalmissing.Refresh();
            crystalmissing.ReportSource = missingproducts;
        }
    }
}
