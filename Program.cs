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
        }
    }
}
