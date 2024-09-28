using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_4_Inheritance_3
{
     //Soru: 
     //   Tüm öğrenciler(Ogrenci) için saklanacak bilgiler:
     //   ----------------------------------------
     //       * Ad Soyad(tek özellikte tutulacak)
     //       * Okul Numarası
     //       * Okul Adı = "Açıktan Eğitim"	(Alt sınıflarda tanımlanırsa değişecek)
     //       * Ögretim Duzeyi(IlkOgretim, OrtaOgretim, Lise, Lisans) enum tipinde  4 elemanlı


    enum OkulDuzeyi
    {
        IlkOgretim,OrtaOgretim,Lise,Lisans
    }

    internal class Ogrenci
    {
        public string AdSoyad { get; set; }
        public int OkulNumarasi { get; set; }
        public string OkulAdi = "Açıktan Eğitim";
        public OkulDuzeyi OkulDuzeyi;




        public Ogrenci(string adSoyad,int okulNumarasi,string? okulAdi,OkulDuzeyi okulDuzeyi)
        {
            this.AdSoyad = adSoyad;
            this.OkulDuzeyi = okulDuzeyi;
            this.OkulNumarasi = okulNumarasi;
            if (!string.IsNullOrEmpty(okulAdi))
            {
                this.OkulAdi = okulAdi;
            }
            
        }
    }
}
