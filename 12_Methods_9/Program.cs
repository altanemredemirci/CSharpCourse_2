namespace _12_Methods_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PARAMS
            //params anahtar kelimesi, bir methoda değişken sayıda argümanın aynı tipte geçirilmesine olanak tanır.
            //params parametresi, metodun son parametresi olarak tanımlanmalıdır ve yalnızca bir params anahtar kelimesi kullanılabilir.
            //params ile belirtilen parametre bir dizi olarak işlenir, bu da metod içinde bir dizi erişilebileceği ve üzerinde işlem yapılabileceği anlamına gelir.

            //int[] sayilar = { 10, 20, 30, 40, 50 };
            //DiziYazdir(sayilar);
            //DiziYazdir2( 10, 20, 30,40,50);

            //DiziYazdir3(1, 2,4,5,6);
            #endregion

            #region OUT REF KEYWORD
            //Method tanımlanırken verilen parametre ile çağırdığımızda verdiğimiz parametre aynı değildir.Sadece çağırırkne verilen değişken tanımdaki parametreye değeri atar. 
            //out keyword'ü  ile dışarıdaki değişkenin değeri method yardımı ile revize etmek zorunlıudur..

            //try
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (FormatException)
            //{

            //    Console.WriteLine("Sayıyı rakam ile giriniz");
            //}


            //Console.WriteLine("Sayı giriniz");          
            //string s = Console.ReadLine();

            //int sayi;
            //int.TryParse(s, out sayi);



            //int rakam;
            //if (TryParseOut("12", out rakam))
            //{
            //    Console.WriteLine(rakam);
            //}
            //else
            //{
            //    Console.WriteLine("string int çevirilemedi.");
            //}



            #endregion

            #region REF KEYWORD
            //ref tanımı için ilk değer atama zorunluluğu vardır. method içinde revize etme gibi bir zorunluluk yoktur.
            //int rakam=0;
            //if (TryParseRef("12", ref rakam))
            //{
            //    Console.WriteLine(rakam);
            //}
            //else
            //{
            //    Console.WriteLine("string int çevirilemedi.");
            //}
            #endregion

            #region RECURSIVE METHOD
            //Test();

            //Test2(1);


            int sayi = 50;
            for (int i = 0; i < sayi; i++)
            {
                Console.Write(fibonacci(i)+" ");
            }
            
            #endregion

        }

        #region PARAMS
        static void DiziYazdir(int[] sayilar)
        {
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }

        static void DiziYazdir2(params int[] sayilar)
        {
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }

        static void DiziYazdir3(double s1, float s2, params int[] sayilar)
        {
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }
        #endregion

        #region OUT REF KEYWORDS
        static bool TryParseRef(string deger, ref int rakam)
        {
            try
            {
                rakam = Convert.ToInt32(deger);
                return true;
            }
            catch (Exception)
            {
                rakam = 0;
                return false;
            }
        }

        static bool TryParseOut(string deger, out int rakam)
        {
            try
            {
                rakam = Convert.ToInt32(deger);
                return true;
            }
            catch (Exception)
            {
                rakam = 0;
                return false;
            }
        }
        #endregion

        static void Test()
        {
            Console.WriteLine("Method Çalıştı");
            Test();
        }



        static void Test2(int sayi)
        {
            if (sayi % 9 != 0)
            {
                Console.WriteLine(sayi);
                sayi++;
                Test2(sayi);
            }          
        }

        static int fibonacci(int sayi)
        {
            if (sayi <= 1)
                return sayi;

            return fibonacci(sayi - 1) + fibonacci(sayi - 2);
        }
    }
}
