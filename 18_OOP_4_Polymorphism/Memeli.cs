using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_4_Polymorphism
{
    internal class Memeli
    {
        public double Agirlik { get; set; }
        public double Boy { get; set; }

        public virtual void Konus() //virtual: sanallaştırma sağlar.Yani türeyen sınıflarda yeniden biçimlendirilebilir(override).
        {
            Console.WriteLine("Ben Bir Memeliyim!!");
        }
    }

    internal class Kopek:Memeli
    {
        public string Cins { get; set; }
        public override void Konus() //override: Miras alınan bir field'ın yeniden biçimlendirilmesini(ezilmesi) sağlar.Override edilecek field'ın virtual,abstract veya daha önce override edilmiş olması gereklidir.
        {
            Console.WriteLine("Ben Bir Köpeğim!!");
        }
    }

    internal class Kedi : Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("Ben Bir Kediyim!!");
        }
    }

    internal class Kurt : Kopek
    {
        public override void Konus()
        {
            Console.WriteLine("Ben Bir Kurdum!!");
        }
    }

    internal class Balina : Memeli
    {
      
    }
}
