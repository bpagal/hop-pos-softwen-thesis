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
        public void populatedatagrids()
        {
            selectproducts();
            selectdispense();
            selectpurchaseorder();
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
        public void selectproducts()
        {
            gs.Select(@"selectproducts", dgproducts);
        }
        public void selectdispense()
        {
            gs.Select(@"selectdispense", dgmissingproducts);
        }
        public void selectpurchaseorder()
        {
            gs.Select(@"selectpo", dgpo);
        }
        public void selectbackorders()
        {
            gs.Select(@"selectbackorders", dgbackorder);
        }
        public void productbuttons()
        {
            if (dgproducts.Rows.Count == 0)
            {
                lnkaddstock.Visible = false;
                lnkdispense.Visible = false;
            }
            else
            {
                lnkaddstock.Visible = true;
                lnkdispense.Visible = true;
            }

        }
        private void filterproduct()
        {
            //if (comboboxsp.SelectedIndex == 0)
            //    gs.Filter(@"filterproduct1", txtsp.Text, dgproducts);
            //else if (comboboxsp.SelectedIndex == 1)
            //    gs.Filter(@"combofill", txtsp.Text, dgproducts);
            //else if (comboboxsp.SelectedIndex == 2)
            //    gs.Filter(@"combofill1", txtsp.Text, dgproducts);
            //else if (comboboxsp.SelectedIndex == 3)
            //    gs.Filter(@"combofill2", txtsp.Text, dgproducts);
            //else if (comboboxsp.SelectedIndex == 4)
            //    gs.Filter(@"combofill3", txtsp.Text, dgproducts);
            //else if (comboboxsp.SelectedIndex == 5)
            //    gs.Filter(@"combofill4", txtsp.Text, dgproducts);

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
        private void lnkreportmissing_Click(object sender, EventArgs e)
        {
            rptdispense rptms = new rptdispense();
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
            productstabcontrol.SelectedTab = productpage;
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
                    string[] arrayofrows = { row.Cells[3].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[2].Value.ToString() };
                    adst.dgrestock.Rows.Add(arrayofrows);
                }
            }
            productstylemanager.Clone(adst);
            adst.ShowDialog(this);
        }
        public void openboform()
        {
            addbackorder addbo = new addbackorder();
            foreach (DataGridViewRow row in dgbackorder.Rows)
            {
                string selectedporderid = addbo.ponumber = dgbackorder.CurrentRow.Cells[0].Value.ToString();
                string allporderid = row.Cells[0].Value.ToString();
                if (selectedporderid == allporderid)
                {
                    string[] arrayofrows = { row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[2].Value.ToString() };
                    addbo.dgrestockbo.Rows.Add(arrayofrows);
                }
            }
            productstylemanager.Clone(addbo);
            addbo.rsid = dgbackorder.CurrentRow.Cells[1].Value.ToString();
            addbo.ShowDialog(this);
        }
        private void lnkaddpo_Click(object sender, EventArgs e)
        {
            openpoform();
        }

        private void productstabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productstabcontrol.SelectedTab == productpage)
            {
                selectproducts();
            }
            else if (productstabcontrol.SelectedTab == dispensepage)
            {
                if (dgmissingproducts.Rows.Count == 0)
                {
                    lnkreportmissing.Visible = false;
                }
                else
                    lnkreportmissing.Visible = true;
            }
            else if (productstabcontrol.SelectedTab == popage)
            {
                pobutton();
            }
            else if (productstabcontrol.SelectedTab == bopage)
            {
                bobutton();
            }
        }

        private void bobutton()
        {
            if (dgbackorder.Rows.Count == 0)
            {
                lnkaddbackorder.Visible = false;
                lnkboreport.Visible = false;
            }
            else
            {
                lnkaddbackorder.Visible = true;
                lnkboreport.Visible = true;
            } 
        }

        private void lnkdispense_Click(object sender, EventArgs e)
        {
            adddispense adddps = new adddispense { productid = dgproducts.CurrentRow.Cells[0].Value.ToString() };
            productstylemanager.Clone(adddps);
            adddps.txtproductname.Text = dgproducts.CurrentRow.Cells[1].Value.ToString();
            adddps.txtquantity.Maximum = Convert.ToDecimal(dgproducts.CurrentRow.Cells[4].Value);
            adddps.ShowDialog();

        }
        private void pobutton()
        {
            if (dgpo.Rows.Count == 0)
            {
                lnkaddpo.Visible = false;
                lnkreloadpo.Visible = false;
            }
            else
            {
                lnkaddpo.Visible = true;
                lnkreloadpo.Visible = true;
            }
                
        }
        private void dgpo_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            pobutton();
        }

        private void dgpo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            pobutton();
        }

        private void lnkaddbackorder_Click(object sender, EventArgs e)
        {
            openboform();
        }

        private void dgbackorder_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            bobutton();
        }

        private void dgbackorder_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            bobutton();
        }
        public void dispenselogic()
        {
            if (dgproducts.Rows.Count>0)
            {
                if (Convert.ToInt32(dgproducts.CurrentRow.Cells[4].Value) <= 0)
                    lnkdispense.Visible = false;
                else
                    lnkdispense.Visible = true;
            }
        }
        private void dgproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dispenselogic();
        }

        private void lnkboreport_Click(object sender, EventArgs e)
        {
            rptbo _rptbo = new rptbo();
            productstylemanager.Clone(_rptbo);
            _rptbo.ponumber = Convert.ToInt32(this.dgbackorder.CurrentRow.Cells[0].Value);
            _rptbo.ShowDialog();
        }

        private void lnkreloadpo_Click(object sender, EventArgs e)
        {
            rptpo rptpurchaseoder = new rptpo();
            productstylemanager.Clone(rptpurchaseoder);
            rptpurchaseoder.initialreport = false;
            rptpurchaseoder.selectedponumber = this.dgpo.CurrentRow.Cells[0].Value.ToString();
            rptpurchaseoder.ShowDialog();
        }
    }
}
