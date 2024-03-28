using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the appliC:\Users\Brian\documents\visual studio 2015\Projects\Softwen\Softwen\Program.cscation.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new login.Main());
            Application.Run(new Dashboard.dashboard());

        }
    }
}
