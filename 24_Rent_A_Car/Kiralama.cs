using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Rent_A_Car
{
    public class Kiralama
    {
        public int Id { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

        public decimal Ucret;

        public int ArabaId { get; set; }
        public Araba Araba { get; set; }

        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }

        private void Hesapla()
        {
            TimeSpan span = BitisTarihi.Subtract(BaslangicTarihi);
            Ucret = Araba.Fiyat * (span.Hours);
        }
    }
}
