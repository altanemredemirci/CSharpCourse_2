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

            //Console.WriteLine("1. kardeşin yaşı");
            //int yas1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2. kardeşin yaşı");
            //int yas2 = Convert.ToInt32(Console.ReadLine());

            //double sonuc = (yas1 + yas2) / 2.0;
            //Console.WriteLine(sonuc);


            // STRING aslında karakterler topluluğudur(array - koleksiyon).
            // 

            //string isim = "altan emre";
            ////koleksiyonlar içerisindeki değerleri INDEX adı verilen 0 dan başlayan 1'er 1'er artan bir numaralandırma yöntemi ile tutarlar.


            //Console.WriteLine(isim.IndexOf('e'));
            //Console.WriteLine(isim.LastIndexOf('e'));




            //string metin = "    Ali      ";
            //Console.WriteLine(metin);
            //Console.WriteLine(metin.TrimStart(' '));
            //Console.WriteLine(metin.TrimEnd(' '));
            //Console.WriteLine(metin.Trim(' '));


            //string ad = "altan";
            //string soyad = "EMRE";

            //Console.WriteLine(ad.ToUpper());
            //Console.WriteLine(soyad.ToLower());

            //ad = ad.ToUpper();

            //Console.WriteLine(ad);
            //Console.WriteLine(ad);
            //Console.WriteLine(ad);
            //Console.WriteLine(ad);



            //string metin = "Bu Türkiye yaşanmaz oldu.";

            //Console.WriteLine(metin.Substring(3));
            //Console.WriteLine(metin.Substring(3,5));


            // ** DATETIME TİPİ **
            //DateTime zaman = DateTime.Now;

            //Console.WriteLine(zaman);
            //Console.WriteLine(zaman.Year);
            //Console.WriteLine(zaman.Month);
            //Console.WriteLine(zaman.Day);
            //Console.WriteLine(zaman.Hour);
            //Console.WriteLine(zaman.Minute);
            //Console.WriteLine(zaman.Second);


            DateTime zaman2 = new DateTime(2000, 12, 24,12,34,45);
            Console.WriteLine(zaman2);


        }
    }
}
