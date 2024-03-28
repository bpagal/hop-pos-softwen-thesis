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
using Softwen.Home;
using Softwen.Maintenance;
using Softwen.Transaction;
using Softwen.Reports;
using Softwen.Products;
using Softwen.UserActivity;

namespace Softwen.Dashboard
{
    public partial class dashboard : MetroForm
    {

        public dashboard()
        {
            InitializeComponent();
            login.Main ms = new login.Main(); //burahin to pag sa login na magsstart ang program
            this.StyleManager = ms.StyleManager; //burahin to pag sa login na magsstart ang program
        }

        private void lnkmenu_Click(object sender, EventArgs e)
        {
            if (panelmenu.Width == 50)
            {
                panelmenu.Visible = false;
                panelmenu.Width = 165;
                this.generalpanel.Location = new Point(170, 43);
                sidemenuanimator.ShowSync(panelmenu);
                logoanimator.ShowSync(hoplogo);

            }
            else
            {
                logoanimator.HideSync(hoplogo);
                panelmenu.Visible = false;
                panelmenu.Width = 50;
                this.generalpanel.Location = new Point(61, 43);
                sidemenuanimator.ShowSync(panelmenu);
                sidemenuanimator.ShowSync(btnsales);
            }
        }
        private void showhome()
        {
            if (!generalpanel.Controls.Contains(home.HomeInstance))
            {
                home.HomeInstance.homestylemanager.Style = this.StyleManager.Style;
                home.HomeInstance.homestylemanager.Theme = this.StyleManager.Theme;
                generalpanel.Controls.Add(home.HomeInstance);
                home.HomeInstance.Dock = DockStyle.Fill;
                home.HomeInstance.BringToFront();
                home.HomeInstance.showstats();

            }
            else
            {
                home.HomeInstance.BringToFront();
            }
        }
        private void showmaintenance()
        {
            if (!generalpanel.Controls.Contains(maintenance.MaintenanceInstance))
            {
                maintenance.MaintenanceInstance.maintenancestylemanager.Style = this.StyleManager.Style;
                maintenance.MaintenanceInstance.maintenancestylemanager.Theme = this.StyleManager.Theme;
                generalpanel.Controls.Add(maintenance.MaintenanceInstance);
                maintenance.MaintenanceInstance.Dock = DockStyle.Fill;
                maintenance.MaintenanceInstance.BringToFront();

            }
            else
            {
                maintenance.MaintenanceInstance.BringToFront();
            }


        }
        private void showproducts()
        {
            if (!generalpanel.Controls.Contains(products.ProductsInstance))
            {
                products.ProductsInstance.productstylemanager.Style = this.StyleManager.Style;
                products.ProductsInstance.productstylemanager.Theme = this.StyleManager.Theme;
                generalpanel.Controls.Add(products.ProductsInstance);
                products.ProductsInstance.Dock = DockStyle.Fill;
                products.ProductsInstance.BringToFront();
            }
            else
            {
                products.ProductsInstance.BringToFront();
            }
        }
        private void showtransaction()
        {
            if (!generalpanel.Controls.Contains(transaction.TransactionInstance))
            {
                transaction.TransactionInstance.transactionstylemanager.Style = this.StyleManager.Style;
                transaction.TransactionInstance.transactionstylemanager.Theme = this.StyleManager.Theme;
                generalpanel.Controls.Add(transaction.TransactionInstance);
                transaction.TransactionInstance.Dock = DockStyle.Fill;
                transaction.TransactionInstance.BringToFront();
            }
            else
            {
                transaction.TransactionInstance.BringToFront();
            }
        }
        private void showreports()
        {
            if (!generalpanel.Controls.Contains(reports.ReportsInstance))
            {
                reports.ReportsInstance.reportsstylemanager.Style = this.StyleManager.Style;
                reports.ReportsInstance.reportsstylemanager.Theme = this.StyleManager.Theme;
                generalpanel.Controls.Add(reports.ReportsInstance);
                reports.ReportsInstance.Dock = DockStyle.Fill;
                reports.ReportsInstance.BringToFront();
            }
            else
            {
                reports.ReportsInstance.BringToFront();
            }
        }
        private void showuseractivity()
        {
            if (!generalpanel.Controls.Contains(useract.UseractivityInstance))
            {
                useract.UseractivityInstance.useractstylemanager.Style = this.StyleManager.Style;
                useract.UseractivityInstance.useractstylemanager.Theme = this.StyleManager.Theme;
                generalpanel.Controls.Add(useract.UseractivityInstance);
                useract.UseractivityInstance.Dock = DockStyle.Fill;
                useract.UseractivityInstance.BringToFront();
            }
            else
            {
                useract.UseractivityInstance.BringToFront();
            }
        }
        private void btnhome_Click(object sender, EventArgs e)
        {
            if (transaction.TransactionInstance.verifytransaction() == false)
            {
                controlanimator.HideSync(maintenance.MaintenanceInstance.maintenancetabcontrol);
                controlanimator.HideSync(transaction.TransactionInstance.transactionpanel);
                controlanimator.HideSync(reports.ReportsInstance.reportstabcontrol);
                controlanimator.HideSync(products.ProductsInstance.productstabcontrol);
                controlanimator.HideSync(useract.UseractivityInstance.paneluseract);
                controlanimator.HideSync(labelmodule);
                showhome();
                labelmodule.Text = "Dashboard";
                controlanimator.ShowSync(labelmodule);
                home.HomeInstance.showstats();
                home.HomeInstance.topseller.Series.Clear();
                if (home.HomeInstance.topseller.Series.IndexOf("Products") != -1)
                {
                    return;
                }
                else
                {
                    home.HomeInstance.topseller.Series.Add("Products");
                    home.HomeInstance.topseller.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
                    home.HomeInstance.loadchart();
                }
                controlanimator.ShowSync(home.HomeInstance.homepanel);
            }
            
        }
        private void btnsales_Click(object sender, EventArgs e)
        {
            controlanimator.HideSync(home.HomeInstance.homepanel);
            controlanimator.HideSync(maintenance.MaintenanceInstance.maintenancetabcontrol);
            controlanimator.HideSync(reports.ReportsInstance.reportstabcontrol);
            controlanimator.HideSync(products.ProductsInstance.productstabcontrol);
            controlanimator.HideSync(useract.UseractivityInstance.paneluseract);
            controlanimator.HideSync(labelmodule);
            showtransaction();
            labelmodule.Text = "Transaction";
            controlanimator.ShowSync(labelmodule);
            transaction.TransactionInstance.fullname = this.labelname.Text;
            controlanimator.ShowSync(transaction.TransactionInstance.transactionpanel);
            transaction.TransactionInstance.txtautobc.Focus();
            transaction.TransactionInstance.populatecombobox();
        }

