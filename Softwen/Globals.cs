using System;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;
using MetroFramework;
using MetroFramework.Forms;
using System.Data;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace Softwen
{
    public class Globals
    {

        //all of these codes can be used on all forms hence the name Globals.cs
        public string connstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString(); //connection string
        private int i = 0;
        public static string userid = "1";

        //select method from database
        public void Select(string selectquery, MetroGrid dg)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {

                using (SqlCommand command = new SqlCommand(selectquery, con))
                {
                    con.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dg.DataSource = dt;
                }

            }
        }

        //select method with parameters
        public void SelectWithParameters(string selectquery, string[] parameter, string[] value, MetroGrid dg)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand(selectquery, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var str in parameter)
                    {
                        cmd.Parameters.AddWithValue(str, value[i]);
                        i++;
                    }
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dg.DataSource = dt;
                    i = 0;
                }
            }
        }

        //insert method into tables from database
        public void Insert(string insertquery, string[] parameter, string[] value)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand(insertquery, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var str in parameter)
                    {
                        cmd.Parameters.AddWithValue(str, value[i]);
                        i++;
                    }
                    con.Open();
                    cmd.ExecuteNonQuery();
                    i = 0;
                }
            }


        }

        //update method into tables from database
        public void Delete(string deletequery, MetroGrid dg, Control form)
        {
            if (MetroMessageBox.Show(form, "Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connstring))
                {
                    using (SqlCommand command = new SqlCommand(deletequery, con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        string userid = dg.CurrentRow.Cells[0].Value.ToString();
                        command.Parameters.AddWithValue("@1", userid);
                        con.Open();
                        command.ExecuteNonQuery();
                        MetroMessageBox.Show(form, "Data successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        //select method from database
        public void Filter(string selectquery, string value, DataGridView dg)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {

                using (SqlCommand command = new SqlCommand(selectquery, con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@1", value + "%");
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dg.DataSource = dt;

                }

            }
        }
        
        public void recorduseractivity(string activity, string manipulateddata)
        {
            string[] actparameters = { "@1", "@2", "@3", "@4" };
            string[] actvalues = { DateTime.Now.ToString(("MM/dd/yyyy hh:mm tt")), userid, activity, manipulateddata };
            Insert("useractivitys", actparameters, actvalues);
        }

        //checks if all textboxes in a panel are empty
        public static bool CheckFields(Control panel, Control form)
        {

            if (panel.Controls.OfType<MetroTextBox>().Any(t => string.IsNullOrWhiteSpace(t.Text)) || panel.Controls.OfType<ComboBox>().Any(c => string.IsNullOrWhiteSpace(c.Text)))
            {
                MetroMessageBox.Show(form, "One or more fields are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;

            }
            else
            {
                return false;
            }

        }

        //clears all textbox texts in a control
        public static void ResetFields(Control control)
        {
            MetroTextBox tb = control as MetroTextBox;
            MetroComboBox cb = control as MetroComboBox;
            NumericUpDown nud = control as NumericUpDown;
            if (tb != null)
            {
                tb.Clear();
            }
            if (cb != null)
            {
                cb.SelectedIndex = 0;
            }
            if (nud != null)
            {
                nud.Value = 1;
            }
            //repeat for combobox, listbox, checkbox and any other controls you want to clear
            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    ResetFields(child);
                }
            }
        }

        //changes all labels' forecolor to white
        public static void ChangeForeColor(Control control)
        {
            Label lb = control as Label;
            GroupBox gb = control as GroupBox;
            MetroLink ml = control as MetroLink;
            if (lb != null)
            {
                lb.ForeColor = System.Drawing.Color.White;
                lb.BackColor = System.Drawing.Color.FromArgb(17, 17, 17);
            }
            if (gb != null)
            {
                gb.ForeColor = System.Drawing.Color.White;
            }
            if (ml != null)
            {
                ml.BackColor = System.Drawing.Color.White;
            }
            //repeat for combobox, listbox, checkbox and any other controls you want to clear
            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    ChangeForeColor(child);
                }
            }
        }

        public static SqlDataReader ExecuteReader(String query, string parameter, string value)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(parameter, value);
                conn.Open();
                /*When using CommandBehavior.CloseConnection, the connection will be closed when the 
                IDataReader is closed.*/
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
        }

        public static void NumbersOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void LettersOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //populates the combobox with desired data
        public void populatecombobox(MetroComboBox combobx, string query, string displaymember, string valuemember)
        {
            using (SqlConnection con = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable td = new DataTable();
                        td.Load(reader);
                        if (td.Rows.Count > 0)
                        {
                            combobx.DisplayMember = displaymember;
                            combobx.ValueMember = valuemember;
                            combobx.DataSource = td;
                            con.Close();
                        }
                    }

                }
            }
        }

        public bool validateemptyqty(NumericUpDown nud, MetroForm frm)
        {
            if (string.IsNullOrWhiteSpace(nud.Text))
            {
                MetroMessageBox.Show(frm, "Quantity can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nud.Focus();
                return true;
            }
            else
                return false;
        }

        public void exportexcel(ReportDocument rpt)
        {
            ExportOptions exportOption;
            DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Microsoft Excel (97-2003) Data-Only (*.xls) |*.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                diskFileDestinationOptions.DiskFileName = sfd.FileName;
            }
            ExcelDataOnlyFormatOptions excelDataOnlyFormatOptions = new ExcelDataOnlyFormatOptions();
            excelDataOnlyFormatOptions.MaintainRelativeObjectPosition = true;
            exportOption = rpt.ExportOptions;
            exportOption.ExportDestinationType = ExportDestinationType.DiskFile;
            exportOption.ExportFormatType = ExportFormatType.ExcelRecord;
            exportOption.ExportDestinationOptions = diskFileDestinationOptions;
            exportOption.FormatOptions = excelDataOnlyFormatOptions;
            rpt.Export();
        }
        public static string getrptpath(string rptname)
        {
            string rptpath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory,"..\\..\\" + rptname));
            return rptpath;
        }

    }
}
