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
        public rptpo()
        {
            InitializeComponent();
        }

        private void rptpo_Load(object sender, EventArgs e)
        {  
            po.Refresh();
            po.SetDatabaseLogon(ConfigurationManager.AppSettings["Username"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
            po.SetParameterValue("branchname", Properties.Settings.Default.StoreName);
            po.SetParameterValue("branchadd", Properties.Settings.Default.StoreAddess);
            po.SetParameterValue("branchid", Properties.Settings.Default.StoreID);
            crystalpo.Refresh();
            crystalpo.ReportSource = po;
        }

        private void btnexportexcel_Click(object sender, EventArgs e)
        {
            Globals gs = new Globals();
            gs.exportexcel(po);
            MetroMessageBox.Show(this, "Export Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
