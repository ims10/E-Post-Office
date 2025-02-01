using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Post_Office
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           // Application.Run(new Login_Form());

            Login_Form fLogin = new Login_Form();

            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Home());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
