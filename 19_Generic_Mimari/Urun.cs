using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Generic_Mimari
{
    internal class Urun:BaseEntity<Urun>
    {     
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
       
        //Create(),Update(),Delete(),List(),List(Expression<Func>),Find()


        public override void Create(Urun urun)
        {
            Console.WriteLine("Urun:"+Name);
        }
       
    }
}
