using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Rent_A_Car
{
    internal class Musteri
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public double Bakiye { get; set; }
        public string Password { get; set; }

        public List<Kiralama> Kiralamas { get; set; }
    }
}
