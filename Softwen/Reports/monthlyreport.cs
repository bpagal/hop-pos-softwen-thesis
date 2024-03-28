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
    public partial class monthlyreport : MetroForm
    {
        public string cashiername = "";
        public string productname = "";
        public bool precise = false;
        public monthlyreport()
        {
            InitializeComponent();
        }

        private void monthlyreport_Load(object sender, EventArgs e)
        {
            if (precise==false)
            {
                monthly monthlyrpt = new monthly();
                monthlyrpt.Load(Globals.getrptpath("\\Reports\\monthly.rpt"));
                monthlyrpt.Refresh();
                monthlyrpt.SetDatabaseLogon(ConfigurationManager.AppSettings["Username"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
                monthlyrpt.SetParameterValue("storename", Properties.Settings.Default.StoreName);
                monthlyrpt.SetParameterValue("storeaddress", Properties.Settings.Default.StoreAddess);
                monthlyrpt.SetParameterValue("startdate", reports.ReportsInstance.dtstart.Value);
                monthlyrpt.SetParameterValue("enddate", reports.ReportsInstance.dtend.Value);
                monthlyrpt.SetParameterValue("cashiername", cashiername);
                monthlyrpt.SetParameterValue("productname", productname);
                crystalmonthly.Refresh();
                crystalmonthly.ReportSource = monthlyrpt;
            }
            else if (precise==true)
            {
                precisemonthly precisemonthlyrpt = new precisemonthly();
                precisemonthlyrpt.Load(@"C:\Users\Rhiennier\Downloads\Softwen\Softwen\Softwen\Softwen\Reports\precisemonthly.rpt");
                precisemonthlyrpt.Refresh();
                precisemonthlyrpt.SetDatabaseLogon(ConfigurationManager.AppSettings["Username"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
                precisemonthlyrpt.SetParameterValue("storename", Properties.Settings.Default.StoreName);
                precisemonthlyrpt.SetParameterValue("storeaddress", Properties.Settings.Default.StoreAddess);
                precisemonthlyrpt.SetParameterValue("startdate", reports.ReportsInstance.dtstart.Value);
                precisemonthlyrpt.SetParameterValue("enddate", reports.ReportsInstance.dtend.Value);
                crystalmonthly.Refresh();
                crystalmonthly.ReportSource = precisemonthlyrpt;
            }
        }
    }
}
