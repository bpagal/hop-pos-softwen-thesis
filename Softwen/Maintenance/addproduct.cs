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
using System.Configuration;

namespace Softwen.Products
{
    public partial class addproduct : MetroForm
    {
        Globals gs = new Globals();
        public addproduct()
        {
            InitializeComponent();
            if (this.Theme == MetroThemeStyle.Dark)
            {
                labelproductname.ForeColor = Color.White;
                labelprice.ForeColor = Color.White;
                labelbarcode.ForeColor = Color.White;
            }

        }
        private void lnksave_Click(object sender, EventArgs e)
        {
            string[] addparameters = { "@1", "@2", "@3" };
            string[] addvalues = { txtproductname.Text, txtbarcode.Text, txtprice.Text };
            if (Globals.CheckFields(panelproduct, this) == false)
            {
                if (checkproductname() == false && checkbarcode() == false)
                {
                    gs.Insert("INSERT INTO products(productname,barcode,price) VALUES (@1,@2,@3)", addparameters, addvalues);
                    MetroMessageBox.Show(this, "Data successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Globals.ResetFields(panelproduct);
                    this.Close();
                }
            }
        }
        private bool checkproductname()
        {
            using (SqlDataReader productreader = Globals.ExecuteReader("SELECT productname FROM products WHERE productname = @1", "@1", txtproductname.Text))
            {
                if (productreader.Read())
                {
                    MetroMessageBox.Show(this, "Product name: " + txtproductname.Text + " already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                else
                    return false;
            }
        }
        private bool checkbarcode()
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
