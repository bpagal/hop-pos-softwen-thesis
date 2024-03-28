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

namespace Softwen.Transaction
{
    public partial class discount : MetroForm
    {
        private readonly transaction trs;
        public discount(transaction _transaction)
        {
            trs = _transaction;
            InitializeComponent();
        }
        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (panel1.Enabled == false)
                panel1.Enabled = true;
            else
                panel1.Enabled = false;

        }

        private void lnksave_Click(object sender, EventArgs e)
        {

            if (rd1.Checked)
            {
                trs.discountstatus = "None";
                trs._discountvalue = 0;
                trs._vatpercent = Properties.Settings.Default.Vat / 100;
                trs.getsummary();
                this.Close();
            }

            else if (rd2.Checked)
            {
                trs.discountstatus = "Senior Citizen";
                trs._discountvalue = 20;
                trs._vatpercent = 0;
                trs.getsummary();
                this.Close();
            }
            else if (rd3.Checked)
            {
                trs.discountstatus = "Employee Discount";
                trs._discountvalue = Properties.Settings.Default.empdiscount;
                trs._vatpercent = Properties.Settings.Default.Vat / 100;
                trs.getsummary();
                this.Close();
            }
            else if (rd4.Checked)
            {
                if (Globals.CheckFields(panel1, this) == false)
                {
                    trs._discountvalue = Convert.ToDecimal(txtdiscount.Text);
                    trs._vatpercent = Properties.Settings.Default.Vat / 100;
                    trs.discountstatus = txtdiscount.Text + "%";
                    trs.getsummary();
                    this.Close();
                }
            }


        }

        private void discount_Load(object sender, EventArgs e)
        {
            txtdiscount.KeyPress += Globals.NumbersOnly;
        }
    }
}
