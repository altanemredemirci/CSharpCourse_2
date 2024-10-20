using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_WinForm
{
    internal class Ogretmen
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public List<string> Courses { get; set; }
        public int Experience { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }

        public Ogretmen()
        {
            Courses = new List<string>();
        }
    }
}
