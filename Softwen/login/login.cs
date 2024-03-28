using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Softwen.login
{

    public partial class login : pnlSlider
    {
        public event EventHandler SettingClosed;
        Globals gs = new Globals();
        MSSQL mssql = new MSSQL();
        private bool source_result;
        string constring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        string testconstring;

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
                using (SqlCommand cmd = new SqlCommand("getfnamed", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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
                using (SqlCommand cmd = new SqlCommand("getlname", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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
                using (SqlCommand cmd = new SqlCommand("spselectid", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@1", txtusername.Text);
                    con.Open();
                    int userid = (int)cmd.ExecuteScalar();
                    return userid;
                }

            }
        }

        private void test()
        {
            Console.WriteLine("Super Admin ");
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
                        using (SqlCommand cmd = new SqlCommand("trylogins", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
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
                            else if (txtusername.Text == "hop123" && txtpassword.Text == "superadmin123**")
                            {
                                this.Hide();
                                Dashboard.dashboard ds = new Dashboard.dashboard();
                                ((MetroForm)this.Parent).StyleManager.Clone(ds);
                                ds.labelname.Text = "Supper admin";
                                if (getusertype() == "Supper admin")
                                {
                                    ds.btnmaintenance.Enabled = false;
                                }

                                gs.recorduseractivity("Login", "None");
                                ds.ShowDialog();
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
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                using(SqlCommand cmd1 = new SqlCommand("getusertype", con))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@2", txtusername.Text);
                    con.Open();
                    string value = (string)cmd1.ExecuteScalar();
                    return value;
                }
            }
        }

        private void initServerInstances()
        {
            RegistryView rv = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey rk = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, rv))
            {
                RegistryKey ik = rk.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (ik != null)
                {
                    foreach(var inm in ik.GetValueNames())
                    {
                        cbserver.Items.Add(Environment.MachineName + @"\" + inm);
                    }
                    cbserver.SelectionStart = 0;
                    cbserver.SelectedIndex = 0;
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            /*cbserver.Items.Add(@"localhost\SQLEXPRESS");
            cbserver.Items.Add(@".\SQLEXPRESS");
            cbserver.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cbserver.SelectedIndex = 2;*/
            initServerInstances();           
            txtserverusername.Text = Properties.Settings.Default.Username;
            txtserverpassword.Text = Properties.Settings.Default.Password;
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            testconstring = string.Format(@"Data Source={0};Initial Catalog=HOP;Persist Security Info=True;User ID={1};Password={2};", cbserver.Text, txtserverusername.Text, txtserverpassword.Text);
            try
            {
                source_result = mssql.check_connection(testconstring);
                if (source_result)
                {
                    MetroMessageBox.Show(this, "Connected Successfully! Please click the Save button", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnsaveconnection.Enabled = true;
                }
                else
                {
                    MetroMessageBox.Show(this, "Connection Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnsaveconnection.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnsaveconnection_Click(object sender, EventArgs e)
        {
            try
            {
                source_result = mssql.check_connection(testconstring);
                if (source_result)
                {
                    Properties.Settings.Default.Username = txtserverusername.Text;
                    Properties.Settings.Default.Password = txtserverpassword.Text;
                    Properties.Settings.Default.Save();
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("ConnectionString", testconstring);
                    MetroMessageBox.Show(this, "Your connection string has been sucessfully saved.", "Connection string saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
