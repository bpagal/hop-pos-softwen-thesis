﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwen.UserActivity
{

    public partial class useract : UserControl
    {
        Globals gs = new Globals();
        private static useract _useractivityinstance;
        public static useract UseractivityInstance
        {
            get
            {
                if (_useractivityinstance == null)
                    _useractivityinstance = new useract();
                return _useractivityinstance;
            }
        }
        public useract()
        {
            InitializeComponent();
        }
        public void selectuseract()
        {
            if (rdaily.Checked)
            {
                string[] uaparameters = { "@1" };
                string[] uavalues = { dtuseract.Value.ToString("MM/dd/yyyy") };
                gs.SelectWithParameters(@"SELECT CONVERT(VARCHAR(20), useractivity.timestamp, 100) as 'Date',  CONCAT(users.fname, ' ', users.lname)  AS 'User', usertype AS 'Role', action as 'Action' ,affecteddata as 'Data' FROM  users
                        INNER JOIN useractivity ON users.userid = useractivity.userid inner join usertype_tbl on users.usertype_id = usertype_tbl.usertype_id WHERE (CAST(useractivity.timestamp AS date) = @1)", uaparameters, uavalues, dguseractivity);
            }
            else if (rmonthly.Checked)
            {
                string[] uaparameters = { "@1", "@2" };
                string[] uavalues = { dtstartua.Value.ToString("MM/dd/yyyy"), dtendua.Value.ToString("MM/dd/yyyy") };
                gs.SelectWithParameters(@"SELECT CONVERT(VARCHAR(20), useractivity.timestamp, 100) as 'Date',  CONCAT(users.fname, ' ', users.lname)  AS 'User', usertype AS 'Role', action as 'Action' ,affecteddata as 'Data' FROM  users
                        INNER JOIN useractivity ON users.userid = useractivity.userid inner join usertype_tbl on users.usertype_id = usertype_tbl.usertype_id WHERE (CAST(useractivity.timestamp AS date) BETWEEN @1 AND @2) ", uaparameters, uavalues, dguseractivity);
            }
        }

        private void dtuseract_ValueChanged(object sender, EventArgs e)
        {
            selectuseract();
        }

        private void rmonthly_CheckedChanged(object sender, EventArgs e)
        {
            paneldailyua.Visible = false;
            panelmonthlyua.Visible = true;
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            dtstartua.Value = startDate;
            dtendua.Value = endDate;
            selectuseract();
        }

        private void rdaily_CheckedChanged(object sender, EventArgs e)
        {
            paneldailyua.Visible = true;
            panelmonthlyua.Visible = false;
            selectuseract();
        }

        private void useract_Load(object sender, EventArgs e)
        {
            dtuseract.Value = DateTime.Today.Add(dtuseract.Value.TimeOfDay);
            selectuseract();

        }
    }
}
