using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwen.Products
{
    public partial class addstocks : MetroForm
    {
        public string ponumber = "";
        Globals gs = new Globals();
        public addstocks()
        {
            InitializeComponent();
            TextBox tb = (TextBox)txtquantity.Controls[1];
            tb.TextChanged += Tb_TextChanged;
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            if (txtquantity.Value <= 0 || txtquantity.Value > txtquantity.Maximum)
            {
                MetroMessageBox.Show(this, "Invalid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquantity.Value = txtquantity.Maximum;
                txtquantity.Focus();
            }
        }
        private bool checkqty()
        {
            foreach (DataGridViewRow row in dgrestock.Rows)
            {
                if (row.Cells[4].Value == null)
                {
                    MetroMessageBox.Show(this, "Quantity not specified on " + Convert.ToString(row.Cells[0].Value), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
        private string getstatus(int deliveredqty, int orderedqty)
        {
            string status = "";
            if (deliveredqty == orderedqty)
            {
                status = "Complete";
            }
            else
            {
                status = "Incomplete";
            }
            return status;
        }
        private void increaseqty()
        {
            foreach (DataGridViewRow dgrv in dgrestock.Rows)
            {
                string productname = Convert.ToString(dgrv.Cells[0].Value);
                int qtycurrent = Convert.ToInt32(dgrv.Cells[1].Value);
                int qtyordered = Convert.ToInt32(dgrv.Cells[2].Value);
                int productid = Convert.ToInt32(dgrv.Cells[3].Value);
                int qtydelivered = Convert.ToInt32(dgrv.Cells[4].Value);
                int qtyafter = qtycurrent + qtydelivered;
                string status = getstatus(qtydelivered, qtyordered);
                string[] editparameters = { "@1", "@2" };
                string[] editvalues = { qtydelivered.ToString(), productid.ToString() };
                gs.Insert("UPDATE products SET quantity = quantity + @1 WHERE productid = @2", editparameters, editvalues);
                string[] restockparameters = { "@1", "@2", "@3", "@4", "@5", "@6", "@7" };
                string[] restockvalues = { Globals.userid, DateTime.Now.ToString(("MM/dd/yyyy hh:mm tt")), productid.ToString(), qtydelivered.ToString(), qtyafter.ToString(), ponumber, status };
                gs.Insert("INSERT INTO restocks (userid,restockdate,productid,restockquantity,quantityafter,ponumber,status) VALUES (@1,@2,@3,@4,@5,@6,@7)", restockparameters, restockvalues);
                string[] poparameters = { "@1", "@2" };
                string[] povalues = { "processed", ponumber };
                gs.Insert("UPDATE purchaseorder SET status = @1 WHERE ponumber = @2", poparameters, povalues);
                gs.recorduseractivity("Restock", productname);
                this.Close();
                products.ProductsInstance.selectdelivered();
            }
            MetroMessageBox.Show(this, "Product quantity increased", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void lnkcomplete_Click(object sender, EventArgs e)
        {
            if (checkqty() == false)
            {
                increaseqty();
            }


        }
        private void inputlogic()
        {
            labelquantity.Text = "Specify Quantity for: " + dgrestock.CurrentRow.Cells[0].Value.ToString();
            txtquantity.Value = txtquantity.Maximum = Convert.ToDecimal(dgrestock.CurrentRow.Cells[2].Value);
        }

        private void addstocks_Load(object sender, EventArgs e)
        {
            inputlogic();
        }

        private void dgrestock_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            inputlogic();
        }

        private void dgrestock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            inputlogic();
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
            if (checkifempty() == false)
            {
                this.dgrestock.CurrentRow.Cells[4].Value = txtquantity.Value;
            }
        }
    }
}
