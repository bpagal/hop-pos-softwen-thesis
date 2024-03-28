using System;
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
        public void loadtable()
        {
            Globals gs = new Globals();
            gs.Select(@"SELECT CONVERT(VARCHAR(20), useractivity.timestamp, 100) as 'Date',  CONCAT(users.fname, ' ', users.lname)  AS 'User', usertype AS 'Role', action as 'Action' ,affecteddata as 'Data' FROM  users
                        INNER JOIN useractivity ON users.userid = useractivity.userid", dguseractivity);
        }
    }
}
