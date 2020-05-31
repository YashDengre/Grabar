using System;
using System.Windows.Forms;

namespace Grabar
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
            //Application.Run(new Grabar());
            Application.Run(new GrabarControl());
        }

    }
}
