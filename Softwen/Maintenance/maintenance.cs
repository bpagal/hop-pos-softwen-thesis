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
using MetroFramework;

namespace Softwen.Maintenance
{
    public partial class maintenance : UserControl
    {
        Globals gs = new Globals();
        public string categoryid = "";
        private static maintenance _maintenanceinstance;
        public static maintenance MaintenanceInstance
        {
            get
            {
                if (_maintenanceinstance == null)
                    _maintenanceinstance = new maintenance();

                return _maintenanceinstance;
            }
        }
        public maintenance()
        {
            InitializeComponent();
        }
        public void selectproducts()
        {
            gs.Select(@"SELECT products.productid, products.productname, products.productcode, products.barcode, products.quantity, products.price, category.categoryname, products.description, products.maxquantity, products.status FROM products INNER JOIN category ON category.categoryid = products.categoryid WHERE status = 'active'", dgproducts);
        }
        public void selectarchivedproducts()
        {
            gs.Select(@"SELECT products.productid, products.productname, products.productcode, products.barcode, products.quantity, products.price, category.categoryname, products.description, products.maxquantity, products.status FROM products INNER JOIN category ON category.categoryid = products.categoryid WHERE status = 'inactive'", dgarchivedproducts);
        }
        public void selectusers()
        {
            gs.Select("SELECT * FROM users", dgusers);
        }
        public void selectcategory()
        {
            gs.Select("SELECT * FROM category", dgcategories);
        }
        private void maintenance_Load(object sender, EventArgs e)
        {
            this.dgproducts.Columns[5].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("en-PH");
            this.dgarchivedproducts.Columns[5].DefaultCellStyle.Format = "C";
            this.dgarchivedproducts.Columns[5].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("en-PH");
            txtvat.Text = Properties.Settings.Default.Vat.ToString();
            txtname.Text = Properties.Settings.Default.StoreName;
            txtaddress.Text = Properties.Settings.Default.StoreAddess;
            txtwebsite.Text = Properties.Settings.Default.StoreWebsite;
            txtbranchid.Text = Properties.Settings.Default.StoreID;
            txtvname.Text = Properties.Settings.Default.SupplierName;
            txtvaddress.Text = Properties.Settings.Default.SupplierAddress;
            txtkey.Text = Properties.Settings.Default.VoidKey;
            txtvat.KeyPress += Globals.NumbersOnly;
            txtkey.KeyPress += Globals.NumbersOnly;
        }

        private void lnkadduser_Click(object sender, EventArgs e)
        {
            using (addedituser add = new addedituser(this))
            {
                maintenancestylemanager.Clone(add);
                add.lnkupdate.Enabled = false;
                add.ShowDialog(this);
            }
        }

