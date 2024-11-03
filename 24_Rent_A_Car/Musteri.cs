using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Rent_A_Car
{
    public class Musteri
    {
        public int Id { get; set; }

        [StringLength(30,ErrorMessage ="Max 30 karakter girilebilir")]
        public string AdSoyad { get; set; }

        [MaxLength(11,ErrorMessage ="Telefon Numarası 11 hane olmalıdır.")]
        public string Telefon { get; set; }
        public double Bakiye { get; set; }

        [MinLength(6)]
        public string Password { get; set; }

        public List<Kiralama> Kiralamas { get; set; }

        public Musteri()
        {
            Kiralamas = new List<Kiralama>();
        }
    }
}
