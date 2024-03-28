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
    public partial class addbackorder : MetroForm
    {
        public string ponumber = "", rsid = "";
        Globals gs = new Globals();
        public addbackorder()
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
        private void lnkadd_Click(object sender, EventArgs e)
        {
            Globals gs = new Globals();
            if (gs.validatequantity(txtquantity, this) == false)
            {
                this.dgrestockbo.CurrentRow.Cells[5].Value = txtquantity.Value;
            }
        }
        private bool checkqty()
        {
            foreach (DataGridViewRow row in dgrestockbo.Rows)
            {
                if (row.Cells[5].Value == null)
                {
                    MetroMessageBox.Show(this, "Quantity not specified on " + Convert.ToString(row.Cells[0].Value), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
        private void inputlogic()
        {
            labelquantity.Text = "Specify Quantity for: " + dgrestockbo.CurrentRow.Cells[0].Value.ToString();
            txtquantity.Value = txtquantity.Maximum = Convert.ToDecimal(dgrestockbo.CurrentRow.Cells[2].Value) - Convert.ToDecimal(dgrestockbo.CurrentRow.Cells[3].Value);
        }

        private void addbackorder_Load(object sender, EventArgs e)
        {
            inputlogic();
        }
        private string getstatus(int deliveredqty, int orderedqty, int lastdeliveredqty)
        {
            string status = "";
            if (deliveredqty + lastdeliveredqty == orderedqty)
            {
                status = "Complete";
            }
            else
            {
                status = "Incomplete";
            }
            return status;
        }
        private void dgrestockbo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            inputlogic();
        }

        private void dgrestockbo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            inputlogic();
        }
        private void increaseqty()
        {
            foreach (DataGridViewRow dgrv in dgrestockbo.Rows)
            {
                string productname = Convert.ToString(dgrv.Cells[0].Value);
                int qtycurrent = Convert.ToInt32(dgrv.Cells[1].Value);
                int qtyordered = Convert.ToInt32(dgrv.Cells[2].Value);
                int lastdeliveredqty = Convert.ToInt32(dgrv.Cells[3].Value);
                int productid = Convert.ToInt32(dgrv.Cells[4].Value);
                int qtydelivered = Convert.ToInt32(dgrv.Cells[5].Value);
                int qtyafter = qtycurrent + qtydelivered;
                string status = getstatus(qtydelivered, qtyordered, lastdeliveredqty);
                string[] editparameters = { "@1", "@2" };
                string[] editvalues = { qtydelivered.ToString(), productid.ToString() };
                gs.Insert("UPDATE products SET quantity = quantity + @1 WHERE productid = @2", editparameters, editvalues);
                string[] restockparameters = { "@1", "@2", "@3", "@4", "@5" };
                string[] restockvalues = { qtydelivered.ToString(), qtyafter.ToString(), status, DateTime.Now.ToString(("MM/dd/yyyy hh:mm tt")), rsid };
                gs.Insert("UPDATE restocks SET restockquantity = restockquantity + @1, quantityafter = @2, status = @3, restockdate = @4 WHERE restockid = @5", restockparameters, restockvalues);
                gs.recorduseractivity("Update Restock", productname);
                this.Close();
                products.ProductsInstance.selectbackorders();
                
            }
            MetroMessageBox.Show(this, "Product quantity increased 2", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void lnkcomplete_Click(object sender, EventArgs e)
        {

            if (checkqty() == false)
            {
                increaseqty();
            }
        }
    }
}
