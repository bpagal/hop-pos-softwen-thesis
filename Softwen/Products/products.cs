using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Softwen.Maintenance;
using System.Data.SqlClient;
using MetroFramework;
using MetroFramework.Controls;

namespace Softwen.Products
{
    public partial class products : UserControl
    {
        Globals gs = new Globals();
        private static products _productsinstance;
        public static products ProductsInstance
        {
            get
            {
                if (_productsinstance == null)
                    _productsinstance = new products();
                return _productsinstance;
            }
        }
        public products()
        {
            InitializeComponent();
        }
        private void populatedatagrids()
        {
            selectproducts();
            selectmissingproducts();
            selectcategory();
            selectpurchaseorder();
            selectdelivered();
            selectbackorders();
        }
        public void displaylowqty()
        {
            using (SqlConnection con = new SqlConnection(gs.connstring))
            {
                using (SqlCommand cmd = new SqlCommand("displaylowqty", con))
                {
                    con.Open();
                    SqlDataReader readerlowqty = cmd.ExecuteReader();
                    StringBuilder productnames = new StringBuilder();
                    if (readerlowqty.HasRows)
                    {
                        while (readerlowqty.Read())
                        {
                            productnames.Append(readerlowqty.GetString(0) + Environment.NewLine);
                        }
                        MetroMessageBox.Show(this, "There are products that needs restocking.\r\n" + productnames, "Restock needed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        return;
                }
            }
        }

        public void selectcategory()
        {
            gs.Select("selectcat", dgcategories);
        }
        public void selectproducts()
        {
            gs.Select(@"selectproducts", dgproducts);
        }
        public void selectmissingproducts()
        {
            gs.Select(@"missingproducted", dgmissingproducts);
        }
        public void selectpurchaseorder()
        {
            gs.Select(@"selectpo", dgpo);
        }
        public void selectbackorders()
        {
            gs.Select(@"selectbackorders", dgbackorder);
        }
        public void selectdelivered()
        {
            gs.Select(@"selectdelivered", dgdelivered);
        }
        public void productbuttons()
        {
            if (dgproducts.Rows.Count == 0)
            {
                lnkaddstock.Visible = false;
                lnkmissing.Visible = false;
            }
            else
            {
                lnkaddstock.Visible = true;
                lnkmissing.Visible = true;
            }

        }
        private void filterproduct()
        {
            if (comboboxsp.SelectedIndex == 0)
                gs.Filter(@"filterproduct1", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 1)
                gs.Filter(@"combofill", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 2)
                gs.Filter(@"combofill1", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 3)
                gs.Filter(@"combofill2", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 4)
                gs.Filter(@"combofill3", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 5)
                gs.Filter(@"combofill4", txtsp.Text, dgproducts);

        }
        private void txtsp_TextChanged(object sender, EventArgs e)
        {
            filterproduct();
        }

        private void lnkaddstock_Click(object sender, EventArgs e)
        {
            using (addpo rst = new addpo(this))
            {
                productstylemanager.Clone(rst);
                rst.ShowDialog(this);
            }
        }

        private void lnkmissing_Click(object sender, EventArgs e)
        {
            missingproducts ms = new missingproducts();
            productstylemanager.Clone(ms);
            ms.ShowDialog(this);
        }

        private void lnkreportmissing_Click(object sender, EventArgs e)
        {
            rptmissing rptms = new rptmissing();
            productstylemanager.Clone(rptms);
            rptms.ShowDialog();
        }

        private void comboboxsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterproduct();
        }

        private void products_Load(object sender, EventArgs e)
        {
            this.dgproducts.Columns[5].DefaultCellStyle.Format = "C";
            this.dgproducts.Columns[5].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("en-PH");
            productstabcontrol.SelectedTab = metroTabPage1;
            populatedatagrids();
        }
        private void openpoform()
        {
            addstocks adst = new addstocks();
            foreach (DataGridViewRow row in dgpo.Rows)
            {
                string selectedporderid = adst.ponumber = dgpo.CurrentRow.Cells[0].Value.ToString();
                string allporderid = row.Cells[0].Value.ToString();
                if (selectedporderid == allporderid)
                {
                    string[] arrayofrows = { row.Cells[3].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[2].Value.ToString() };
                    adst.dgrestock.Rows.Add(arrayofrows);
                }
            }
            adst.ShowDialog(this);
        }
        public void openpoform2()
        {
            addbackorder addbo = new addbackorder();
            foreach (DataGridViewRow row in dgbackorder.Rows)
            {
                string selectedporderid = addbo.ponumber = dgbackorder.CurrentRow.Cells[0].Value.ToString();
                string allporderid = row.Cells[0].Value.ToString();
                if (selectedporderid == allporderid)
                {
                    string[] arrayofrows = { row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[9].Value.ToString() };
                    addbo.dgrestockbo.Rows.Add(arrayofrows);
                }
            }
            addbo.rsid = dgbackorder.CurrentRow.Cells[1].Value.ToString();
            addbo.ShowDialog(this);
        }
        private void lnkcomplete_Click(object sender, EventArgs e)
        {
            openpoform();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            openpoform2();
        }
    }
}
