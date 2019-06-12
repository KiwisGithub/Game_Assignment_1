using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_Level2_Dodge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// hi test
        /// test 2 hi
        /// test3
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDodge());
        }
    }
}
