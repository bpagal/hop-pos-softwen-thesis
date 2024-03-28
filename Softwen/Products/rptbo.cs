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
    public partial class rptbo : MetroForm
        
    {
        backorder bo = new backorder();
        public int ponumber = 0;
        public rptbo()
        {
            InitializeComponent();
        }

        private void rptbo_Load(object sender, EventArgs e)
        {
            bo.Refresh();
            bo.SetDatabaseLogon(ConfigurationManager.AppSettings["Username"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
            bo.SetParameterValue("branchname", Properties.Settings.Default.StoreName);
            bo.SetParameterValue("branchadd", Properties.Settings.Default.StoreAddess);
            bo.SetParameterValue("branchid", Properties.Settings.Default.StoreID);
            bo.SetParameterValue("po", ponumber);
            crystalbo.Refresh();
            crystalbo.ReportSource = bo;
        }
    }
}
