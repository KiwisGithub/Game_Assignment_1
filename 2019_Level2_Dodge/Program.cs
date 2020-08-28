using System;
using System.Windows.Forms;

namespace _2019_Level2_Dodge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new frmMenu().Show();
            //Application.Run(new frmMenu());
            Application.Run();
        }
    }
}
