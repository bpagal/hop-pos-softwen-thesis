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
    public partial class missingproducts : MetroForm
    {
        public missingproducts()
        {
            InitializeComponent();
            TextBox tb = (TextBox)txtquantity.Controls[1];
            tb.TextChanged += Tb_TextChanged;
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtquantity.Value <= 0)
                {
                    MetroMessageBox.Show(this, "Invalid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtquantity.Value = 1;
                    txtquantity.Focus();
                }
            }
        }

        private void lnksave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtquantity.Text))
            {
                MetroMessageBox.Show(this, "Quantity can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtquantity.Focus();
            }
            else
                addtomissing();
        }

        private void addtomissing()
        {
            string[] addparameters = { "@1", "@2" };
            string[] addvalues = { products.ProductsInstance.dgproducts.CurrentRow.Cells[0].Value.ToString(), txtquantity.Value.ToString()};
            Globals gs = new Globals();
            gs.Insert("addtomissing", addparameters, addvalues);
            MetroMessageBox.Show(this, "Missing quantity successfully processed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            products.ProductsInstance.selectmissingproducts();
        }
    }
}