        private void lnkedituser_Click(object sender, EventArgs e)
        {
            using (addedituser edit = new addedituser(this))
            {
                maintenancestylemanager.Clone(edit);
                edit.userid = this.dgusers.CurrentRow.Cells[0].Value.ToString();
                edit.txtfname.Text = this.dgusers.CurrentRow.Cells[1].Value.ToString();
                edit.txtlname.Text = this.dgusers.CurrentRow.Cells[2].Value.ToString();
                edit.txtuname.Text = this.dgusers.CurrentRow.Cells[4].Value.ToString();
                edit.txtpass.Text = this.dgusers.CurrentRow.Cells[5].Value.ToString();
                edit.lnksave.Enabled = false;
                edit.Text = "Modify User";
                edit.txtuname.ReadOnly = true;
                edit.ShowDialog(this);
            }
        }
        private void lnkremoveuser_Click(object sender, EventArgs e)
        {
            if (Globals.userid == this.dgusers.CurrentRow.Cells[0].Value.ToString())
                MetroMessageBox.Show(this, "Unable to delete current user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                gs.Delete("DELETE FROM users WHERE userid = @1", dgusers, this);
                gs.recorduseractivity("Delete User", this.dgusers.CurrentRow.Cells[4].Value.ToString());
                selectusers();
            }
        }
        private void filterproduct()
        {
            if (comboboxsp.SelectedIndex == 0)
                gs.Filter(@"SELECT products.productid, products.productcode, products.barcode, products.productname, products.quantity, products.price, category.categoryname, products.description,  products.maxquantity, products.status FROM products  INNER JOIN category ON category.categoryid = products.categoryid WHERE productname LIKE @1 AND status = 'active'", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 1)
                gs.Filter(@"SELECT products.productid, products.productcode, products.barcode, products.productname, products.quantity, products.price, category.categoryname, products.description,  products.maxquantity, products.status FROM products  INNER JOIN category ON category.categoryid = products.categoryid WHERE productcode LIKE @1 AND status = 'active'", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 2)
                gs.Filter(@"SELECT products.productid, products.productcode, products.barcode, products.productname, products.quantity, products.price, category.categoryname, products.description,  products.maxquantity, products.status FROM products  INNER JOIN category ON category.categoryid = products.categoryid WHERE category.categoryname LIKE @1 AND status = 'active'", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 3)
                gs.Filter(@"SELECT products.productid, products.productcode, products.barcode, products.productname, products.quantity, products.price, category.categoryname, products.description,  products.maxquantity, products.status FROM products  INNER JOIN category ON category.categoryid = products.categoryid WHERE price LIKE @1 AND status = 'active'", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 4)
                gs.Filter(@"SELECT products.productid, products.productcode, products.barcode, products.productname, products.quantity, products.price, category.categoryname, products.description,  products.maxquantity, products.status FROM products  INNER JOIN category ON category.categoryid = products.categoryid WHERE description LIKE @1 AND status = 'active'", txtsp.Text, dgproducts);
            else if (comboboxsp.SelectedIndex == 5)
                gs.Filter(@"SELECT products.productid, products.productcode, products.barcode, products.productname, products.quantity, products.price, category.categoryname, products.description,  products.maxquantity, products.status FROM products  INNER JOIN category ON category.categoryid = products.categoryid WHERE barcode LIKE @1 AND status = 'active'", txtsp.Text, dgproducts);
        }
        private void filteruser()
        {
            if (combobxsu.SelectedIndex == 0)
                gs.Filter(@"SELECT * FROM users WHERE CONCAT(users.fname, ' ', users.lname) LIKE @1", txtsu.Text, dgusers);
            else if (combobxsu.SelectedIndex == 2)
                gs.Filter(@"SELECT * FROM users WHERE usertype LIKE @1", txtsu.Text, dgusers);
            else if (combobxsu.SelectedIndex == 3)
                gs.Filter(@"SELECT * FROM users WHERE username LIKE @1", txtsu.Text, dgusers);
        }

        private void txtsu_TextChanged(object sender, EventArgs e)
        {
            filteruser();
        }
        private void txtsp_TextChanged(object sender, EventArgs e)
        {
            filterproduct();
        }

        private void lnkaddcat_Click(object sender, EventArgs e)
        {
            panelcat.Visible = true;
            lnkupdate.Enabled = false;
            lnksave.Enabled = true;
            txtcat.Clear();
            txtcat.Focus();
        }

        private void lnkeditcat_Click(object sender, EventArgs e)
        {
            categoryid = this.dgcategories.CurrentRow.Cells[0].Value.ToString();
            txtcat.Text = this.dgcategories.CurrentRow.Cells[1].Value.ToString();
            panelcat.Visible = true;
            lnksave.Enabled = false;
            lnkupdate.Enabled = true;
        }

