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

namespace Softwen.Transaction
{
    public partial class voidorder : MetroForm
    {
        public voidorder()
        {
            InitializeComponent();
        }

        private void voidorder_Load(object sender, EventArgs e)
        {
            txtkey.KeyPress += Globals.NumbersOnly;
            
        }

        private void lnkenter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkey.Text) || txtkey.Text != Properties.Settings.Default.VoidKey)
            {
                MetroMessageBox.Show(this, "Incorrect void key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtkey.Focus();
            }
            else
            {
                transaction.TransactionInstance.cleartransaction();
                Globals.ResetFields(this);
                this.Close();
            }
                
        }
    }
}
