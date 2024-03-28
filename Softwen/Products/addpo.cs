using MetroFramework;
using MetroFramework.Forms;
using Softwen.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwen.Products
{
    public partial class addpo : MetroForm
    {
        private readonly products pr;
        Globals gs = new Globals();
        public addpo(products _products)
        {
            pr = _products;
            InitializeComponent();
            TextBox tb = (TextBox)txtquantity.Controls[1];
            tb.TextChanged += Tb_TextChanged;
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            if (txtquantity.Value <= 0)
            {
                MetroMessageBox.Show(this, "Invalid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquantity.Value = 50;
                txtquantity.Focus();
            }
        }
        private bool checkmaxqty()
        {
            int currentqty = Convert.ToInt32(this.dgrestock.CurrentRow.Cells[4].Value);
            int maxqty = Convert.ToInt32(this.dgrestock.CurrentRow.Cells[5].Value);
            if (currentqty + txtquantity.Value > maxqty)
            {
                MetroMessageBox.Show(this, "Future quantity exceeded max quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
                return false;

        }
        private bool checkifempty()
        {
            if (string.IsNullOrWhiteSpace(txtquantity.Text))
            {
                MetroMessageBox.Show(this, "Quantity can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquantity.Focus();
                return true;
            }
            else
                return false;
        }
        private void lnkadd_Click(object sender, EventArgs e)
        {
            if (checkifempty() == false && checkmaxqty() == false)
            {
                int qtyafter = Convert.ToInt32(this.dgrestock.CurrentRow.Cells[4].Value) + Convert.ToInt32(txtquantity.Value);
                this.dgrestock.CurrentRow.Cells[1].Value = qtyafter.ToString();
            }



        }

        private void restock_Load(object sender, EventArgs e)
        {
            if (pr.productstylemanager.Theme == MetroThemeStyle.Dark)
                Globals.ChangeForeColor(this);
            dgrestock.CellContentClick += checkboxlogic;
            dgrestock.CellContentDoubleClick += checkboxlogic;
            dgrestock.CellClick += checkboxlogic;
            gs.Select("SELECT productid, productname, quantity, maxquantity FROM products WHERE products.status = 'active'", dgrestock);
            if (dgrestock.Rows.Count > 0)
                txtproductname.Text = this.dgrestock.CurrentRow.Cells[3].Value.ToString();
        }

        private void addtopo()
        {
            string[] poparameters = { "@1", "@2", "@3", "@4"};
            string[] povalues = { DateTime.Now.ToString(("MM/dd/yyyy hh:mm tt")), Globals.userid, Properties.Settings.Default.SupplierName, Properties.Settings.Default.SupplierAddress};
            gs.Insert("INSERT INTO purchaseorder (daterequested,userid,vendor,vendoraddress) VALUES (@1,@2,@3,@4)", poparameters, povalues);
        }

        private void addtopodetails()
        {
            foreach (DataGridViewRow dgrow in dgrestock.Rows)
            {
                bool ischecked = Convert.ToBoolean(dgrow.Cells[0].EditedFormattedValue);
                if (ischecked == true)
                {
                    int orderedqty = Convert.ToInt32(dgrow.Cells[1].Value) - Convert.ToInt32(dgrow.Cells[4].Value);
                    string[] poparameters = { "@1", "@2" };
                    string[] povalues = { Convert.ToString(dgrow.Cells[2].Value),orderedqty.ToString()};
                    gs.Insert("INSERT INTO podetails (ponumber,productid,orderedqty) VALUES ((SELECT IDENT_CURRENT('purchaseorder')),@1,@2)", poparameters, povalues);
                }

            }
        }
        private bool checkallcheckbox()
        {
            var flag = 0;
            foreach (DataGridViewRow row in dgrestock.Rows)
            {
                bool ischecked = Convert.ToBoolean(row.Cells[0].EditedFormattedValue);
                if (ischecked == true)
                {
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                MetroMessageBox.Show(this, "No product selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (flag == 1)
            {
                return false;
            }
            return false;
        }
        private bool checkqty()
        {
            foreach (DataGridViewRow row in dgrestock.Rows)
            {
                bool ischecked = Convert.ToBoolean(row.Cells[0].EditedFormattedValue);
                if (ischecked == true && row.Cells[1].Value == null)
                {
                    MetroMessageBox.Show(this, "Quantity not specified on " + Convert.ToString(row.Cells[3].Value), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        private void lnksave_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to proceed with these orders?", "Confirm order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (Globals.CheckFields(panelrestock, this) == false && checkqty() == false && checkallcheckbox() == false)
                {
                    addtopo();
                    addtopodetails();
                    MetroMessageBox.Show(this, "Order successful. Proceeding to generate P/O form", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    products.ProductsInstance.selectpurchaseorder();
                    rptpo rptpurchaseoder = new rptpo();
                    rptpurchaseoder.ShowDialog();
                }
            }

        }

        private void dgrestock_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgrestock.Rows.Count > 0)
                lnksave.Enabled = true;
        }

        private void dgrestock_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgrestock.Rows.Count < 1)
                lnksave.Enabled = false;
        }
        private void checkboxlogic(object sender, DataGridViewCellEventArgs e)
        {
            txtproductname.Text = this.dgrestock.CurrentRow.Cells[3].Value.ToString();
            txtquantity.Value = txtquantity.Maximum = Convert.ToDecimal(this.dgrestock.CurrentRow.Cells[5].Value) - Convert.ToDecimal(this.dgrestock.CurrentRow.Cells[4].Value);
            bool ischecked = Convert.ToBoolean(dgrestock.Rows[e.RowIndex].Cells[0].EditedFormattedValue);
            if (ischecked == true)
            {
                txtquantity.Visible = true;
                lnkadd.Visible = true;
                labelquantity.Visible = true;
            }
            else
            {
                txtquantity.Visible = false;
                lnkadd.Visible = false;
                labelquantity.Visible = false;
            }
        }
    }
}
