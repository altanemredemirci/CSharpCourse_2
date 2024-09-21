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

            foreach (Yemek yemek in Yemek.Menu)
            {
                Console.WriteLine(yemek.Id + ":" + yemek.Isim + ":" + yemek.Fiyat);
            }
            Console.Write("İstediğiniz Yemek Numarası:");             
            int secim = Convert.ToInt32(Console.ReadLine());

            siparis.Yemek= Yemek.Menu.FirstOrDefault(i => i.Id == secim);
            siparis.MasaId = masaId;

            return siparis;

        }
    }
}
