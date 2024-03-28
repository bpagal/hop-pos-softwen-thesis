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
        public rptpo()
        {
            InitializeComponent();
        }

        private void rptpo_Load(object sender, EventArgs e)
        {
            purchaseorder po = new purchaseorder();
            po.Load(@"C:\Users\Brian\documents\visual studio 2015\Projects\Softwen\Softwen\Products\purchaseorder.rpt");
            po.Refresh();
            po.SetDatabaseLogon(ConfigurationManager.AppSettings["Username"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
            po.SetParameterValue("branchname", Properties.Settings.Default.StoreName);
            po.SetParameterValue("branchadd", Properties.Settings.Default.StoreAddess);
            crystalpo.Refresh();
            crystalpo.ReportSource = po;
        }
    }
}
