using MetroFramework;
using MetroFramework.Forms;
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
    public partial class modifyproduct : MetroForm
    {
        public string productid = "";
        Globals gs = new Globals();
        addproduct add = new addproduct();
        public modifyproduct()
        {
            InitializeComponent();
        }

        private void lnksave_Click(object sender, EventArgs e)
        {
            string[] editparameters = { "@1", "@2", "@3", "@4" };
            string[] editvalues = { txtproductname.Text, txtbarcode.Text, txtprice.Text, productid};
            if (Globals.CheckFields(panelproduct,this)==false)
            {
                if (checkbarcode()==false)
                {
                    gs.Insert("UPDATE products SET productname = @1, barcode = @2, price = @3 WHERE productid = @4", editparameters, editvalues);
                    MetroMessageBox.Show(this, "Data successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Globals.ResetFields(panelproduct);
                    this.Close();
                }
            }
        }
        public bool checkbarcode()
        {
            using (SqlDataReader productreader = Globals.ExecuteReader("SELECT barcode FROM products WHERE barcode = @1", "@1", txtbarcode.Text))
            {
                if (productreader.Read())
                {
                    MetroMessageBox.Show(this, "Barcode: " + txtbarcode.Text + " already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                else
                    return false;
            }
        }
        private void lnkclear_Click(object sender, EventArgs e)
        {
            Globals.ResetFields(panelproduct);
        }
    }
}
