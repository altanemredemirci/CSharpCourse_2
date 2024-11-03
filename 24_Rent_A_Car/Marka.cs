using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Rent_A_Car
{
    public class Marka
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public List<Araba> Arabas { get; set; }

        public override string ToString()
        {
            return Ad;
        }
    }
}
