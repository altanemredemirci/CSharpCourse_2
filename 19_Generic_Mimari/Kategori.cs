using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Generic_Mimari
{
    internal class Kategori:BaseEntity<Kategori>
    {
        public string Name { get; set; }
        public string Description { get; set; }

      
    }
}
