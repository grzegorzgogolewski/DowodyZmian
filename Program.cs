using System;
using System.Windows.Forms;

namespace DowodyZmian
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzYxMjk3QDMyMzAyZTMzMmUzMG0zQVpHR1dyQVdmblBZTGJGRm1vdTU1R1ZtLzJMWDBiTWxiSll5K1JGVzA9");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormGlowne());
        }
    }
}
