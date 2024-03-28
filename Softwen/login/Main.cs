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

namespace Softwen.login
{
    public partial class Main : MetroForm
    {
        login log = null;
        public Main()
        {
            InitializeComponent();
            this.StyleManager = msmmain;
            log = new login(this); 
            log.SettingClosed += Log_SettingClosed;
            log.swipe();
        }

        private void Log_LogInSuccess(object sender, EventArgs e)
        {
            log.swipe(false);
        }

        private void Log_SettingClosed(object sender, EventArgs e)
        {
            lnksettings.Visible = true;
            lnkclose.Visible = true;
           
        }

        private void lnkclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnksettings_Click(object sender, EventArgs e)
        {
            lnksettings.Visible = false;
            lnkclose.Visible = true;    
            log.showsettings();
        }

        private void lnkminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
