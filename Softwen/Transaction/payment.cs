using MetroFramework;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwen.Transaction
{
    public partial class payment : MetroForm
    {
        Globals gs = new Globals();
        public string connstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString; //connection string
        private readonly transaction trs;
        public payment(transaction _transaction)
        {
            trs = _transaction;
            InitializeComponent();
            //txtamountpaid.KeyPress += (Globals.NumbersOnly);
        }
        private void txtamountpaid_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtamountpaid.Text))
                txtchange.Clear();
            else
            {
                decimal change = Convert.ToDecimal(txtamountpaid.Text) - Convert.ToDecimal(txtgrandtotal.Text);
                txtchange.Text = string.Format("{0:F2}", change);
            }
        }

        private void processpayment()
        {
            string[] parameters = { "@1", "@2", "@3", "@4", "@5" };
            string[] values = { DateTime.Now.ToString(("MM/dd/yyyy hh:mm tt")), txtgrandtotal.Text, txtamountpaid.Text, Globals.userid, transaction.TransactionInstance.discountstatus };
            gs.Insert("payment", parameters, values);
            trs.updatestocks();
            trs.orderdetails();
            MetroMessageBox.Show(this, "Transaction completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gs.recorduseractivity("Transaction", "None");
            this.Close();

        }

        private void lnkpayment_Click(object sender, EventArgs e)
        {
            if (Globals.CheckFields(panelpayment, this) == false)
            {
                if (Convert.ToDouble(txtchange.Text) < 0)
                    MetroMessageBox.Show(this, "Insufficient amount paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (ivtoggle.Checked)
                    {
                        processpayment();
                        trs.addtoinvoicetbl();
                        transaction.TransactionInstance.cleartransaction();
                        rptinvoice rpti = new rptinvoice();
                        trs.transactionstylemanager.Clone(rpti);
                        rpti.cash = "P " + string.Format("{0:F2}", Convert.ToDecimal(txtamountpaid.Text));
                        rpti.change = "P " + string.Format("{0:F2}", txtchange.Text);
                        rpti.discounttype = transaction.TransactionInstance.discountstatus;
                        rpti.ShowDialog();
                        cleartbl();
                    }
                    else
                    {
                        processpayment();
                        transaction.TransactionInstance.cleartransaction();
                    }
                        
                }

            }
        }
        private void cleartbl()
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                SqlCommand cmd = new SqlCommand("TRUNCATE TABLE tempinvoice", con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void txtamountpaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.') || e.KeyChar == '.' && txtamountpaid.Text.Contains(".") || Regex.IsMatch(txtamountpaid.Text, @"\.\d\d"))
                e.Handled = true;          
        }

        private void payment_Load(object sender, EventArgs e)
        {
            txtamountpaid.ContextMenu = new ContextMenu();
        }
    }
}