        private void lnkclose_Click(object sender, EventArgs e)
        {
            if(transaction.TransactionInstance.verifytransaction()==false)
            {
                if (MetroMessageBox.Show(this, "Are you sure you want to exit?", "Confirm close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void lnkminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            if (transaction.TransactionInstance.verifytransaction() == false)
            {
                controlanimator.HideSync(home.HomeInstance.homepanel);
                controlanimator.HideSync(maintenance.MaintenanceInstance.maintenancetabcontrol);
                controlanimator.HideSync(transaction.TransactionInstance.transactionpanel);
                controlanimator.HideSync(products.ProductsInstance.productstabcontrol);
                controlanimator.HideSync(useract.UseractivityInstance.paneluseract);
                controlanimator.HideSync(labelmodule);
                showreports();
                labelmodule.Text = "Reports";
                controlanimator.ShowSync(labelmodule);
                reports.ReportsInstance.populatecashier();
                reports.ReportsInstance.populateproducts();
                reports.ReportsInstance.dtdaily.Value = DateTime.Now;
                reports.ReportsInstance.dtstocks.Value = DateTime.Now;
                reports.ReportsInstance.selectsales();
                reports.ReportsInstance.selectstocks();
                reports.ReportsInstance.salesbuttons();
                reports.ReportsInstance.stockbuttons();
                controlanimator.ShowSync(reports.ReportsInstance.reportstabcontrol);
            }       
        }

        private void btnmaintenance_Click(object sender, EventArgs e)
        {
            if (transaction.TransactionInstance.verifytransaction() == false)
            {
                controlanimator.HideSync(home.HomeInstance.homepanel);
                controlanimator.HideSync(transaction.TransactionInstance.transactionpanel);
                controlanimator.HideSync(reports.ReportsInstance.reportstabcontrol);
                controlanimator.HideSync(products.ProductsInstance.productstabcontrol);
                controlanimator.HideSync(useract.UseractivityInstance.paneluseract);
                controlanimator.HideSync(labelmodule);
                showmaintenance();
                labelmodule.Text = "Maintenance";
                maintenance.MaintenanceInstance.comboboxsp.SelectedIndex = 0;
                maintenance.MaintenanceInstance.combobxsu.SelectedIndex = 0;
                maintenance.MaintenanceInstance.selectproducts();
                maintenance.MaintenanceInstance.selectarchivedproducts();
                maintenance.MaintenanceInstance.selectusers();
                maintenance.MaintenanceInstance.selectcategory();
                maintenance.MaintenanceInstance.mproductbuttons();
                maintenance.MaintenanceInstance.marchivedbuttons();
                maintenance.MaintenanceInstance.mcatbuttons();
                controlanimator.ShowSync(labelmodule);
                controlanimator.ShowSync(maintenance.MaintenanceInstance.maintenancetabcontrol);
            }               
        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            if (transaction.TransactionInstance.verifytransaction() == false)
            {
                controlanimator.HideSync(home.HomeInstance.homepanel);
                controlanimator.HideSync(transaction.TransactionInstance.transactionpanel);
                controlanimator.HideSync(reports.ReportsInstance.reportstabcontrol);
                controlanimator.HideSync(maintenance.MaintenanceInstance.maintenancetabcontrol);
                controlanimator.HideSync(useract.UseractivityInstance.paneluseract);
                controlanimator.HideSync(labelmodule);
                showproducts();
                labelmodule.Text = "Products";
                controlanimator.ShowSync(labelmodule);
                products.ProductsInstance.comboboxsp.SelectedIndex = 0;
                products.ProductsInstance.populatedatagrids();
                products.ProductsInstance.productbuttons();
                controlanimator.ShowSync(products.ProductsInstance.productstabcontrol);
                products.ProductsInstance.dispenselogic();
                products.ProductsInstance.displaylowqty();
            }     
        }

        private void lnklogout_Click(object sender, EventArgs e)
        {
            if (transaction.TransactionInstance.verifytransaction()==false)
            {
                if (MetroMessageBox.Show(this, "Are you sure you want to log out?", "Confirm logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Globals gs = new Globals();
                    gs.recorduseractivity("Logout", "None");
                    Application.Restart();
                }
            }        
        }

        private void btnuseract_Click(object sender, EventArgs e)
        {
            if (transaction.TransactionInstance.verifytransaction() == false)
            {
                controlanimator.HideSync(home.HomeInstance.homepanel);
                controlanimator.HideSync(transaction.TransactionInstance.transactionpanel);
                controlanimator.HideSync(reports.ReportsInstance.reportstabcontrol);
                controlanimator.HideSync(maintenance.MaintenanceInstance.maintenancetabcontrol);
                controlanimator.HideSync(products.ProductsInstance.productstabcontrol);
                controlanimator.HideSync(labelmodule);
                showuseractivity();
                labelmodule.Text = "User Activity";
                controlanimator.ShowSync(labelmodule);
                controlanimator.ShowSync(useract.UseractivityInstance.paneluseract);
                useract.UseractivityInstance.selectuseract();
            }     
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            labelstorename.Text = Properties.Settings.Default.StoreName;
            if (this.Theme == MetroThemeStyle.Dark)
            {
                Globals.ChangeForeColor(this);
            }
            showhome();
            controlanimator.ShowSync(labelmodule);
            controlanimator.ShowSync(home.HomeInstance.homepanel);
        }
    }
}
