﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Softwen.Reports
{
    public partial class reports : UserControl
    {
        Globals gs = new Globals();
        private static reports _reportsinstance;
        public static reports ReportsInstance
        {
            get
            {
                if (_reportsinstance == null)
                    _reportsinstance = new reports();

                return _reportsinstance;
            }
        }
        public reports()
        {
            InitializeComponent();
        }
        public void populatecashier()
        {
            gs.populatecombobox(combobxcashier, "populationofcashier", "fullname", "userid");
        }
        public void populateproducts()
        {
            gs.populatecombobox(combobxproduct, "populationofproducts", "productname", "productid");
        }
        public void selectsales()
        {
            if (rd1.Checked)
            {
                if (chballcashier.Checked && chballproducts.Checked)
                {
                    string[] parameters = { "@1" };
                    string[] values = { dtdaily.Value.ToString("MM/dd/yyyy") };
                    gs.SelectWithParameters(@"salessales", parameters, values, dgsalesreport);
                }
                else if (!chballcashier.Checked && chballproducts.Checked)
                {
                    string[] parameters = { "@1", "@2" };
                    string[] values = { dtdaily.Value.ToString("MM/dd/yyyy"), combobxcashier.Text };
                    gs.SelectWithParameters(@"salessalesales", parameters, values, dgsalesreport);
                }
                else if (chballcashier.Checked && !chballproducts.Checked)
                {
                    string[] parameters = { "@1", "@2" };
                    string[] values = { dtdaily.Value.ToString("MM/dd/yyyy"), combobxproduct.Text };
                    gs.SelectWithParameters(@"sales3", parameters, values, dgsalesreport);
                }
                else if (!chballcashier.Checked && !chballproducts.Checked)
                {
                    string[] parameters = { "@1", "@2", "@3" };
                    string[] values = { dtdaily.Value.ToString("MM/dd/yyyy"), combobxcashier.Text, combobxproduct.Text };
                    gs.SelectWithParameters(@"saless55", parameters, values, dgsalesreport);
                }
            }
            else if (rd2.Checked)
            {

                if (chballcashier.Checked && chballproducts.Checked)
                {
                    string[] parameters = { "@1", "@2" };
                    string[] values = { dtstart.Value.ToString("MM/dd/yyyy"), dtend.Value.ToString("MM/dd/yyyy") };
                    gs.SelectWithParameters(@"reports100", parameters, values, dgsalesreport);
                }
                else if (!chballcashier.Checked && chballproducts.Checked)
                {
                    string[] parameters = { "@1", "@2", "@3" };
                    string[] values = { dtstart.Value.ToString("MM/dd/yyyy"), dtend.Value.ToString("MM/dd/yyyy"), combobxcashier.Text };
                    gs.SelectWithParameters(@"reports200", parameters, values, dgsalesreport);
                }
                else if (chballcashier.Checked && !chballproducts.Checked)
                {
                    string[] parameters = { "@1", "@2", "@3" };
                    string[] values = { dtstart.Value.ToString("MM/dd/yyyy"), dtend.Value.ToString("MM/dd/yyyy"), combobxproduct.Text };
                    gs.SelectWithParameters(@"reports300", parameters, values, dgsalesreport);
                }
                else if (!chballcashier.Checked && !chballproducts.Checked)
                {
                    string[] parameters = { "@1", "@2", "@3", "@4" };
                    string[] values = { dtstart.Value.ToString("MM/dd/yyyy"), dtend.Value.ToString("MM/dd/yyyy"), combobxcashier.Text, combobxproduct.Text };
                    gs.SelectWithParameters(@"reports400", parameters, values, dgsalesreport);
                }
            }
        }
        public void selectstocks()
        {
            if (rd11.Checked)
            {
                string[] stockparameters = { "@1" };
                string[] stockvalues = { dtstocks.Value.ToString("MM/dd/yyyy") };
                gs.SelectWithParameters(@"reports500", stockparameters, stockvalues, dgstockreport);
            }
            else if (rd12.Checked)
            {
                string[] stockparameters = { "@1", "@2" };
                string[] stockvalues = { dtstartstocks.Value.ToString("MM/dd/yyyy"), dtendstocks.Value.ToString("MM/dd/yyyy") };
                gs.SelectWithParameters(@"reports600", stockparameters, stockvalues, dgstockreport);
            }

        }

        private void dtdaily_ValueChanged(object sender, EventArgs e)
        {
            selectsales();
        }

        private void combobxcashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectsales();
        }

        private void chballproducts_CheckedChanged(object sender, EventArgs e)
        {
            if (!chballproducts.Checked)
            {
                combobxproduct.Visible = true;
                selectsales();
            }
            else
            {
                combobxproduct.Visible = false;
                selectsales();
            }

        }

        private void chballcashier_CheckedChanged(object sender, EventArgs e)
        {
            if (!chballcashier.Checked)
            {
                combobxcashier.Visible = true;
                selectsales();
            }
            else
            {
                combobxcashier.Visible = false;
                selectsales();
            }
        }

        private void combobxproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectsales();
        }

        private void lnkdaily_Click(object sender, EventArgs e)
        {
            if (rd1.Checked)
            {
                dailyreport dr = new dailyreport();
                if (chballcashier.Checked)
                {
                    dr.cashiername = chballcashier.Text;
                }
                else
                {
                    dr.cashiername = combobxcashier.Text;
                }
                if (chballproducts.Checked)
                {
                    dr.productname = chballcashier.Text;
                }
                else
                {
                    dr.productname = combobxproduct.Text;
                }
                reportsstylemanager.Clone(dr);
                dr.ShowDialog();
            }
            else if (rd2.Checked)
            {
                monthlyreport mr = new monthlyreport();
                reportsstylemanager.Clone(mr);
                if (rd3.Checked)
                {
                    mr.precise = false;
                    if (chballcashier.Checked)
                    {
                        mr.cashiername = chballcashier.Text;
                    }
                    else
                    {
                        mr.cashiername = combobxcashier.Text;
                    }
                    if (chballproducts.Checked)
                    {
                        mr.productname = chballcashier.Text;
                    }
                    else
                    {
                        mr.productname = combobxproduct.Text;
                    }
                    mr.ShowDialog();
                }
                else if (rd4.Checked)
                {
                    mr.precise = true;
                    mr.ShowDialog();
                }

            }


        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            paneldaily.Visible = false;
            panelmonthly.Visible = true;
            panellength.Visible = true;
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            dtstart.Value = startDate;
            dtend.Value = endDate;
            selectsales();
        }
        private void dtstart_ValueChanged(object sender, EventArgs e)
        {
            selectsales();
        }

        private void dtend_ValueChanged(object sender, EventArgs e)
        {
            selectsales();
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            paneldaily.Visible = true;
            panelmonthly.Visible = false;
            panellength.Visible = false;
        }

        private void rd12_CheckedChanged(object sender, EventArgs e)
        {
            paneldaily2.Visible = false;
            panelmonthly2.Visible = true;
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            dtstartstocks.Value = startDate;
            dtendstocks.Value = endDate;
            selectstocks();

        }

        private void rd11_CheckedChanged(object sender, EventArgs e)
        {
            paneldaily2.Visible = true;
            panelmonthly2.Visible = false;
        }

        private void dtendstocks_ValueChanged(object sender, EventArgs e)
        {
            selectstocks();
        }

        private void dtstartstocks_ValueChanged(object sender, EventArgs e)
        {
            selectstocks();
        }

        private void lnkstocks_Click(object sender, EventArgs e)
        {
            stockreport _stockreport = new stockreport();
            if (rd11.Checked)
                _stockreport.dailystocks = true;
            else if (rd12.Checked)
                _stockreport.dailystocks = false;
            reportsstylemanager.Clone(_stockreport);
            _stockreport.ShowDialog();
        }

        private void dtstocks_ValueChanged(object sender, EventArgs e)
        {
            selectstocks();
        }
        public void salesbuttons()
        {
            if (dgsalesreport.Rows.Count == 0)
                lnksales.Visible = false;
            else
                lnksales.Visible = true;
        }
        public void stockbuttons()
        {
            if (dgstockreport.Rows.Count == 0)
                lnkstocks.Visible = false;
            else
                lnkstocks.Visible = true;
        }
        private void dgsalesreport_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            salesbuttons();
        }

        private void dgsalesreport_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            salesbuttons();
        }

        private void dgstockreport_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            stockbuttons();
        }

        private void dgstockreport_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            stockbuttons();
        }
    }
}
