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

namespace Softwen.Reports
{
    public partial class stockreport : MetroForm
    {
        public bool dailystocks = true;
        public stockreport()
        {
            InitializeComponent();
        }

        private void stockreport_Load(object sender, EventArgs e)
        {
            stocks stocksrpt = new stocks();
            stocksrpt.Load(@"C:\Users\Rhiennier\Downloads\Softwen\Softwen\Softwen\Softwen\Reports\daily.rpt");
            stocksrpt.Refresh();
            stocksrpt.SetDatabaseLogon(ConfigurationManager.AppSettings["Username"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
            stocksrpt.SetParameterValue("storename", Properties.Settings.Default.StoreName);
            stocksrpt.SetParameterValue("storeaddress", Properties.Settings.Default.StoreAddess);
            stocksrpt.SetParameterValue("stockdate", reports.ReportsInstance.dtstocks.Value);
            stocksrpt.SetParameterValue("stockstartdate", reports.ReportsInstance.dtstartstocks.Value);
            stocksrpt.SetParameterValue("stockenddate", reports.ReportsInstance.dtendstocks.Value);
            stocksrpt.SetParameterValue("branchid", Properties.Settings.Default.StoreID);
            stocksrpt.SetParameterValue("daily", dailystocks);
            crystalstocks.Refresh();
            crystalstocks.ReportSource = stocksrpt;
        }
    }
}
