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
using System.Configuration;
using MetroFramework;
using Softwen.Maintenance;
using MetroFramework.Forms;

namespace Softwen.Transaction
{
    public partial class transaction : UserControl
    {

        private string connstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString; //connection string
        public string fullname = "";
        private string msg = "";
        private string tempbarcode = "";
        public decimal _discountvalue = 0;
        decimal _grandtotal = 0;
        public decimal _vatpercent = Properties.Settings.Default.Vat / 100;
        public string discountstatus = "None";
        Globals gs = new Globals();
        private static transaction _transactioninstance;
        public static transaction TransactionInstance
        {
            get
            {
                if (_transactioninstance == null)
                    _transactioninstance = new transaction();
                return _transactioninstance;
            }
        }
        public transaction()
        {
            InitializeComponent();
            TextBox tb1 = (TextBox)txtquantity.Controls[1];
            tb1.TextChanged += Tb_TextChanged;
            TextBox tb2 = (TextBox)txtmodifyquantity.Controls[1];
            tb2.TextChanged += Tb2_TextChanged;

        }

        private void Tb2_TextChanged(object sender, EventArgs e)
        {
            if (txtmodifyquantity.Value <= 0)
            {
                MetroMessageBox.Show(this, "Invalid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmodifyquantity.Value = 1;
                txtmodifyquantity.Focus();
            }
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            if (txtquantity.Value <= 0)
            {
                MetroMessageBox.Show(this, "Invalid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquantity.Value = 1;
                txtquantity.Focus();
            }
        }

        private void BarcodeScanned(string barcode)
        {
            tempbarcode = barcode;
        }//sring tempbarcode = barcode scanned
        public void populatecombobox()
        {
            gs.populatecombobox(combobxproduct, "combotransaction", "productname", "productid");
        }//populates the combobox with product names
        private void bcdatagridlogic(string price, string name, int quantity, string[] arrayofrows)
        {
            bool hasquantity = false;
            if (dgtransaction.Rows.Count > 0)
            {
                foreach (DataGridViewRow dgrow in dgtransaction.Rows)
                {
                    if (Convert.ToString(dgrow.Cells[0].Value) == name)
                    {
                        dgrow.Cells[2].Value = Convert.ToString(1 + Convert.ToInt32(dgrow.Cells[2].Value));
                        dgrow.Cells[1].Value = string.Format("{0:F2}", Convert.ToDouble(price) + Convert.ToDouble(dgrow.Cells[1].Value));
                        hasquantity = true;
                    }
                    if (quantity < Convert.ToInt32(dgrow.Cells[2].Value) && Convert.ToString(dgrow.Cells[0].Value) == name) //hirap nito grabe to hahaha
                    {
                        dgrow.Cells[2].Value = Convert.ToString(Convert.ToInt32(dgrow.Cells[2].Value) - 1);
                        dgrow.Cells[1].Value = Convert.ToString(Convert.ToDouble(dgrow.Cells[1].Value) - Convert.ToDouble(price));
                        msg = string.Format("You have insufficient quantity of item: {0} " + "\n" + "Quantity of {0}: {1}", name, quantity);
                        MetroMessageBox.Show(this, msg, "Insufficient stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (!hasquantity)
                    //Add the row to grid view
                    dgtransaction.Rows.Add(arrayofrows);
            }
            else
                //Add the row the grid view for the first time
                dgtransaction.Rows.Add(arrayofrows);
        }//auto updates the quantity if product already exists in the datagridview
        private void datagridlogic(string price, string name, int quantity, string[] arrayofrows, int inputquantity)
        {
            bool hasquantity = false;
            if (dgtransaction.Rows.Count > 0)
            {
                foreach (DataGridViewRow dgrow in dgtransaction.Rows)
                {
                    if (Convert.ToString(dgrow.Cells[0].Value) == name)
                    {
                        dgrow.Cells[2].Value = Convert.ToString(inputquantity + Convert.ToInt32(dgrow.Cells[2].Value));
                        dgrow.Cells[1].Value = string.Format("{0:F2}", (Convert.ToDouble(price) * Convert.ToDouble(dgrow.Cells[2].Value)));
                        hasquantity = true;
                    }
                    if (quantity < Convert.ToInt32(dgrow.Cells[2].Value) && Convert.ToString(dgrow.Cells[0].Value) == name) //hirap nito grabe to hahaha
                    {
                        dgrow.Cells[2].Value = Convert.ToString(Convert.ToInt32(dgrow.Cells[2].Value) - inputquantity);
                        dgrow.Cells[1].Value = Convert.ToString(Convert.ToDouble(dgrow.Cells[1].Value) - (Convert.ToDouble(price)) * inputquantity);
                        msg = string.Format("You have insufficient quantity of item: {0} " + "\n" + "Quantity of {0}: {1}", name, quantity);
                        MetroMessageBox.Show(this, msg, "Insufficient stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (!hasquantity)
                    //Add the row to grid view
                    dgtransaction.Rows.Add(arrayofrows);
            }
            else
                //Add the row the grid view for the first time
                dgtransaction.Rows.Add(arrayofrows);
        }//auto updates the quantity if product already exists in the datagridview
        private void getbarcode()
        {
            using (SqlDataReader readerbarcode = Globals.ExecuteReader(@"SPbarcodeSelect", "@1", txtautobc.Text))
            {
                if (readerbarcode.HasRows)
                {
                    while (readerbarcode.Read())
                    {
                        string productname = readerbarcode[0].ToString(); // It is zero-indexed.
                        string price = string.Format("{0:F2}", (double)readerbarcode[1]);
                        int productquantity = readerbarcode.GetInt32(2);
                        string category = readerbarcode[3].ToString();
                        string description = readerbarcode[4].ToString();
                        int quantity = 1;
                        string[] rows = { productname, price, quantity.ToString(), category, description };
                        if (productquantity < 1)
                        {
                            msg = string.Format("You have insufficient quantity of item: {0} " + "\n" + "Quantity of {0}: {1}", productname, productquantity);
                            MetroMessageBox.Show(this, msg, "Insufficient stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtautobc.Focus();
                        }
                        else
                        {
                            bcdatagridlogic(price, productname, productquantity, rows);
                        }
                    }
                }
            }
        }//gets the barcode of a specific product
        private void checkbarcode()
        {
            using (SqlDataReader readercheckbarcode = Globals.ExecuteReader("barcodecheck", "@1", tempbarcode))
            {
                if (readercheckbarcode.Read())//means barcode exists in the database
                {
                    getbarcode();
                }
                else
                {
                    MetroMessageBox.Show(this, "Invalid Barcode!", "Barcode not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtautobc.Clear();
                    txtautobc.Focus();
                }
            }
        }//checks if the barcode exists or not
        private void checkquantity() //checks the quantity in txtquantity.Value if valid
        {
            using (SqlDataReader readerquantity = Globals.ExecuteReader("[checkquantitys]", "@1", combobxproduct.Text))
            {
                if (readerquantity.HasRows)
                {
                    while (readerquantity.Read())
                    {
                        int productquantity = readerquantity.GetInt32(0);
                        string priceofproduct = readerquantity[1].ToString();
                        string priceindg = string.Format("{0:F2}", (Convert.ToInt32(txtquantity.Value) * readerquantity.GetDouble(1)));
                        string category = readerquantity[2].ToString();
                        string description = readerquantity[3].ToString();
                        string[] rows = { combobxproduct.Text, priceindg, txtquantity.Text, category, description };
                        if (productquantity < txtquantity.Value || productquantity < 1)
                        {
                            msg = string.Format("You have insufficient quantity of item: {0} " + "\n" + "Quantity of {0}: {1}", combobxproduct.Text, productquantity);
                            MetroMessageBox.Show(this, msg, "Insufficient stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            datagridlogic(priceofproduct, combobxproduct.Text, productquantity, rows, Convert.ToInt32(txtquantity.Value));
                        }
                    }
                }
            }
        }
        public bool verifytransaction()
        {
            if (dgtransaction.Rows.Count > 0)
            {
                MetroMessageBox.Show(this, "Ongoing transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtautobc.Focus();
                return true;
            }
            else
                return false;
        }
        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && ActiveControl.GetType() == typeof(TextBox))
            {

                e.Handled = true;
                e.SuppressKeyPress = true;
                BarcodeScanned(txtautobc.Text);
                checkbarcode();
                txtautobc.Clear();
            }
        }//inputting of barcode text
        private void dgtransaction_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            if (dgtransaction.Rows.Count > 0)
            {
                getsummary();
                autopanel.Enabled = true;
                lnkpayment.Enabled = true;
                lnkeditqty2.Enabled = true;
                lnkdiscount.Enabled = true;
                lnkvoid.Enabled = true;
            }

        }//updates the transaction summary

        private void dgtransaction_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            getsummary();
        }//updates the transaction summary
        public void getsummary()
        {
            if (dgtransaction.Rows.Count > 0)
            {
                decimal _subtotal = Convert.ToDecimal(dgtransaction.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[1].Value)));
                decimal _discountedamount = _subtotal - (_subtotal * (_discountvalue / 100));
                decimal _vatamount = _discountedamount * _vatpercent;
                _grandtotal = _discountedamount + (_discountedamount * _vatpercent);
                cashier.Text = fullname;
                subtotal.Text = "P " + string.Format("{0:F2}", _subtotal);
                discountpercent.Text = _discountvalue + "%";
                discountamount.Text = "P " + string.Format("{0:F2}", _discountedamount);
                labelvat.Text = String.Format("Vat Amount {0}%:", Properties.Settings.Default.Vat);
                vat.Text = "P " + string.Format("{0:F2}", _vatamount);
                grandtotal.Text = "P " + string.Format("{0:F2}", _grandtotal);
            }


        }//populates the transaction summary
        private void lnkaddorder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtquantity.Text))
                MetroMessageBox.Show(this, "Quantity can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                checkquantity();
        }//manual input order

        private void bctoggle_CheckedChanged(object sender, EventArgs e)
        {
            if (!manualpanel.Visible)
            {
                txtautobc.Enabled = false;
                manualpanel.Visible = true;
                autopanel.Visible = false;
                lnkfocusbc.Visible = false;
            }
            else
            {
                txtautobc.Enabled = true;
                txtautobc.Focus();
                autopanel.Visible = true;
                manualpanel.Visible = false;
                lnkfocusbc.Visible = true;
            }
        }//use barcode scanner or manual input

        private void metroLink1_Click(object sender, EventArgs e)
        {
            using (payment pm = new payment(this))
            {
                transactionstylemanager.Clone(pm);
                decimal _subtotal = Convert.ToDecimal(dgtransaction.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDouble(t.Cells[1].Value)));
                pm.txtgrandtotal.Text = string.Format("{0:F2}", _grandtotal);
                rptinvoice.cashiername = cashier.Text;
                rptinvoice.vat = vat.Text;
                rptinvoice.subtotal = subtotal.Text;
                rptinvoice.discount = string.Format("P " + "{0:F2}", (_subtotal * (_discountvalue / 100)));
                rptinvoice.grandtotal = grandtotal.Text;
                pm.ShowDialog(this);
                txtautobc.Focus();
            }
        }
        private bool checkqty(decimal quantity, int dgquantity, string dgproductname)
        {
            using (SqlDataReader readercheckqty = Globals.ExecuteReader("quantitycheck", "@1", dgproductname))
            {
                if (readercheckqty.HasRows)
                {
                    while (readercheckqty.Read())
                    {
                        int productquantity = readercheckqty.GetInt32(0);
                        if (productquantity < quantity || productquantity < 1)
                        {
                            msg = string.Format("You have insufficient quantity of item: {0} " + "\n" + "Quantity of {0}: {1}", dgproductname, productquantity);
                            MetroMessageBox.Show(this, msg, "Insufficient stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return true;
                        }

                        else
                            return false;
                    }
                }
                return false;
            }
        }
        public void updatestocks()
        {
            foreach (DataGridViewRow dgrow in dgtransaction.Rows)
            {
                string[] editparameters = { "@1", "@2", };
                string[] editvalues = { Convert.ToString(dgrow.Cells[2].Value), Convert.ToString(dgrow.Cells[0].Value) };
                gs.Insert("updateproduct", editparameters, editvalues);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //if (dgtransaction.Rows.Count > 0)
            //    addquantity();

        }
        private void editqty(decimal numericvalue, string numerictext)
        {
            if (string.IsNullOrWhiteSpace(numerictext))
            {
                MetroMessageBox.Show(this, "Quantity can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkqty(numericvalue, Convert.ToInt32(this.dgtransaction.CurrentRow.Cells[2].Value), this.dgtransaction.CurrentRow.Cells[0].Value.ToString()) == false)
                {
                    using (SqlDataReader readercheckqty = Globals.ExecuteReader("editsqty", "@1", this.dgtransaction.CurrentRow.Cells[0].Value.ToString()))
                    {
                        if (readercheckqty.HasRows)
                        {
                            while (readercheckqty.Read())
                            {
                                double productprice = readercheckqty.GetDouble(0);
                                this.dgtransaction.CurrentRow.Cells[1].Value = string.Format("{0:F2}", Convert.ToDouble(numericvalue) * productprice);
                                this.dgtransaction.CurrentRow.Cells[2].Value = numericvalue;
                            }
                        }
                    }
                }
            }
        }
        private void dgtransaction_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgtransaction.Rows.Count == 0)
            {
                autopanel.Enabled = false;
                lnkpayment.Enabled = false;
                lnkeditqty2.Enabled = false;
                lnkdiscount.Enabled = false;
                lnkvoid.Enabled = false;
                Globals.ResetFields(groupBox1);
            }
        }
      
        public void cleartransaction()
        {
            Globals.ResetFields(groupBox1);
            dgtransaction.Rows.Clear();
            txtautobc.Clear();
        }
        public void addtoinvoicetbl()
        {
            foreach (DataGridViewRow dgrow in dgtransaction.Rows)
            {
                string[] parameters = { "@1", "@2", "@3" };
                string[] values = { dgrow.Cells[0].Value.ToString(), dgrow.Cells[1].Value.ToString(), dgrow.Cells[2].Value.ToString() };
                gs.Insert("addtoinvoice", parameters, values);
            }
        }
        public void orderdetails()
        {
            foreach (DataGridViewRow dgrow in dgtransaction.Rows)
            {
                using (SqlDataReader readerpID = Globals.ExecuteReader("detailsoforder", "@1", dgrow.Cells[0].Value.ToString()))
                {
                    if (readerpID.HasRows)
                    {
                        while (readerpID.Read())
                        {
                            int productID = readerpID.GetInt32(0);
                            decimal productprice = Convert.ToDecimal(dgrow.Cells[1].Value);
                            decimal _discountedamount = productprice - (productprice * (_discountvalue / 100));
                            decimal _vatamount = _discountedamount * _vatpercent;
                            decimal total = _discountedamount + (_discountedamount * _vatpercent);
                            string[] parameters = { "@1", "@2", "@3" };
                            string[] values = { productID.ToString(), total.ToString(), dgrow.Cells[2].Value.ToString() };
                             gs.Insert("orderss", parameters, values);
                        }
                    }
                }
            }
        }

        private void lnkeditqty2_Click(object sender, EventArgs e)
        {
            editqty(txtquantity.Value, txtquantity.Text);
        }

        private void lnkeditqty1_Click(object sender, EventArgs e)
        {
            editqty(txtmodifyquantity.Value, txtmodifyquantity.Text);
            txtautobc.Focus();
        }

        private void lnkdiscount_Click(object sender, EventArgs e)
        {
            discount dsc = new discount(this);
            transactionstylemanager.Clone(dsc);
            dsc.ShowDialog(this);
            txtautobc.Focus();

        }

        private void discountpercent_TextChanged(object sender, EventArgs e)
        {
            getsummary();
        }
        private void labelvat_TextChanged(object sender, EventArgs e)
        {
            _vatpercent = Properties.Settings.Default.Vat / 100;
            getsummary();
        }

        private void metroLink1_Click_1(object sender, EventArgs e)
        {
            voidorder vo = new voidorder();
            transactionstylemanager.Clone(vo);
            vo.ShowDialog();
            txtautobc.Focus();
        }
        private void transaction_Load(object sender, EventArgs e)
        {
            labelvat.Text = String.Format("Vat Amount {0}%:", Properties.Settings.Default.Vat);
            if (transactionstylemanager.Theme == MetroThemeStyle.Dark)
            {
                Globals.ChangeForeColor(this);
                Globals.ChangeForeColor(autopanel);
            }
            populatecombobox();
        }

        private void txtautobc_Leave(object sender, EventArgs e)
        {

        }

        private void lnkfocusbc_Click(object sender, EventArgs e)
        {
            txtautobc.Focus();
        }

        private void dgtransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtautobc.Focus();
        }
    }
}
