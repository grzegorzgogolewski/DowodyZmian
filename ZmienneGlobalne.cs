using System.Collections.Generic;

namespace DowodyZmian
{
    public static class ZmienneGlobalne
    {
        public static string NumerAktualnejZmiany;
        public static string OstatniFolder;
        public static readonly Dictionary<int, Plik> ListaWczytanychPlikow = new Dictionary<int, Plik>();
    }
}
