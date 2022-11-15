using License;
using System;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.PdfViewer;
using System.IO;
using System.Linq;
using Syncfusion.Pdf;
using static DowodyZmian.ZmienneGlobalne;
using Syncfusion.Pdf.Parsing;

namespace DowodyZmian
{
    public partial class FormGlowne : Form
    {
        public FormGlowne()
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

            GroupBoxView.Text = "Podgląd pliku PDF";
            GroupBoxList.Text = "Lista wczytanych plików";
            GroupBoxPrzyciski.Text = "Operacje do wykonania";

            PdfOknoPodlgadu.ToolbarSettings.OpenButton.IsVisible = false;
            PdfOknoPodlgadu.ToolbarSettings.SaveButton.IsVisible = false;
            PdfOknoPodlgadu.ToolbarSettings.PrintButton.IsVisible = false;

            PdfOknoPodlgadu.RenderingEngine = PdfRenderingEngine.Pdfium;

            PdfOknoPodlgadu.Load("gisnet.pdf");

            ListBoxPliki.Focus();
        }

        private void FormG_FormClosing(object sender, FormClosingEventArgs e)
        {
            PdfOknoPodlgadu.Dispose();
        }

        private void TextBoxZmiana_TextChanged(object sender, EventArgs e)
        {
            NumerAktualnejZmiany = TextBoxZmiana.Text;
        }

        private void ButtonPliki_Click(object sender, EventArgs e)
        {
            string[] wczytanePliki = { };

            switch (((Button)sender).Name)
            {
                case "ButtonWybierzFolder":

                    FolderBrowserDialog fbdOpen = new FolderBrowserDialog
                    {
                        ShowNewFolderButton = false,
                        SelectedPath = OstatniFolder,
                    };

                    if (fbdOpen.ShowDialog() == DialogResult.OK)
                    {
                        wczytanePliki = Directory.GetFiles(fbdOpen.SelectedPath, "*.pdf",SearchOption.TopDirectoryOnly);

                        OstatniFolder = fbdOpen.SelectedPath;

                        Array.Sort(wczytanePliki, new NaturalStringComparer());
                    }
                    else
                    {
                        return;
                    }

                    break;

                case "ButtonWskazPliki":

                    OpenFileDialog ofDialog = new OpenFileDialog
                    {
                        Filter = @"Dokumenty (*.pdf)|*.pdf",
                        Multiselect = true,
                        InitialDirectory = OstatniFolder 
                    };

                    if (ofDialog.ShowDialog() == DialogResult.OK)
                    {
                        wczytanePliki = ofDialog.FileNames;

                        OstatniFolder = Path.GetDirectoryName(wczytanePliki[0]); 

                        Array.Sort(wczytanePliki, new NaturalStringComparer()); 
                    } 
                    else
                    {
                        return;
                    }

                    break;
            }

            ListaWczytanychPlikow.Clear();
            ListBoxPliki.Items.Clear();

            if (wczytanePliki.Length ==0)
            {
                return;
            }

            for (int index = 0; index < wczytanePliki.Length; index++)
            {
                string wczytanyPlik = wczytanePliki[index];

                Plik plik = new Plik(wczytanyPlik);

                ListaWczytanychPlikow.Add(index, plik);

                ListBoxPliki.Items.Add(plik.NazwaPliku);
            }

            ListBoxPliki.SetSelected(0, true); 
            
        }

