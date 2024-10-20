using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_WinForm
{
    internal class Ogrenci
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Branch { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + " " + Branch;
        }
    }
}
