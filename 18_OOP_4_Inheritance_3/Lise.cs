using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_4_Inheritance_3
{
    /*
   LiseOgrencisi için uygulanacak işlemler:
        ----------------------------------------
            * Constructer metot 3 özelliği parametre olarak isteyecek.
            * NotHesapla(): 2 notun aritmetik ortalamasını alacak ekrana yazdıracak.

        5	85.00-100	Pekiyi
        4	70.00-84.99	İyi
        3	60.00-69.99	Orta
        2	50.00-59.99	Geçer	
        1	0 - 49.99	Tekrar
  */
    internal class Lise : Ogrenci
    {
        public int Not1 { get; set; }
        public int Not2 { get; set; }

        public Lise(string adSoyad, int okulNumarasi, string okulAdi, OkulDuzeyi okulDuzeyi,int not1,int not2) : base(adSoyad, okulNumarasi, okulAdi, okulDuzeyi)
        {
            this.Not1 = not1;
            this.Not2 = not2;
        }

        public void NotHesapla()
        {
            double ortalama = (Not1 + Not2) / 2;

            if(ortalama>=85 && ortalama<=100) Console.WriteLine("Pekiyi");
            else if(ortalama>=70 && ortalama<85) Console.WriteLine("İyi");
            else if(ortalama>=60 && ortalama<70) Console.WriteLine("Orta");
            else if(ortalama>=50 && ortalama<60) Console.WriteLine("Geçer");
            else if(ortalama>=0 && ortalama<50) Console.WriteLine("Tekrar");
            else { Console.WriteLine("Not Hatalı!!"); }
        }
    }
}
