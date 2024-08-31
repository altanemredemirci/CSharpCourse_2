using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Methods_3
{
    internal class Matematik
    {
        internal static void Topla()
        {
            Console.WriteLine("1.sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam:"+(sayi1+sayi2));
        }

        internal static void Topla(int s1, int s2)
        {
            Console.WriteLine("Toplam:" + (s1 + s2));
        }

        internal static void Topla(double s1, int s2)
        {
            Console.WriteLine("Toplam:" + (s1 + s2));
        }

        internal static void Topla(int s1, int s2, int s3)
        {
            Console.WriteLine("Toplam:" + (s1 + s2 + s3));
        }
    }
}
