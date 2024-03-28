using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Text;
using System.Xml;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Softwen.login
{

    public partial class login : pnlSlider
    {
        public event EventHandler SettingClosed;
        Globals gs = new Globals();
        MSSQL mssql = new MSSQL();
        private bool source_result;
        string constring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        public login(Form owner) : base(owner)
        {
            InitializeComponent();
            for (int i = 3; i < 15; i++)
            {
                MetroTile tile = new MetroTile();
                tile.Size = new Size(30, 30);
                tile.Tag = i;
                tile.Style = (MetroColorStyle)i;
                tile.Click += Tile_Click;
                flpcolors.Controls.Add(tile);
            }
        }
        private void Tile_Click(object sender, EventArgs e)
        {
            var color = (MetroColorStyle)((MetroTile)sender).Tag;
            ((MetroForm)this.Parent).StyleManager.Style = color;
        }
        public void showsettings()
        {
            pnlsettings.Visible = true;
            pnlcenter.Visible = false;
            pnlcenter.Enabled = false;
        }

        private void lnkback_Click(object sender, System.EventArgs e)
        {
            pnlsettings.Visible = false;
            pnlcenter.Enabled = true;
            pnlcenter.Visible = true;
            EventHandler handler = SettingClosed;
            if (handler != null) handler(this, e);
        }
        private void mrblight_CheckedChanged(object sender, EventArgs e)
        {
            if (mrblight.Checked)
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroThemeStyle.Light;
                flpcolors.BackColor = Color.White;
            }
        }

        private void mrbdark_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbdark.Checked)
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroThemeStyle.Dark;
                flpcolors.BackColor = Color.FromArgb(17, 17, 17);
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '•')
                txtpassword.PasswordChar = '\0';
            else txtpassword.PasswordChar = '•';
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            trytologin();
        }
        private string getfname()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT fname FROM users WHERE username = @1", con))
                {
                    cmd.Parameters.AddWithValue("@1", txtusername.Text);
                    con.Open();
                    string fname = (string)cmd.ExecuteScalar() + " ";
                    return fname;
                }
            }
        }
        private string getlname()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT lname FROM users WHERE username = @1", con))
                {
                    cmd.Parameters.AddWithValue("@1", txtusername.Text);
                    con.Open();
                    string lname = (string)cmd.ExecuteScalar();
                    return lname;
                }
            }
        }
        public int getuserid()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT userid FROM users WHERE username = @1", con))
                {
                    cmd.Parameters.AddWithValue("@1", txtusername.Text);
                    con.Open();
                    int userid = (int)cmd.ExecuteScalar();
                    return userid;
                }

            }
        }
        private void trytologin()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtusername.Text) || string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    MetroMessageBox.Show(this, "One or more fields are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Focus();
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM users WHERE  username = @1 AND password = @2 COLLATE SQL_Latin1_General_CP1_CS_AS", con))
                        {
                            cmd.Parameters.AddWithValue("@1", txtusername.Text);
                            cmd.Parameters.AddWithValue("@2", txtpassword.Text);
                            int result = (int)cmd.ExecuteScalar();
                            if (result > 0)
                            {
                                Dashboard.dashboard ds = new Dashboard.dashboard();
                                ((MetroForm)this.Parent).StyleManager.Clone(ds);
                                ds.labelname.Text = getfname() + getlname();
                                Globals.userid = getuserid().ToString();
                                gs.recorduseractivity("Login", "None");
                                if (getusertype() == "Manager")
                                {
                                    ds.btnmaintenance.Enabled = false;
                                }
                                else if (getusertype() == "Cashier" || getusertype() == "Supervisor")
                                {
                                    ds.btnmaintenance.Enabled = false;
                                    ds.btnreports.Enabled = false;
                                }
                                this.Parent.Hide();
                                ds.Show();
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtusername.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "There is no valid Connection! Please configure it in the Settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                source_result = mssql.check_connection(constring);
                if (source_result == false)
                {
                    showsettings();
                }
            }
        }
        private string getusertype()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT usertype FROM users WHERE username = @1", con))
                {
                    cmd.Parameters.AddWithValue("@1", txtusername.Text);
                    con.Open();
                    string value = (string)cmd.ExecuteScalar();
                    return value;
                }
            }
        }
        private void login_Load(object sender, EventArgs e)
        {
            cbserver.Items.Add(@"localhost\SQLEXPRESS");
            cbserver.Items.Add(@".\SQLEXPRESS");
            cbserver.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cbserver.SelectedIndex = 2;
            txtserverusername.Text = ConfigurationManager.AppSettings["Username"].ToString();
            txtserverpassword.Text = ConfigurationManager.AppSettings["Password"].ToString();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder a = new StringBuilder("Server =");
                a.Append(cbserver.Text);
                a.Append("; Database =");
                a.Append("HOP");
                a.Append("; Uid =");
                a.Append(txtserverusername.Text);
                a.Append("; Password =");
                a.Append(txtserverpassword.Text);
                a.Append(";");
                string strCon = a.ToString();
                source_result = mssql.check_connection(strCon);
                if (source_result == false)
                {
                    MetroMessageBox.Show(this, "Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    metroButton1.Enabled = false;
                }
                else
                {
                    updateConfigFile(strCon);
                    ConfigurationManager.RefreshSection("connectionStrings");
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
                    MetroMessageBox.Show(this, "Connected Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    metroButton1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateConfigFile(string con)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement xElement in xmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    xElement.FirstChild.Attributes[2].Value = con;

                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                trytologin();          
        }

        private void lnklogin_Click(object sender, EventArgs e)
        {
            trytologin();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }

}
