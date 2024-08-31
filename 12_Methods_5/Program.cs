namespace _12_Methods_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Topla();

            Console.WriteLine(ToplaDondur());

            //int sonuc = ToplaDondur();
            //Console.WriteLine(sonuc);

            ToplaDondurParametreli(1, 2);
        }

        /// <summary>
        /// İki sayı toplama
        /// </summary>


        static void Topla()
        {
            Console.WriteLine("1.sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        }



        static int ToplaDondur()
        {
            Console.WriteLine("1.sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            return sayi1 + sayi2;
        }

        /// <summary>
        /// İki sayının toplam işlemi
        /// </summary>
        /// <param name="s1">1.int sayı</param>
        /// <param name="s2">2.int sayı</param>
        /// <returns>İki sayının toplamındaki int sonuç</returns>

        static int ToplaDondurParametreli(int s1,int s2)
        {
            int toplam = s1 + s2;
            return toplam;
        }


    }
}
