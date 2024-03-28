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
                using (SqlCommand cmd = new SqlCommand("SELECT productname, quantity, maxquantity from products WHERE status = 'active' AND quantity <= maxquantity/2", con))
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
            gs.Select("SELECT * FROM category", dgcategories);
        }
        public void selectproducts()
        {
            gs.Select(@"SELECT products.productid, products.productname, products.productcode, products.barcode, products.quantity, products.price, category.categoryname, products.description, products.maxquantity, products.status FROM products INNER JOIN category ON category.categoryid = products.categoryid WHERE status = 'active'", dgproducts);
        }
        public void selectmissingproducts()
        {
            gs.Select(@"SELECT products.productid, products.productname, products.description, products.productcode, products.quantity, category.categoryname, products.status, missingproducts.missingquantity FROM category 
                        INNER JOIN products ON category.categoryid = products.categoryid 
                        INNER JOIN missingproducts ON products.productid = missingproducts.productid", dgmissingproducts);
        }
        public void selectpurchaseorder()
        {
            gs.Select(@"SELECT purchaseorder.ponumber as 'P/O Number', CONVERT(VARCHAR(20), purchaseorder.daterequested, 100) as 'Date',  products.productid as 'ID' , products.productname as 'Product', products.description as 'Desc' ,  products.price * podetails.orderedqty as 'Amount',
       podetails.orderedqty as 'Qty Ordered', products.quantity as 'Qty', purchaseorder.status as 'Status' FROM podetails
	   INNER JOIN products ON podetails.productid = products.productid 
	   INNER JOIN purchaseorder ON podetails.ponumber = purchaseorder.ponumber
	   INNER JOIN users ON purchaseorder.userid = users.userid WHERE purchaseorder.status = 'unprocessed' ", dgpo);
        }
        public void selectbackorders()
        {
            gs.Select(@"SELECT  restocks.ponumber AS [[P/O]] #], restocks.restockid AS ID, products.productname AS Product,products.quantity as 'Quantity', restocks.quantityafter - restocks.restockquantity AS 'Previous Qty', podetails.orderedqty AS [Ordered Qty], restocks.restockquantity AS [Last Delivered Qty], 
                         restocks.quantityafter AS [Qty After Delivery], restocks.restockid, products.productid FROM products 
                         INNER JOIN podetails ON products.productid = podetails.productid 
                         INNER JOIN purchaseorder ON podetails.ponumber = purchaseorder.ponumber 
                         INNER JOIN restocks ON products.productid = restocks.productid AND purchaseorder.ponumber = restocks.ponumber 
                         INNER JOIN users ON purchaseorder.userid = users.userid AND restocks.userid = users.userid 
                         WHERE restocks.status = 'Incomplete' ", dgbackorder);
        }
        public void selectdelivered()
        {
            gs.Select(@"SELECT restocks.restockid AS ID, CONCAT(users.fname, ' ', users.lname) AS 'Cashier', CONVERT(VARCHAR(20), restocks.restockdate, 100) AS 'Date', products.productname AS Product, 
                         restocks.quantityafter - restocks.restockquantity AS 'Previous Qty', podetails.orderedqty AS [Ordered Qty], restocks.restockquantity AS [Delivered Qty], restocks.quantityafter AS [Qty After Delivery], 
                         restocks.ponumber AS [[P/O]] #], restocks.status AS Status FROM products 
                         INNER JOIN podetails ON products.productid = podetails.productid 
                         INNER JOIN purchaseorder ON podetails.ponumber = purchaseorder.ponumber 
                         INNER JOIN restocks ON products.productid = restocks.productid AND purchaseorder.ponumber = restocks.ponumber 
                         INNER JOIN users ON purchaseorder.userid = users.userid AND restocks.userid = users.userid", dgdelivered);
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
                gs.Filter(@"SELECT products.productid, products.productcode, products.barcode, products.productname, products.quantity, products.price, category.categoryname, products.description,  products.maxquantity, products.status FROM products  INNER JOIN category ON category.categoryid = products.categoryid WHERE productname LIKE @1 AND status = 'active'", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 1)
                gs.Filter(@"SELECT products.productid, products.productcode, products.barcode, products.productname, products.quantity, products.price, category.categoryname, products.description,  products.maxquantity, products.status FROM products  INNER JOIN category ON category.categoryid = products.categoryid WHERE productcode LIKE @1 AND status = 'active'", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 2)
                gs.Filter(@"SELECT products.productid, products.productcode, products.barcode, products.productname, products.quantity, products.price, category.categoryname, products.description,  products.maxquantity, products.status FROM products  INNER JOIN category ON category.categoryid = products.categoryid WHERE category.categoryname LIKE @1 AND status = 'active'", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 3)
                gs.Filter(@"SELECT products.productid, products.productcode, products.barcode, products.productname, products.quantity, products.price, category.categoryname, products.description,  products.maxquantity, products.status FROM products  INNER JOIN category ON category.categoryid = products.categoryid WHERE price LIKE @1 AND status = 'active'", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 4)
                gs.Filter(@"SELECT products.productid, products.productcode, products.barcode, products.productname, products.quantity, products.price, category.categoryname, products.description,  products.maxquantity, products.status FROM products  INNER JOIN category ON category.categoryid = products.categoryid WHERE description LIKE @1 AND status = 'active'", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 5)
                gs.Filter(@"SELECT products.productid, products.productcode, products.barcode, products.productname, products.quantity, products.price, category.categoryname, products.description,  products.maxquantity, products.status FROM products  INNER JOIN category ON category.categoryid = products.categoryid WHERE barcode LIKE @1 AND status = 'active'", txtsp.Text, dgproducts);

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
