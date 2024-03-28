using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Softwen.Products
{
    public partial class products : UserControl
    {
        Globals gs = new Globals();
        private static products _productsinstance;
        public static products ProductsInstance
        {
            get
            {
                if (_productsinstance == null)
                    _productsinstance = new products();

                return _productsinstance;
            }
        }
        public products()
        {
            InitializeComponent();
            selectproducts();
        }
        private void selectproducts()
        {
            gs.Select("SELECT * FROM products", dgproducts);
        }
        private void lnkadd_Click(object sender, EventArgs e)
        {

            using (addproduct add = new addproduct())
            {
                productstylemanager.Clone(add);
                add.ShowDialog(this);
                selectproducts();
            }


        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            using (modifyproduct edit = new modifyproduct())
            {
                if (dgproducts.Rows.Count > 0)
                {
                    edit.productid = this.dgproducts.CurrentRow.Cells[0].Value.ToString();
                    edit.txtproductname.Text = this.dgproducts.CurrentRow.Cells[1].Value.ToString();
                    edit.txtbarcode.Text = this.dgproducts.CurrentRow.Cells[2].Value.ToString();
                    edit.txtprice.Text = this.dgproducts.CurrentRow.Cells[3].Value.ToString();
                    edit.ShowDialog(this);
                    selectproducts();
                }
            }

        }

        private void lnkdelete_Click(object sender, EventArgs e)
        {
            gs.Delete("DELETE FROM products WHERE productid = @1", dgproducts, this);
            selectproducts();
        }

        private void lnkaddstock_Click(object sender, EventArgs e)
        {
            using (addstocks addstock = new addstocks())
            {
                if (dgproducts.Rows.Count != 0)
                {
                    addstock.productid = this.dgproducts.CurrentRow.Cells[0].Value.ToString();
                    addstock.txtproductname.Text = this.dgproducts.CurrentRow.Cells[1].Value.ToString();
                    addstock.ShowDialog(this);
                    selectproducts();
                }
            }
        }
    }
}