        private void ListBoxPliki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxPliki.Items.Count > 0)
            {
                Plik aktualnyPlik = ListaWczytanychPlikow[ListBoxPliki.SelectedIndex];

                PdfOknoPodlgadu.Load(aktualnyPlik.PelnaSciezka);


                if (!string.IsNullOrEmpty(NumerAktualnejZmiany) && string.IsNullOrEmpty(aktualnyPlik.NowaNazwaPliku))
                {
                    aktualnyPlik.NowaNazwaPliku = NumerAktualnejZmiany + "_" + aktualnyPlik.NazwaPliku;

                    ListBoxPliki.SelectedIndexChanged -= ListBoxPliki_SelectedIndexChanged;
                    ListBoxPliki.Items[ListBoxPliki.SelectedIndex] = aktualnyPlik.NazwaPliku + " => " + aktualnyPlik.NowaNazwaPliku;
                    ListBoxPliki.SelectedIndexChanged += ListBoxPliki_SelectedIndexChanged;
                }
            }
        }

        private void PdfOknoPodlgadu_DocumentLoaded(object sender, EventArgs args)
        {
            ListBoxPliki.Focus();
        }

        private void ListBoxPliki_KeyDown(object sender, KeyEventArgs e)
        {
            Plik aktualnyPlik;

            PdfLoadedDocument loadedDocument;

            switch (e.KeyCode)
            {
                case Keys.F2:
                case Keys.Enter:

                    TextBoxZmiana.SelectAll();
                    TextBoxZmiana.Focus();

                    e.Handled = true;
                    
                    break;

                case Keys.Left:

                    aktualnyPlik = ListaWczytanychPlikow[ListBoxPliki.SelectedIndex];

                    loadedDocument = new PdfLoadedDocument(aktualnyPlik.PelnaSciezka);

                    switch (loadedDocument.Pages[0].Rotation)
                    {
                        case PdfPageRotateAngle.RotateAngle0:
                            loadedDocument.Pages[0].Rotation = PdfPageRotateAngle.RotateAngle270;
                            break;
                        case PdfPageRotateAngle.RotateAngle90:
                            loadedDocument.Pages[0].Rotation = PdfPageRotateAngle.RotateAngle0;
                            break;
                        case PdfPageRotateAngle.RotateAngle180:
                            loadedDocument.Pages[0].Rotation = PdfPageRotateAngle.RotateAngle90;
                            break;
                        case PdfPageRotateAngle.RotateAngle270:
                            loadedDocument.Pages[0].Rotation = PdfPageRotateAngle.RotateAngle180;
                            break;
                    }

                    loadedDocument.Save(aktualnyPlik.PelnaSciezka);

                    loadedDocument.Close(true);

                    PdfOknoPodlgadu.Load(aktualnyPlik.PelnaSciezka);

                    e.Handled = true;

                    break;

                case Keys.Right:

                    aktualnyPlik = ListaWczytanychPlikow[ListBoxPliki.SelectedIndex];

                    loadedDocument = new PdfLoadedDocument(aktualnyPlik.PelnaSciezka);

                    switch (loadedDocument.Pages[0].Rotation)
                    {
                        case PdfPageRotateAngle.RotateAngle0:
                            loadedDocument.Pages[0].Rotation = PdfPageRotateAngle.RotateAngle90;
                            break;
                        case PdfPageRotateAngle.RotateAngle90:
                            loadedDocument.Pages[0].Rotation = PdfPageRotateAngle.RotateAngle180;
                            break;
                        case PdfPageRotateAngle.RotateAngle180:
                            loadedDocument.Pages[0].Rotation = PdfPageRotateAngle.RotateAngle270;
                            break;
                        case PdfPageRotateAngle.RotateAngle270:
                            loadedDocument.Pages[0].Rotation = PdfPageRotateAngle.RotateAngle0;
                            break;
                    }

                    loadedDocument.Save(aktualnyPlik.PelnaSciezka);

                    loadedDocument.Close(true);

                    PdfOknoPodlgadu.Load(aktualnyPlik.PelnaSciezka);

                    e.Handled = true;

                    break;
            }
        }

        private void TextBoxZmiana_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(TextBoxZmiana.Text))
                {
                    NumerAktualnejZmiany = TextBoxZmiana.Text;

                    if (ListaWczytanychPlikow.Count == 0) return;

                    Plik aktualnyPlik = ListaWczytanychPlikow[ListBoxPliki.SelectedIndex];

                    aktualnyPlik.NowaNazwaPliku = NumerAktualnejZmiany + "_" + aktualnyPlik.NazwaPliku;

                    ListBoxPliki.SelectedIndexChanged -= ListBoxPliki_SelectedIndexChanged;
                    ListBoxPliki.Items[ListBoxPliki.SelectedIndex] = aktualnyPlik.NazwaPliku + " => " + aktualnyPlik.NowaNazwaPliku;
                    ListBoxPliki.SelectedIndexChanged += ListBoxPliki_SelectedIndexChanged;
                }

                ListBoxPliki.Focus();
            }
        }

        private void ButtonKonwersja_Click(object sender, EventArgs e)
        {
            bool czyBrakNowejNazwy = ListaWczytanychPlikow.Values.Any(plik => string.IsNullOrEmpty(plik.NowaNazwaPliku));

            if (czyBrakNowejNazwy)
            {
                MessageBox.Show("Nie wszystkie pliki mają nowe nazwy!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListBoxPliki.Items.Clear();

                foreach (Plik plik in ListaWczytanychPlikow.Values)
                {
                    string katalog = Path.GetDirectoryName(plik.PelnaSciezka);
                
                    File.Move(plik.PelnaSciezka, Path.Combine(katalog ?? throw new InvalidOperationException(), plik.NowaNazwaPliku));

                    plik.PelnaSciezka = Path.Combine(katalog, plik.NowaNazwaPliku);
                    plik.NazwaPliku = plik.NowaNazwaPliku;
                    plik.NowaNazwaPliku = string.Empty;

                    ListBoxPliki.Items.Add(plik.NazwaPliku);
                }

                TextBoxZmiana.Text = string.Empty;

                ListBoxPliki.SetSelected(0, true); 

                MessageBox.Show("Koniec!", "Zmiana nazw plików", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
