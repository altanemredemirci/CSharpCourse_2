namespace _12_Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot 
            //ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayarak metot ile kodlayınız

            Indirim();
        }

        static void Indirim()
        {
            Console.WriteLine("1.Ürün Fiyatı:");
            double fiyat1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün Fiyatı:");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());

            if (fiyat1 > fiyat2)
            {
                fiyat1 *= 0.7;
            }
            else
            {
                fiyat2 *= 0.7;
            }

            Console.WriteLine("3.Ürünü Almak İster Misiniz?(E/H)");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap == "E")
            {
                Indirim3(fiyat1, fiyat2);
            }

            else
            {
                Console.WriteLine("Ödeme:"+(fiyat2+fiyat1));
            }
        }
        static void Indirim3(double f1, double f2)
        {
            Console.WriteLine("3.Ürün Fiyatı:");
            double f3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Ödeme:{f1+f2+(f3/2)}");
        }
    }
}
