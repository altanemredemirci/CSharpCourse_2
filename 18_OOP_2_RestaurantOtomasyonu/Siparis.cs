using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_2_RestaurantOtomasyonu
{
    internal class Siparis
    {
        public int Id { get; set; }
        public int MasaId { get; set; }
        public Yemek Yemek { get; set; }
              

        internal static Siparis SiparisAl(int masaId)
        {
            Siparis siparis = new Siparis();

            Yemek.MenuYaz();
          
            Console.Write("İstediğiniz Yemek Numarası:");             
            int secim = Convert.ToInt32(Console.ReadLine());

            siparis.Yemek= Yemek.Menu.FirstOrDefault(i => i.Id == secim);
            if (siparis.Yemek == null)
            {
                Console.Clear();
                Console.WriteLine("Hatalı Yemek Seçimi!!");
                Siparis.SiparisAl(masaId);
            }
            siparis.MasaId = masaId;

            return siparis;

        }

        internal static void HesapAl(List<Masa> liste)
        {
            Console.WriteLine("Hesap alınacak masa numarası?");
            int masaNo = Convert.ToInt32(Console.ReadLine().Replace("Masa-", ""));
            Masa hesapMasa = liste.FirstOrDefault(i => i.Id == masaNo);

            double hesap = 0;
            foreach (Siparis siparis in hesapMasa.Siparisler)
            {
                hesap += siparis.Yemek.Fiyat;
            }

            Console.WriteLine("Hesap:" + hesap);
            Console.WriteLine("Hesap Ödendi Mi?(E/H)");
            bool odeme = Console.ReadLine().ToUpper() == "E" ? true : false;
            if (odeme)
            {
                hesapMasa.Dolu = false;
                hesapMasa.Siparisler.Clear();
                Console.WriteLine("Yine Bekleriz..");
            }
        }
    }
}
