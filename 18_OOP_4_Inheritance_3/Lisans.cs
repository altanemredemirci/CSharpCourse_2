using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_4_Inheritance_3
{
    /*
      LisansOgrencisi için saklanacak bilgiler:
        -----------------------------------------
            * Fakülte
            * VizeNotu
            * FinalNotu

        LisansOgrencisi için uygulanacak işlemler:
        ------------------------------------------
            * Constructer metot 3 özelliği parametre olarak isteyecek.
            * NotHesapla(): vizenin %40 ını finalin %60 ını alıp ortalamayı aşağıdaki gibi derecelendirerek ekrana       yazdıracak.

            85.00-100	A
            70.00-84.99	B
            60.00-69.99	C
            50.00-59.99	D
            45- 49.99	E
            0 - 44.99	F
     */
    internal class Lisans : Ogrenci
    {
        public string Fakulte { get; set; }
        public int VizeNotu { get; set; }
        public int FinalNotu { get; set; }

        public Lisans(string adSoyad, int okulNumarasi, string okulAdi, OkulDuzeyi okulDuzeyi, string fakulte, int vizeNot, int finalNot) : base(adSoyad, okulNumarasi, okulAdi, okulDuzeyi)
        {
            Fakulte = fakulte;
            VizeNotu = vizeNot;
            FinalNotu = finalNot;
        }

        public void NotHesapla()
        {
            double ortalama = (VizeNotu + FinalNotu) / 2;

            if (ortalama >= 85 && ortalama <= 100) Console.WriteLine("AA");
            else if (ortalama >= 70 && ortalama < 85) Console.WriteLine("BB");
            else if (ortalama >= 60 && ortalama < 70) Console.WriteLine("CC");
            else if (ortalama >= 50 && ortalama < 60) Console.WriteLine("DD");
            else if (ortalama >= 25 && ortalama < 50) Console.WriteLine("EE");
            else if (ortalama >= 0 && ortalama < 25) Console.WriteLine("FF");
            else { Console.WriteLine("Not Hatalı!!"); }
        }
    }
}
