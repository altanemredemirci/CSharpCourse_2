using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_4_Inheritance_3
{
    internal class OrtaOgretim:Ogrenci
    {
        public OrtaOgretim(string adSoyad, int okulNumarasi, string okulAdi, OkulDuzeyi okulDuzeyi) : base(adSoyad, okulNumarasi, okulAdi, okulDuzeyi)
        {

        }
    }
}
