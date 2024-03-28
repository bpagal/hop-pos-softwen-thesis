using MetroFramework;
using MetroFramework.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwen.Maintenance
{
    public partial class backupdb : MetroForm
    {
        public backupdb()
        {
            InitializeComponent();
        }

        private void lnkbackup_Click(object sender, EventArgs e)
        {
            metroProgressBar1.Value = 0;
            try
            {
                Server dbserver = new Server(new ServerConnection(txtserver.Text,txtusername.Text,txtpassword.Text));
                Backup dbbackup = new Backup() { Action = BackupActionType.Database, Database = txtdatabase.Text };
                dbbackup.Devices.AddDevice(string.Format(@"D:\b\HOP.bak", txtdatabase.Text), DeviceType.File);
                dbbackup.Initialize = true;
                dbbackup.PercentComplete += Dbbackup_PercentComplete;
                dbbackup.Complete += Dbbackup_Complete;
                dbbackup.SqlBackupAsync(dbserver);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dbbackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MetroMessageBox.Show(this, e.Error.Message, string.Format("Database {0} has been successfully backed up",txtdatabase.Text), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                });
            }
        }

        private void Dbbackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            metroProgressBar1.Invoke((MethodInvoker)delegate
            {
                metroProgressBar1.Value = e.Percent;
                metroProgressBar1.Update();
            });
            lblpercent.Invoke((MethodInvoker)delegate
            {
                lblpercent.Text = $"{e.Percent}%";
            });
        }

        private void backupdb_Load(object sender, EventArgs e)
        {
            txtserver.Text = ConfigurationManager.AppSettings["Servername"].ToString();
            txtdatabase.Text = ConfigurationManager.AppSettings["Database"].ToString();
            txtusername.Text = ConfigurationManager.AppSettings["Username"].ToString();
            txtpassword.Text = ConfigurationManager.AppSettings["Password"].ToString();
        }

        private void lnkrestore_Click(object sender, EventArgs e)
        {
               metroProgressBar1.Value = 0;
            try
            {
                Server dbserver = new Server(new ServerConnection(txtserver.Text,txtusername.Text,txtpassword.Text));
                Restore dbrestore = new Restore() { Database = txtdatabase.Text, Action=RestoreActionType.Database,ReplaceDatabase=true,NoRecovery=false };
                dbrestore.Devices.AddDevice(string.Format(@"D:\b\HOP.bak"), DeviceType.File);
                dbrestore.PercentComplete += Dbrestore_PercentComplete;
                dbrestore.Complete += Dbrestore_Complete;
                dbrestore.SqlRestoreAsync(dbserver);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dbrestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MetroMessageBox.Show(this, e.Error.Message, string.Format("Database {0} has been successfully restored", txtdatabase.Text), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                });
            }
        }

        private void Dbrestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            metroProgressBar1.Invoke((MethodInvoker)delegate
            {
                metroProgressBar1.Value = e.Percent;
                metroProgressBar1.Update();
            });
            lblpercent.Invoke((MethodInvoker)delegate
            {
                lblpercent.Text = $"{e.Percent}%";
            });
        }
    }
}
