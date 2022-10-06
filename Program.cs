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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzE3MzY0QDMyMzAyZTMyMmUzMGpRUDB2U0tZTFV0Tlp6STBSZDYraVVUWkM1Y3Avd0Y1ZDVsY1I1Umc3VEk9");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormGlowne());
        }
    }
}
