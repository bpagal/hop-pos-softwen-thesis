using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MetroFramework;
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
    public partial class dailyreport : MetroForm
    {
        public string datesold = "";
        public string cashiername = "";
        public string productname = "";
        daily dailyrpt = new daily();
        public dailyreport()
        {
            InitializeComponent();
        }

        private void dailyreport_Load(object sender, EventArgs e)
        {
            dailyrpt.Refresh();
            dailyrpt.SetDatabaseLogon(ConfigurationManager.AppSettings["Username"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
            dailyrpt.SetParameterValue("storename", Properties.Settings.Default.StoreName);
            dailyrpt.SetParameterValue("storeaddress", Properties.Settings.Default.StoreAddess);
            dailyrpt.SetParameterValue("branchid", Properties.Settings.Default.StoreID);
            dailyrpt.SetParameterValue("datesold", reports.ReportsInstance.dtdaily.Value);
            dailyrpt.SetParameterValue("cashiername", cashiername);
            dailyrpt.SetParameterValue("productname", productname);
            crystaldaily.Refresh();
            crystaldaily.ReportSource = dailyrpt;


        }

        private void btnexportexcel_Click(object sender, EventArgs e)
        {
            Globals gs = new Globals();
            gs.exportexcel(dailyrpt);
            MetroMessageBox.Show(this, "Export Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
