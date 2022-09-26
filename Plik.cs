using System;
using System.IO;

namespace DowodyZmian
{
    public class Plik
    {
        public string PelnaSciezka;
        public string NazwaPliku;
        public string NowaNazwaPliku;
        public DateTime DataUtworzenia;
        public string NumerZmiany;

        public Plik(string pelnaSciezka)
        {
            PelnaSciezka = pelnaSciezka;
            NazwaPliku = Path.GetFileName(pelnaSciezka);

            FileInfo wlasciwosciPliku = new FileInfo(pelnaSciezka);

            DataUtworzenia = wlasciwosciPliku.CreationTime;
        }
    }
}
