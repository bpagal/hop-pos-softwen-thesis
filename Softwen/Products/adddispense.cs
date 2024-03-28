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
    public partial class adddispense : MetroForm
    {
        Globals gs = new Globals();
        public string productid = "";
        public adddispense()
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
            if (MetroMessageBox.Show(this, "Are you sure you want to proceed with these quantities?", "Confirm dispense", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (gs.validateemptyqty(txtquantity, this) == false && Globals.CheckFields(paneldispense, this) == false)
                    addtodispense();
            }
        }

        private void addtodispense()
        {
            int reducedqty = -Convert.ToInt32(txtquantity.Value);
            string[] editparameters = { "@1", "@2" };
            string[] editvalues = { reducedqty.ToString(), productid.ToString() };
            gs.Insert("updatestocks", editparameters, editvalues);
            string[] addparameters = { "@1", "@2", "@3", "@4", "@5" };
            string[] addvalues = { productid, txtquantity.Value.ToString(), txtcomment.Text, txtreason.Text, Globals.userid };
            gs.Insert("addtodispense", addparameters, addvalues);
            MetroMessageBox.Show(this, "Lost quantity successfully processed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            products.ProductsInstance.selectdispense();
            products.ProductsInstance.selectproducts();
        }
    }
}
