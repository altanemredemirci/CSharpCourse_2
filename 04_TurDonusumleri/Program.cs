namespace _04_TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VERİ TİPİ DÖNÜŞÜMLERİ

            //** 1.Bilinçsiz Tür Dönüşümü **
            // Küçük türün BÜYÜK türe dönüştürülmesi

            //int s = 123456789;
            //double s2 = s; // herhangi bir kod yazmadan datatype dönüşümü yaptınız


            //byte a = 1;
            //short b = a;

            //    // BÜYÜK türün küçük türe dönüştürülmesi - HATA
            //double sayi = 5;
            //int sayi2 = sayi;


            //*** 
            //char h = 'A';
            //int l = h;



            //** 2.Bilinçli Tür Dönüşümü **

            //double sayi = 51.9;
            //int sayi2 = (int)sayi;

            //Console.WriteLine(sayi2);



            // ** String To Integer **

            //Console.WriteLine("Bir sayı giriniz:"); //10
            //string sayi = Console.ReadLine(); //"10"
            //int yeniSayi = Convert.ToInt32(sayi);


            //Console.WriteLine("Bir sayı giriniz:"); //10,
            //int yeniSayi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(yeniSayi+5);



            //Console.WriteLine("Bir sayı giriniz:"); //10,
            //int yeniSayi = int.Parse(Console.ReadLine());


            // ** Integer To String **

            //double sayi = 12.5;
            //string deger = sayi.ToString();


            // ÖRNEK:
            // Kullanıcıdan 2 kardeşin yaşını alarak ortalamasını ekrana yazdırınız

            Console.WriteLine("1. kardeşin yaşı");
            int yas1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. kardeşin yaşı");
            int yas2 = Convert.ToInt32(Console.ReadLine());

            double sonuc = (yas1 + yas2) / 2.0;
            Console.WriteLine(sonuc);

        }
    }
}
