namespace _12_Methods_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rastgele 1-100 arasında 15 değer tutan bir dizideki tek ve çiftleri ayrı ayrı dizilere atayan metot 
                      

            DiziDoldur();


        }


        static void DiziDoldur()
        {
            int[] tekSayilar = new int[0];
            int[] ciftSayilar = new int[0];
            int[] sayilar = new int[15];

            Random r = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {
                int sayi= r.Next(1, 100);
                sayilar[i] = sayi;

                if (sayi % 2 == 0)
                {
                    Array.Resize(ref ciftSayilar, ciftSayilar.Length + 1);
                    ciftSayilar[ciftSayilar.Length - 1] = sayi;
                }
                else
                {
                    Array.Resize(ref tekSayilar, tekSayilar.Length + 1);
                    tekSayilar[tekSayilar.Length - 1] = sayi;
                }

            }

            DiziYazdir(sayilar);
            DiziYazdir(tekSayilar);
            DiziYazdir(ciftSayilar);
        }

        static void DiziYazdir(int[] dizi)
        {
            Console.WriteLine("**************");
            foreach (int sayi in dizi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
