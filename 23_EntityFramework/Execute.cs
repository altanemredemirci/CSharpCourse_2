using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_EntityFramework
{
    internal class Execute
    {
        DataContext db;
        public Execute()
        {
            db = new DataContext();
        }

        public void Insert(Product p)
        {
            db.Urunler.Add(p);
            db.SaveChanges();
        }
    }
}
