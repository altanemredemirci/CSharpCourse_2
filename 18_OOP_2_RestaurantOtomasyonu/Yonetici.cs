using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_2_RestaurantOtomasyonu
{
    internal class Yonetici
    {
        private static string password = "123";

        internal static bool GirisYap()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Şifre:");
                string pass = Console.ReadLine();

                if (pass == password)
                {
                    return true;
                }
                Console.WriteLine("Tekrar Deneyiniz!!");
            }

            return false;
          
        }
    }
}
