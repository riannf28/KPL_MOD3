using System;

namespace modul3_1302200040
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Nama Buah & Kode Buah-----");
            Console.Write("Nama Buah : ");
            string buah = Console.ReadLine();
            KodeBuah kode = new KodeBuah();
            Console.WriteLine("Kode Buah : " + kode.getKodeBuah(buah));

            Console.WriteLine("\n-----Posisi Karakter Game-----");
            Console.Write("State Awal : ");
            PosisiKarakterGame pos = new PosisiKarakterGame();
            Console.Write("\nTekan Tombol : ");
            string state = Console.ReadLine();
            if (state == "S")
            {
                pos.TombolS();
            }
            else if (state == "W")
            {
                pos.TombolW();
            }
            else
            {
                Console.WriteLine("Coba tekan tombol S atau W");
            }
        }
    }
}
