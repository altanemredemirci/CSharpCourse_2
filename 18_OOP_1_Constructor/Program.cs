namespace _18_OOP_1_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //GARBAGE COLLECTOR : Bütün kodlar,değişkenler,methods her yapı RAM Bellek tutulur. Ram bellek belirli bir doluluğa ulaştığında en eski,en az kullanılan veya en kolay tanımlanabilir yapıları siliyor. 


            //CONSTRUCTOR METHOD

            /*
              * Class ile AYNI İSME sahiptir.
              * Herhangi bir dönüş terimi almaz. Void, int, return vb. YOK
              * Default olarak boş şekilde görünmez-gizli tanımlanır.
              * Classtan Instance alındığı an otomatik çalışır.
             */


            //Ogrenci ogrenci = new Ogrenci();
            //ogrenci.ad = "Ali";
            //ogrenci.soyad = "Veli";


            //Console.WriteLine("Adı:");
            //ogrenci.ad = Console.ReadLine();
            //Console.WriteLine("Soyadı:");
            //ogrenci.soyad=Console.ReadLine();


            //ogrenci.Kayit();



            #region ARABA URETIM OTOMASYONU
            /*
             Araba:Marka,Model,Renk,MotorHacmi,UretimYili
                * Araba classı oluşturulacak.Oluşturulan classın propertyleri(marka,model,...) eklenecek
            

             Kayıt,Listeleme,Guncelleme,Filtreleme(Marka)
             */

            Araba a1 = new Araba(1,"Mercedes","E200","Siyah",3000,1985);
            Araba a2 = new Araba(2,"Mustang","Shelby500","Kırmızı",5000,1967);


            //Araba.Listele();

            //Console.WriteLine("***********");

            //Araba.Ara();
            #endregion

            Araba.Guncelleme();

        }
    }

    class Ogrenci
    {
        internal string ad;
        internal string soyad;


        //public Ogrenci()
        //{
        //    Console.WriteLine("CONSTRUCTOR Metot Çalıştı");
        //}

        //public Ogrenci()
        //{
        //    Console.WriteLine("Adı:");
        //    this.ad = Console.ReadLine();
        //    Console.WriteLine("Soyadı:");
        //    this.soyad = Console.ReadLine();
        //}

        public Ogrenci()
        {
            Kayit();
        }



         void Kayit()
        {
            Console.WriteLine("Adı:");
            this.ad = Console.ReadLine();
            Console.WriteLine("Soyadı:");
            this.soyad = Console.ReadLine();
        }
    }
}
