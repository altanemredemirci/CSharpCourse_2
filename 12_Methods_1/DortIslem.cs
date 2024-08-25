using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Methods_1
{
    public class DortIslem
    {
        #region Tanım şekilleri
        ////default olarak PRIVATE tanımlanır.
        //public static void Toplama()
        //{
        //    Console.WriteLine(12+13);
        //}

        ////Parametresiz Değer Döndürmeyen Metot
        //internal static void Cikarma()
        //{
        //    Console.WriteLine("1.sayıyı giriniz:");
        //    int sayi1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("2.sayıyı giriniz:");
        //    int sayi2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine(sayi1-sayi2);
        //}

        ////Parametreli Değer Döndürmeyen Metot
        //internal static void Cikarma2(int sayi1,int sayi2)
        //{
        //    Console.WriteLine(sayi1 - sayi2);
        //}
        #endregion

        // SOLID PRENSİBLERİ

        internal static void Toplama(int s1,int s2)
        {
            Console.WriteLine(s1+s2);
        }
        internal static void Cikarma(int s1, int s2)
        {
            Console.WriteLine(s1 - s2);
        }
        internal static void Carpma(int s1, int s2)
        {
            Console.WriteLine(s1 * s2);
        }
        internal static void Bolme(int s1, int s2)
        {
            Console.WriteLine(s1 / s2);
        }

        internal static void Islemler()
        {
            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bir işlem giriniz(+,-,*,/):");
            char islem = Convert.ToChar(Console.ReadLine());

            if (islem == '+') { Toplama(sayi1, sayi2); }
            else if (islem == '-') { Cikarma(sayi1, sayi2); }
            else if (islem == '*') { Carpma(sayi1, sayi2); }
            else if (islem == '/') { Bolme(sayi1, sayi2); }
            else { Console.WriteLine("Hatalı İşlem Seçimi"); }
        }



        internal static void KDVUygula(double fiyat,double kdv)
        {
            Console.WriteLine(fiyat*kdv);
        }


    }
}