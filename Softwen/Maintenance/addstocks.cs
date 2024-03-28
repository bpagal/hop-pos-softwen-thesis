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
        public string productid = "";
        public static string userid = "";
        public addstocks()
        {
            InitializeComponent();
        }

        private void lnksave_Click(object sender, EventArgs e)
        {
            if (txtquantity.Text == "0")
            {
                MetroMessageBox.Show(this, "Invalid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                increaseqty();
        }
        private void increaseqty()
        {
            string[] editparameters = { "@1", "@2" };
            string[] editvalues = { txtquantity.Text, productid };
            string[] deliveryparameters = { "@1", "@2", "@3", "@4" };
            string[] deliveryvalues = { userid, DateTime.Now.ToString(("MM/dd/yyyy hh:mm tt")), productid, txtquantity.Text, };
            Globals gs = new Globals();
            gs.Insert("UPDATE products SET quantity = quantity + @1 WHERE productid = @2", editparameters, editvalues);
            gs.Insert("INSERT INTO restocks (userid,deliverydate,productid,quantity) VALUES (@1,@2,@3,@4)", deliveryparameters, deliveryvalues);
            MetroMessageBox.Show(this, "Product quantity increased", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Globals.ResetFields(this);
            this.Close();
        }
    }
}
