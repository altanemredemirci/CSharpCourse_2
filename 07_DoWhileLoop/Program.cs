namespace _07_DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}



            //int i = 10;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i < 10);

            #region Kullanıcı 0 girene kadar girilen sayıları toplayarak ekrana yazdırınız.

            int toplam = 0;
            int sayi;
            do
            {
                Console.WriteLine("Sayı giriniz");
                 sayi= Convert.ToInt32(Console.ReadLine());

                toplam += sayi;

            } while (sayi!=0);

            Console.WriteLine("Toplam:"+toplam);
            #endregion


        }
    }
}
