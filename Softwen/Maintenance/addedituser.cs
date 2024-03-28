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

namespace Softwen.Maintenance
{
    public partial class addedituser : MetroForm
    {
        Globals gs = new Globals();
        private readonly maintenance mnt;
        public string userid = "";
        public addedituser(maintenance _maintenance)
        {
            mnt = _maintenance;
            InitializeComponent();
        }
        private bool checkusername()
        {
            using (SqlDataReader productreader = Globals.ExecuteReader("checkusername", "@1", txtuname.Text))
            {
                if (productreader.Read())
                {
                    MetroMessageBox.Show(this, "Username: " + txtuname.Text + " already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                else
                    return false;
            }
        }
        private void lnksave_Click(object sender, EventArgs e)
        {
            string[] addparameters = { "@1", "@2", "@3", "@4", "@5" };
            string[] addvalues = { txtfname.Text, txtlname.Text, combobxut.Text, txtuname.Text, txtpass.Text, };
          
                if (Globals.CheckFields(paneluser, this) == false)
                {
                    gs.Insert("spCREATEUSERS", addparameters, addvalues);
                    MetroMessageBox.Show(this, "User successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gs.recorduseractivity("New User", txtuname.Text);
                    Globals.ResetFields(paneluser);
                    this.Close();
                    mnt.selectusers();
                }
            
        }
        private void lnkupdate_Click(object sender, EventArgs e)
        {
            string[] addparameters = { "@1", "@2", "@3", "@4", "@5", "@6" };
            string[] addvalues = { txtfname.Text, txtlname.Text, combobxut.Text, txtuname.Text, txtpass.Text, userid };

            if (Globals.CheckFields(paneluser, this) == false)
            {
                gs.Insert("spUpdateUsers", addparameters, addvalues);
                MetroMessageBox.Show(this, "User successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gs.recorduseractivity("New User", txtuname.Text);
                Globals.ResetFields(paneluser);
                this.Close();
                mnt.selectusers();
            }

        }

        private void addedituser_Load(object sender, EventArgs e)
        {
            txtfname.KeyPress += Globals.LettersOnly;
            txtlname.KeyPress += Globals.LettersOnly;
            combobxut.Text = mnt.dgusers.CurrentRow.Cells[3].Value.ToString();
            if (mnt.maintenancestylemanager.Theme == MetroThemeStyle.Dark)
                Globals.ChangeForeColor(this);
        }

        private void lnkclear_Click(object sender, EventArgs e)
        {
            if (lnksave.Enabled == true)
                Globals.ResetFields(paneluser);
            else
            {
                txtfname.Clear();
                txtlname.Clear();
                txtpass.Clear();
                combobxut.SelectedIndex = -1;
            }
        }

        private void combobxut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //public void usertypefill()
        //{
        //    if (Globals.CheckFields(paneluser, this) == false)
        //    {
                
        //        SqlCommand command = new SqlCommand();
        //        command.CreateParameter();
        //        command.CommandType = CommandType.StoredProcedure;
        //        command.CommandText = "usertypefill";
        //        SqlDataAdapter da = new SqlDataAdapter(command);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        combobxut.DataSource = dt;
        //        combobxut.ValueMember = "usertype";
        //        combobxut.DisplayMember = "usertype";

        //        gs.recorduseractivity("New User", txtuname.Text);
        //        Globals.ResetFields(paneluser);
        //        this.Close();
        //        mnt.selectusers();
        //    }
        //}
    }
}
