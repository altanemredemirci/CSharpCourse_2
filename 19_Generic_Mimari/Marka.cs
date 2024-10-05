using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Generic_Mimari
{
    internal class Marka:BaseEntity<Marka>
    {
        public string Name { get; set; }
        public string Logo { get; set; }


        //Create(),Update(),Delete(),List(),List(Expression<Func>),Find()
        public void Create(Marka marka)
        {
            //Database kayıt
        }
        public void Update(Marka marka)
        {
            //Database güncelle
        }

        public void List(List<Marka> markas)
        {
            //Gelen listeyi ekrana listele
        }
        public void ListExpression()
        {
            //Databaseden istenilen özelliklerde olan Markaları getir ve listele
        }
        public void Find(int id)
        {
            //Databaseden istenilen Id'deki Markayı getir  
        }
        public void Delete(Marka marka)
        {
            //Databaseden kategoriyi sil
        }
    }
}
