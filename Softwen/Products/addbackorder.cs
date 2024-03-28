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
            if (gs.validateemptyqty(txtquantity, this) == false)
            {
                this.dgrestockbo.CurrentRow.Cells[5].Value = txtquantity.Value;
            }
        }
        private bool checkqty()
        {
            var flag = 0;
            foreach (DataGridViewRow row in dgrestockbo.Rows)
            {
                if (row.Cells[5].Value != null)
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
        private void inputlogic()
        {
            labelquantity.Text = "Specify Quantity for:\r\n" + dgrestockbo.CurrentRow.Cells[0].Value.ToString();
            txtquantity.Value = txtquantity.Maximum = Convert.ToDecimal(dgrestockbo.CurrentRow.Cells[2].Value) - Convert.ToDecimal(dgrestockbo.CurrentRow.Cells[3].Value);
        }

        private void addbackorder_Load(object sender, EventArgs e)
        {
            inputlogic();
        }
        private string getpostatus(int deliveredqty, int orderedqty, int lastdeliveredqty)
        {
            string postatus = "";
            if (deliveredqty + lastdeliveredqty == orderedqty)
            {
                postatus = "delivered";
            }
            else if (deliveredqty != orderedqty)
            {
                postatus = "pending";
            }
            return postatus;
        }
        private string getstatus(int deliveredqty, int orderedqty, int lastdeliveredqty)
        {
            string status = "";
            if (deliveredqty + lastdeliveredqty == orderedqty)
            {
                status = "complete";
            }
            else
            {
                status = "incomplete";
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
                if (dgrv.Cells[5].Value != null)
                {
                    string productname = Convert.ToString(dgrv.Cells[0].Value);
                    int qtycurrent = Convert.ToInt32(dgrv.Cells[1].Value);
                    int qtyordered = Convert.ToInt32(dgrv.Cells[2].Value);
                    int lastdeliveredqty = Convert.ToInt32(dgrv.Cells[3].Value);
                    int productid = Convert.ToInt32(dgrv.Cells[4].Value);
                    int qtydelivered = Convert.ToInt32(dgrv.Cells[5].Value);
                    int qtyafter = qtycurrent + qtydelivered;
                    string rsstatus = getstatus(qtydelivered, qtyordered, lastdeliveredqty);
                    string postatus = getpostatus(qtydelivered, qtyordered,lastdeliveredqty);
                    string[] editparameters = { "@1", "@2" };
                    string[] editvalues = { qtydelivered.ToString(), productid.ToString() };
                    gs.Insert("updatestocks", editparameters, editvalues);
                    string[] restockparameters = { "@1", "@2", "@3", "@4", "@5" };
                    string[] restockvalues = { qtydelivered.ToString(), qtyafter.ToString(), rsstatus, DateTime.Now.ToString(("MM/dd/yyyy hh:mm tt")), rsid };
                    gs.Insert("updaterestocks", restockparameters, restockvalues);
                    string[] poparameters = { "@1", "@2", "@3" };
                    string[] povalues = { postatus, ponumber, productid.ToString() };
                    gs.Insert("restokss", poparameters, povalues);
                    gs.recorduseractivity("Update Restock", productname);
                    this.Close();
                    products.ProductsInstance.selectbackorders();
                } 
            }
            MetroMessageBox.Show(this, "Product quantity increased", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void lnkcomplete_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to proceed with these backorders?", "Confirm backorder", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (checkqty() == false)
                {
                    increaseqty();
                }
            }
        }
    }
}