        private void dgcategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcat.Text = this.dgcategories.CurrentRow.Cells[1].Value.ToString();
        }
        private bool checkcategory()
        {
            using (SqlDataReader productreader = Globals.ExecuteReader("SELECT categoryname FROM category WHERE categoryname = @1", "@1", txtcat.Text))
            {
                if (productreader.Read())
                {
                    MetroMessageBox.Show(this, "Category: " + txtcat.Text + " already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                else
                    return false;
            }
        }
        private void lnksave_Click(object sender, EventArgs e)
        {
            string[] addparameters = { "@1" };
            string[] addvalues = { txtcat.Text };
            if (string.IsNullOrWhiteSpace(txtcat.Text))
                MetroMessageBox.Show(this, "Category is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (checkcategory() == false)
                {
                    gs.Insert("INSERT INTO category(categoryname) VALUES (@1)", addparameters, addvalues);
                    MetroMessageBox.Show(this, "Category successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gs.recorduseractivity("New Category", txtcat.Text);
                    txtcat.Clear();
                    panelcat.Visible = false;
                    selectcategory();
                }
            }
        }
        private void updatecategory()
        {
            if (string.IsNullOrWhiteSpace(txtcat.Text))
                MetroMessageBox.Show(this, "Category is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string[] editparameters = { "@1", "@2" };
                string[] editvalues = { txtcat.Text, categoryid };
                gs.Insert("UPDATE category set categoryname = @1 WHERE categoryid = @2", editparameters, editvalues);
                MetroMessageBox.Show(this, "Category successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gs.recorduseractivity("Edit Category", txtcat.Text);
                txtcat.Clear();
                panelcat.Visible = false;
                selectcategory();
            }
        }
        private void lnkupdate_Click(object sender, EventArgs e)
        {
            if (txtcat.Text == this.dgcategories.CurrentRow.Cells[1].Value.ToString())
            {
                updatecategory();
            }
            else
            {
                if (checkcategory() == false)
                {
                    updatecategory();
                }
            }

        }

        private void lnkdeletecat_Click(object sender, EventArgs e)
        {
            gs.Delete("DELETE FROM category WHERE categoryid = @1", dgcategories, this);
            gs.recorduseractivity("Delete Category", this.dgcategories.CurrentRow.Cells[1].Value.ToString());
            selectcategory();
        }
        private bool checkvat()
        {
            if (txtvat.Text == "0")
            {
                MetroMessageBox.Show(this, "Invalid Vat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtvat.Text = Properties.Settings.Default.Vat.ToString();
                txtvat.Focus();
                return true;
            }
            else
                return false;
        }
        private void lnkvat_Click(object sender, EventArgs e)
        {
            if (Globals.CheckFields(metroTabPage3, this) == false && checkvat() == false)
            {
                Properties.Settings.Default.Vat = Convert.ToDecimal(txtvat.Text);
                Properties.Settings.Default.StoreName = txtname.Text;
                Properties.Settings.Default.StoreAddess = txtaddress.Text;
                Properties.Settings.Default.StoreWebsite = txtwebsite.Text;
                Properties.Settings.Default.StoreID = txtbranchid.Text;
                Properties.Settings.Default.VoidKey = txtkey.Text;
                Properties.Settings.Default.Save();
                Transaction.transaction.TransactionInstance._vatpercent = Properties.Settings.Default.Vat / 100;
                Transaction.transaction.TransactionInstance.labelvat.Text = String.Format("Vat Amount {0}%:", Properties.Settings.Default.Vat);
                Dashboard.dashboard ds = new Dashboard.dashboard();
                MetroMessageBox.Show(this, "Settings successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void metroTabPage3_Leave(object sender, EventArgs e)
        {
            checkvat();
        }

        private void lnkaddproduct_Click(object sender, EventArgs e)
        {
            using (addeditproduct add = new addeditproduct(this))
            {
                maintenancestylemanager.Clone(add);
                add.lnkupdate.Enabled = false;
                add.ShowDialog(this);
            }
        }

        private void lnkeditproduct_Click(object sender, EventArgs e)
        {

            using (addeditproduct edit = new addeditproduct(this))
            {
                if (dgproducts.Rows.Count > 0)
                {
                    maintenancestylemanager.Clone(edit);
                    edit.productid = this.dgproducts.CurrentRow.Cells[0].Value.ToString();
                    edit.txtproductname.Text = this.dgproducts.CurrentRow.Cells[1].Value.ToString();
                    edit.txtproductcode.Text = this.dgproducts.CurrentRow.Cells[2].Value.ToString();
                    edit.txtbarcode.Text = this.dgproducts.CurrentRow.Cells[3].Value.ToString();
                    edit.txtprice.Text = this.dgproducts.CurrentRow.Cells[5].Value.ToString();
                    edit.txtdesc.Text = this.dgproducts.CurrentRow.Cells[7].Value.ToString();
                    edit.txtmaxquantity.Value = Convert.ToDecimal(this.dgproducts.CurrentRow.Cells[8].Value);
                    edit.currentpname = this.dgproducts.CurrentRow.Cells[1].Value.ToString();
                    edit.currentpc = this.dgproducts.CurrentRow.Cells[2].Value.ToString();
                    edit.currentpbc = this.dgproducts.CurrentRow.Cells[3].Value.ToString();
                    edit.combobxcat.Text = this.dgproducts.CurrentRow.Cells[5].Value.ToString();
                    edit.lnksave.Enabled = false;
                    edit.Text = "Modify Product";
                    edit.ShowDialog(this);
                }
            }
        }

        private void lnkdeleteproduct_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to archive this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                string[] archiveparameters = { "@1", "@2" };
                string[] archivevalues = { "inactive", this.dgproducts.CurrentRow.Cells[0].Value.ToString() };
                gs.Insert("UPDATE products SET products.status = @1 WHERE productid = @2", archiveparameters, archivevalues);
                gs.recorduseractivity("Archive Product", this.dgproducts.CurrentRow.Cells[1].Value.ToString());
                MetroMessageBox.Show(this, "Product successfully archived", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectproducts();
                selectarchivedproducts();
            }
        }
        public void mproductbuttons()
        {
            if (dgproducts.Rows.Count == 0)
            {
                lnkeditproduct.Visible = false;
                lnkdeleteproduct.Visible = false;
            }
            else if (dgproducts.Rows.Count > 0)
            {
                lnkeditproduct.Visible = true;
                lnkdeleteproduct.Visible = true;
            }
        }
        public void mcatbuttons()
        {
            if (dgcategories.Rows.Count == 0)
            {
                lnkeditcat.Visible = false;
                lnkdeletecat.Visible = false;
            }
            else if (dgcategories.Rows.Count > 0)
            {
                lnkeditcat.Visible = true;
                lnkdeletecat.Visible = true;
            }
        }
        public void marchivedbuttons()
        {
            if (dgarchivedproducts.Rows.Count == 0)
                lnkunarchive.Visible = false;
            else if (dgarchivedproducts.Rows.Count > 0)
                lnkunarchive.Visible = true;
        }
        private void dgproducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            mproductbuttons();
        }

        private void dgproducts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            mproductbuttons();
        }

        private void dgcategories_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            mcatbuttons();
        }

        private void dgcategories_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            mcatbuttons();
        }

        private void lnkbackup_Click(object sender, EventArgs e)
        {
            backupdb db1 = new backupdb();
            db1.lnkrestore.Enabled = false;
            db1.ShowDialog();
        }

        private void lnkrestore_Click(object sender, EventArgs e)
        {
            backupdb db2 = new backupdb();
            db2.lnkbackup.Enabled = false;
            db2.Text = "Restore Database";
            db2.ShowDialog();
        }

        private void lnkunarchive_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure you want to unarchive this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                string[] archiveparameters = { "@1", "@2" };
                string[] archivevalues = { "active", this.dgarchivedproducts.CurrentRow.Cells[0].Value.ToString() };
                gs.Insert("UPDATE products SET products.status = @1 WHERE productid = @2", archiveparameters, archivevalues);
                gs.recorduseractivity("Unarchive Product", this.dgarchivedproducts.CurrentRow.Cells[1].Value.ToString());
                MetroMessageBox.Show(this, "Product successfully unarchived", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectarchivedproducts();
                selectproducts();
            }
        }

        private void comboboxsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterproduct();
        }

        private void dgarchivedproducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            marchivedbuttons();
        }

        private void dgarchivedproducts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            marchivedbuttons();
        }
    }
}
