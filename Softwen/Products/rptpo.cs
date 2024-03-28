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

namespace Softwen.Products
{
    public partial class rptpo : MetroForm
    {
        purchaseorder po = new purchaseorder();
        reloadpo po2 = new reloadpo();
        public bool initialreport = true;
        public string selectedponumber = "";
        public rptpo()
        {
            InitializeComponent();
        }

        private void rptpo_Load(object sender, EventArgs e)
        {
            if (initialreport)
            {
                po.Refresh();
                po.SetDatabaseLogon(ConfigurationManager.AppSettings["Username"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
                po.SetParameterValue("branchname", Properties.Settings.Default.StoreName);
                po.SetParameterValue("branchadd", Properties.Settings.Default.StoreAddess);
                po.SetParameterValue("branchid", Properties.Settings.Default.StoreID);
                crystalpo.Refresh();
                crystalpo.ReportSource = po;
            }
            else if (initialreport == false)
            {
                po2.Refresh();
                po2.SetDatabaseLogon(ConfigurationManager.AppSettings["Username"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
                po2.SetParameterValue("branchname", Properties.Settings.Default.StoreName);
                po2.SetParameterValue("branchadd", Properties.Settings.Default.StoreAddess);
                po2.SetParameterValue("branchid", Properties.Settings.Default.StoreID);
                po2.SetParameterValue("ponumber", selectedponumber);
                crystalpo.Refresh();
                crystalpo.ReportSource = po2;
            }

        }

        private void btnexportexcel_Click(object sender, EventArgs e)
        {
            Globals gs = new Globals();
            gs.exportexcel(po);
            MetroMessageBox.Show(this, "Export Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
