using System;
using System.Collections.Generic;
using System.Text;

namespace modul3_1302200040
{
    class KodeBuah
    {
        public String getKodeBuah(string buah)
        {
            if (buah == "Apel")
            {
                return "A00";
            }
            else if (buah == "Aprikot")
            {
                return "B00";
            }
            else if (buah == "Alpukat")
            {
                return "C00";
            }
            else if (buah == "Pisang")
            {
                return "D00";
            }
            else if (buah == "Paprika")
            {
                return "E00";
            }
            else if (buah == "Blackberry")
            {
                return "F00";
            }
            else if (buah == "Ceri")
            {
                return "H00";
            }
            else if (buah == "Kelapa")
            {
                return "I00";
            }
            else if (buah == "Jagung")
            {
                return "J00";
            }
            else if (buah == "Kurma")
            {
                return "K00";
            }
            else if (buah == "Durian")
            {
                return "L00";
            }
            else if (buah == "Anggur")
            {
                return "M00";
            }
            else if (buah == "Melon")
            {
                return "N00";
            }
            else if (buah == "Semangka")
            {
                return "O00";
            }
            else
            {
                return "Tidak ditemukan";
            }
        }
    }
}
