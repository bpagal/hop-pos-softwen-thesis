using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwen.Transaction
{
    public partial class rptinvoice : MetroForm
    {
        public static string cashiername = "";
        public static string vat = "";
        public static string subtotal = "";
        public static string grandtotal = "";
        public static string discount = "";
        public string discounttype = "";
        public string cash = "";
        public string change = "";
        public rptinvoice()
        {
            InitializeComponent();
        }

        private void rptinvoice_Load(object sender, EventArgs e)
        {
            invoice ivc = new invoice();
            ivc.Load(@"C:\Users\Brian\Documents\Visual Studio 2015\Projects\Softwen\Softwen\Transaction\CrystalReport1.rpt");
            ivc.Refresh();
            ivc.SetDatabaseLogon(ConfigurationManager.AppSettings["Username"].ToString(), ConfigurationManager.AppSettings["Password"].ToString());
            ivc.SetParameterValue("storename", Properties.Settings.Default.StoreName);
            ivc.SetParameterValue("storeaddress", Properties.Settings.Default.StoreAddess);
            ivc.SetParameterValue("storewebsite", Properties.Settings.Default.StoreWebsite);
            ivc.SetParameterValue("cashiername", cashiername);
            ivc.SetParameterValue("vat", vat);
            ivc.SetParameterValue("subtotal", subtotal);
            ivc.SetParameterValue("discounttype", discounttype);
            ivc.SetParameterValue("discount", discount);
            ivc.SetParameterValue("grandtotal", grandtotal);
            ivc.SetParameterValue("cash", cash);
            ivc.SetParameterValue("change", change);
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource = ivc;

        }
    }
}
