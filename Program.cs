using EndeApp.GUI;
using System;
using System.Windows.Forms;

namespace EndeApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. /test comment/
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
