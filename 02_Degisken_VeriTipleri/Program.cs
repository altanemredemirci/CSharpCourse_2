namespace _02_Degisken_VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // DEĞİŞKENLER
            /*
             Değişken: Progralama tarafında data tutmak,taşımak veya bir işlem uygulamak için kullanılan yapıdır.

             isim = Altan Emre

            *** Yazılım Adlandırma Kuralları(Case-Sensitive) ***
            Yanlışlar: 2sayi, ?sayi, ad soyad,ad!soyad, sayi?, 
            Doğrular:  sayi2, _sayi, adsoyad, ad_soyad, sayi_, 
            *Yazılım dillerinde kabul edilen tek özel karakter _ alt çizgi
                        
            SnakeCase = ad_soyad
            CamelCase = adSoyad
            KebebCase = ad-soyad
            UpperCase = ADSOYAD
            LowerCase = adsoyad
            
            *** DEĞİŞKEN TANIMLAMA ***
            veritipi değişkenadı = değer;
             
             */


            //string isim = "Altan Emre DEMİRCİ";
            //Console.WriteLine(isim);

            //string isim2 = "Uras DEMİRCİ";
            //Console.WriteLine(isim2);

            //isim2 = "Kerem DEMİRCİ";


            /* 
             ******** VERİ TİPLERİ ********
             
            ** SAYISAL VERİ TİPLERİ **
            Tam Sayı Veri Tipleri: sbyte,byte,short,ushort,int,uint,long,ulong
                     long tc = 12345678901;
                     int yas = 34; //sbyte 2bit   short 4bit  int 10bit
                     int yas2 = 16;
                    
            Ondalıklı Sayı Veri Tipleri: float,double 
                     float bakiye = 12.5f;
                     double bakiye2 = 12.5;
             
            Decimal 
                     decimal sayi = 1;
                     decimal sayi2 = 1.5m;
                     decimal sayi3 = 1.58237892473897483m;           



             ** SÖZEL VERİ TİPLERİ **
             String : "" çift tırnak ile tanımlanır. Herhangi bir karakter sınırı yoktur.
             Char : '' tek tırnak ile tanımlanır. bir karakter alabilir.
                    
                    //string username = "ceset1303?";


                    //string tc = "12345678909";

                    //Console.WriteLine(tc+10);
                    //Console.WriteLine(tc+"altanemre");


                    //char karakter = 'A';
                    //char karakter2 = '2';
                    //char karakter3 = '!';

                    //Console.WriteLine(karakter);
                    

             ** MANTIKSAL VERİ TİPLERİ **
            Boolean : bool olarak tanımlanır ve sadece true,false datası tutar.
                
                bool cevap = true;

                bool sonuc = 12>3;

                Console.WriteLine(sonuc);

             */

            Console.WriteLine('A'+":"+(char)65);
            Console.WriteLine('A'+":"+(int)'A');


            /*
            8bit=> 1byte
            1024 byte => 1KB
            1024 KB => 1MB
            1024 MB => 1GB
            1024 GB => 1TB
             

            Product.Where(i=> i.Name==name).FirstOrDefault() 0.86ms
            Product.FirstOrDefault(i=> i.Name==name)  0.40ms
            Product.Find(id) 0.12ms

             */

            //CONSTANT - SABİT DEĞİŞKEN
            // atanan değer değiştirilemez
            //const int sayi = 19;
            //sayi = 1;


            //int yas1;
            //int yas2;

            //int yas1, yas2;

            //yas1 = 10;
            //yas2 = 24;





            //int yas1=10;
            //int yas2=24;

            int yas1=10, yas2=24;

        }
    }
}
