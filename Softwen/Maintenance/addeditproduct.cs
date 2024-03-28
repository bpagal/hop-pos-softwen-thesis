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
using System.Text.RegularExpressions;

namespace Softwen.Maintenance
{
    public partial class addeditproduct : MetroForm
    {
        Globals gs = new Globals();
        private string connstring = (ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        private readonly maintenance mnt;
        public string productid = "";
        public string currentpname = "";
        public string currentpc = "";
        public string currentpbc = "";
        public addeditproduct(maintenance _maintenance)
        {
            mnt = _maintenance;
            InitializeComponent();
            TextBox tb = (TextBox)txtmaxquantity.Controls[1];
            tb.TextChanged += Tb_TextChanged;
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {

            if (txtmaxquantity.Value <= 0)
            {
                MetroMessageBox.Show(this, "Invalid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmaxquantity.Value = 1;
                txtmaxquantity.Focus();
            }
        }

        private bool checkmaxqty()
        {
            if (txtmaxquantity.Value <= 0)
            {
                MetroMessageBox.Show(this, "Invalid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmaxquantity.Value = 1;
                return true;
            }
            else
                return false;
        }
        private void saveproduct()
        {
            if (Globals.CheckFields(panelproduct, this) == false && checkmaxqty() == false)
            {
                string[] addparameters = { "@1", "@2", "@3", "@4", "@5", "@6", "@7" };
                string[] addvalues = { txtproductname.Text, txtbarcode.Text, txtprice.Text, getcategoryid().ToString(), txtdesc.Text, txtmaxquantity.Value.ToString(), txtproductcode.Text };
                if (checkproductname() == false && checkproductcode() == false && checkbarcode() == false)
                {
                    gs.Insert("saveproducts", addparameters, addvalues);
                    MetroMessageBox.Show(this, "Product successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gs.recorduseractivity("New Product", txtproductname.Text);
                    Globals.ResetFields(panelproduct);
                    this.Close();
                    mnt.selectproducts();
                }
            }
        }
        private void lnksave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmaxquantity.Text))
                MetroMessageBox.Show(this, "Quantity can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                saveproduct();

        }
        private bool checkproductname()
        {
            using (SqlDataReader productreader = Globals.ExecuteReader("SELECT productname FROM products WHERE productname = @1", "@1", txtproductname.Text))
            {
                if (productreader.Read() && currentpname != txtproductname.Text)
                {
                    MetroMessageBox.Show(this, "Product name: " + txtproductname.Text + " already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                else
                    return false;
            }
        }
        private bool checkproductcode()
        {
            using (SqlDataReader readerproductcode = Globals.ExecuteReader("SELECT productcode FROM products WHERE  productcode = @1", "@1", txtproductcode.Text))
            {
                if (readerproductcode.Read() && currentpc != txtproductcode.Text)
                {
                    MetroMessageBox.Show(this, "Product code: " + txtproductcode.Text + " already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (productreader.Read() && currentpbc != txtbarcode.Text)
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
        private int getcategoryid()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT categoryid FROM category WHERE categoryname = @1", con))
                {
                    cmd.Parameters.AddWithValue("@1", combobxcat.Text);
                    con.Open();
                    int categoryid = (int)cmd.ExecuteScalar();
                    return categoryid;
                }

            }
        }
        private void addeditproduct_Load(object sender, EventArgs e)
        {
            txtproductcode.KeyPress += Globals.NumbersOnly;
            txtbarcode.KeyPress += Globals.NumbersOnly;
            txtprice.KeyPress += Globals.NumbersOnly;
            if (mnt.maintenancestylemanager.Theme == MetroThemeStyle.Dark)
                Globals.ChangeForeColor(this);
            gs.populatecombobox(combobxcat, "SELECT categoryname FROM category", "categoryname", "categoryid");
        }
        private void editproduct()
        {
            if (checkproductname() == false && checkproductcode() == false && checkbarcode() == false)
            {
                if (Globals.CheckFields(panelproduct, this) == false && checkmaxqty() == false)
                {
                    string[] editparameters = { "@1", "@2", "@3", "@4", "@5", "@6", "@7", "@8" };
                    string[] editvalues = { txtproductname.Text, txtbarcode.Text, txtprice.Text, getcategoryid().ToString(), txtdesc.Text, txtmaxquantity.Value.ToString(), txtproductcode.Text, productid };
                    gs.Insert("editproducts", editparameters, editvalues);
                    MetroMessageBox.Show(this, "Product successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gs.recorduseractivity("Edit Product", txtproductname.Text);
                    Globals.ResetFields(panelproduct);
                    this.Close();
                    mnt.selectproducts();
                }
            }
        }
        private void lnkupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmaxquantity.Text))
                MetroMessageBox.Show(this, "Quantity can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                editproduct();
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
