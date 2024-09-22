using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_2_RestaurantOtomasyonu
{
    internal class Yemek
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public double Fiyat { get; set; }
        public string Tip { get; set; }

        internal static List<Yemek> Menu = new List<Yemek>()
        {
            new Yemek(){Id=1,Isim="Mercimek",Fiyat=100,Tip="çorba"},
            new Yemek(){Id=2,Isim="Ezogelin",Fiyat=100,Tip="çorba"},
            new Yemek(){Id=3,Isim="Bolenez Makarna",Fiyat=200.50,Tip="makarna"},
            new Yemek(){Id=4,Isim="Köri Makarna",Fiyat=250,Tip="makarna"},
            new Yemek(){Id=5,Isim="Mezgit",Fiyat=350,Tip="balık"},
            new Yemek(){Id=6,Isim="Levrek",Fiyat=450.75,Tip="balık"},
            new Yemek(){Id=7,Isim="Lokum",Fiyat=700,Tip="et"},
            new Yemek(){Id=8,Isim="Biftek",Fiyat=800,Tip="et"},
            new Yemek(){Id=9,Isim="Kola",Fiyat=80,Tip="içecek"},
            new Yemek(){Id=10,Isim="Şalgam",Fiyat=80,Tip="içecek"}
        };


        internal static void MenuYaz()
        {
            foreach (Yemek yemek in Menu)
            {
                Console.WriteLine(yemek.Id + ":" + yemek.Isim + ":" + yemek.Fiyat);
            }
        }

        internal static void MenuDuzenle()
        {
            if (Yonetici.GirisYap())
            {
                MenuYaz();
                Console.WriteLine("Güncellenecek yemek numarası:");
                int id = Convert.ToInt32(Console.ReadLine());

                Yemek update = Menu.FirstOrDefault(i => i.Id == id);

                if (update != null)
                {
                    Console.WriteLine("İsim:");
                    update.Isim = Console.ReadLine();

                    Console.WriteLine("Fiyat:");
                    update.Fiyat = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Tip:");
                    update.Tip = Console.ReadLine();

                    Console.WriteLine("Güncellendi.");
                }
            }
            else
            {
                Console.WriteLine("Yetkiniz Bulunmamaktadır.");
            }
        }

    }
}
