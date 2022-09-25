using License;
using System;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.PdfViewer;

namespace DowodyZmian
{
    public partial class FormG : Form
    {
        public FormG()
        {
            InitializeComponent();
        }

        private void FormGlowne_Shown(object sender, EventArgs e)
        {
            MyLicense license = LicenseHandler.ReadLicenseFile(out LicenseStatus licStatus, out string validationMsg);

            switch (licStatus)
            {
                case LicenseStatus.Undefined:

                    MessageBox.Show("Brak pliku z licencją!\nIdentyfikator komputera: " + LicenseHandler.GenerateUid("DowodyZmian"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();
                    break;

                case LicenseStatus.Valid:

                    PasekStatusu.Text = $"Licencja dla: {license.LicenseOwner}; Typ licencji: {license.Type}; Ważna do: {license.LicenseEnd}";
                    break;

                case LicenseStatus.Invalid:
                case LicenseStatus.Cracked:
                case LicenseStatus.Expired:

                    MessageBox.Show(validationMsg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void FormGlowne_Load(object sender, EventArgs e)
        {
            Text = "Dowody zmian";

            groupBoxView.Text = "Podgląd pliku PDF";
            groupBoxList.Text = "Lista wczytanych plików";

            
            PdfOknoPodlgadu.ZoomMode = ZoomMode.FitPage;

            PdfOknoPodlgadu.ToolbarSettings.OpenButton.IsVisible = false;
            PdfOknoPodlgadu.ToolbarSettings.SaveButton.IsVisible = false;
            PdfOknoPodlgadu.ToolbarSettings.PrintButton.IsVisible = false;

            PdfOknoPodlgadu.Load("gisnet.pdf");
        }

        private void FormG_FormClosing(object sender, FormClosingEventArgs e)
        {
            PdfOknoPodlgadu.Dispose();
        }
    }
}
