using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Generic_Mimari
{
    internal class BaseEntity<T>:Repository<T> where T:class //Inheritance - Kalıtım - Miras Alma
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime DeletedOn { get; set; }
             
    }
}
