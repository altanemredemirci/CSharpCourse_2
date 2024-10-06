using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Generic_Mimari
{
    internal class Repository<T> where T:class
    {
        List<T> liste = new List<T>();
        // T : Generic Type

        public virtual void Create(T entity)
        {
            liste.Add(entity);
            //Databasedeki T tablosuna kayıt
        }
        public void Update(T entity)
        {
            //Database T tablosunda entity güncelle
        }

        public void List(List<T> liste)
        {
            //Gelen listeyi ekrana listele
        }
        public void ListExpression()
        {
            //Databaseden istenilen özelliklerde olan T getir ve listele
        }
        public void Find(int id)
        {
            //Databaseden istenilen Id'deki T getir  
        }
        public void Delete(T entity)
        {
            //Databaseden T sil
        }
    }
}
