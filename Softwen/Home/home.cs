using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Softwen.Home
{
    public partial class home : UserControl
    {
        Globals gs = new Globals();
        Bunifu.Framework.UI.BunifuElipse bfe = new Bunifu.Framework.UI.BunifuElipse();
        double sales = 0;
        private static home _homeinstance;
        public static home HomeInstance
        {
            get
            {
                if (_homeinstance == null)
                    _homeinstance = new home();

                return _homeinstance;
            }
        }
        public home()
        {
            InitializeComponent();
        }
        public void showstats()
        {
            label1.Text = "Sales Today\r\n" + DateTime.Now.ToString("D");
            if (checksales() == false)
            {
                labeldaysales.Text = "₱ " + string.Format("{0:F2}", sales);
            }
            labelsalescount.Text = salescount().ToString();
        }
        public void loadchart()
        {
            using (SqlDataReader readerbarcode = Globals.ExecuteReader(@"loadcharts", "@1", ""))
            {
                if (readerbarcode.HasRows)
                {
                    while (readerbarcode.Read())
                    {
                        this.topseller.Series[0].Points.AddXY(readerbarcode[0], readerbarcode[1]);
                    }
                }
            }
        }
        private bool checksales()
        {
            using (SqlConnection con = new SqlConnection(gs.connstring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM orders  WHERE (CAST(datesold AS date)) = (CAST(GETDATE()AS date))", con))
                {

                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        labeldaysales.Text = "₱ " + string.Format("{0:F2}", gettodaysales());
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        private double gettodaysales()
        {
            using (SqlConnection con = new SqlConnection(gs.connstring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT SUM(totalamount) FROM orders WHERE (CAST(datesold AS date)) = (CAST(GETDATE()AS date))", con))
                {
                    con.Open();
                    sales = (double)cmd.ExecuteScalar();
                    return sales;
                }
            }
        }
        private int salescount()
        {
            using (SqlConnection con = new SqlConnection(gs.connstring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT count(totalamount) FROM orders WHERE (CAST(datesold AS date)) = (CAST(GETDATE()AS date))", con))
                {
                    con.Open();
                    int csales = (int)cmd.ExecuteScalar();
                    return csales;
                }

            }
        }
        private void home_Load(object sender, EventArgs e)
        {
            this.bfe.ApplyElipse(panel1, 7);
            this.bfe.ApplyElipse(panel2, 7);
            this.bfe.ApplyElipse(topseller, 7);
            loadchart();
        }
    }
}
