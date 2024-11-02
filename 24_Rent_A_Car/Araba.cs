using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Rent_A_Car
{
    internal class Araba
    {
        //Her kaydın benzersiz bir değere ihtiyacı var. Id PK ve Identity sahip olacak.
        //EF bu özellikleri Id, id, ID, iD vb tanım gördüğünde otomatik verir.
        public int Id { get; set; }

        //[StringLength(30)] //Attribute : propertylere Sql özellikleri atar.
        public string Model { get; set; }
        public string Yakit { get; set; }
        public double Km { get; set; }
        public string Vites { get; set; }
        public decimal Fiyat { get; set; }


        //Araba ile Marka arasında 1-N
        //Mapping
        public int MarkaId { get; set; }
        public Marka Marka { get; set; }

        public List<Kiralama> Kiralamas { get; set; }
    }

   
}
