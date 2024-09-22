using System.Reflection;

namespace _17_Class_Object_3_Enum
{

    enum Markalar : byte { Honda=1,Mazda,Ford,Renault,BMW,Mercedes}
    enum Vitesler  { Manuel,Otomatik,YarıOtomatik};
    enum Renkler  { Kırmızı,Beyaz,Siyah,Turuncu,Yeşil};

    class Arac
    {
        protected Markalar Marka;
        protected Vitesler Vites;
        protected Renkler Renk;
        protected int MotorHacmi;
        protected int UretimYili;

        public Arac(Markalar marka, Vitesler vites, Renkler renk, int motorHacmi,int uretimYili)
        {
            Marka = marka;
            Vites = vites;
            Renk = renk;
            MotorHacmi = motorHacmi;
            UretimYili = uretimYili;
        }

        protected void OzellikYaz()
        {
            Console.WriteLine(Marka);
            Console.WriteLine(Renk);
            Console.WriteLine(Vites);
            Console.WriteLine(MotorHacmi);
            Console.WriteLine(UretimYili);
        }
    }

    class Otomobil : Arac
    {
        int KapiSayisi;
        string Model;
        bool Ceker4;
        bool ParkSensoru;

        public Otomobil(Markalar marka,Vitesler vites,Renkler renk,int motorHacmi,int kapiSayisi,string model,bool ceker4,bool parkSensoru,int uretimYili):base(marka,vites,renk,motorHacmi,uretimYili)
        {           
            KapiSayisi = kapiSayisi;
            Model = model;
            Ceker4 = ceker4;
            ParkSensoru = parkSensoru;
        }


        internal new void OzellikYaz()
        {
            base.OzellikYaz();
            Console.WriteLine(Model);
            Console.WriteLine(KapiSayisi);
            Console.WriteLine(Ceker4);
            Console.WriteLine(ParkSensoru);
        } 
        
    }
    class Ticari : Arac
    {
        int TasimaKapasitesi;
        int YolcuKapasitesi;
        bool Ceker4;

        public Ticari(Markalar marka, Vitesler vites, Renkler renk, int motorHacmi, int tasimaKapasitesi, int yolcuKapasitesi, bool ceker4, int uretimYili) : base(marka, vites, renk, motorHacmi, uretimYili)
        {            
            TasimaKapasitesi = tasimaKapasitesi;
            YolcuKapasitesi = yolcuKapasitesi;
            Ceker4 = ceker4;            
        }

        internal new void OzellikYaz()
        {
            base.OzellikYaz();
            Console.WriteLine(TasimaKapasitesi);
            Console.WriteLine(YolcuKapasitesi);
            Console.WriteLine(Ceker4);
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //******* ENUM *********
            //Sabit Veri Tipleri:

            Otomobil otomobil = new Otomobil(Markalar.Renault,Vitesler.Otomatik,Renkler.Beyaz,1500,4,"Megane",false,true,2013);


            otomobil.OzellikYaz();

            #region SORU
            /*
             SORU: Aşağıdaki sınıfları tanımlayınız. 
            Otomobil ve Ticari sınıfları Arac sınıfından türetilecektir.
            Her sınıfa ait tüm sınıf özelliklerine atama yapan yapıcı(Constructor)
            metotlar tanımlanacaktır.
            Main içinden 2 nesne ile örneklendiriniz.
            Nesneler sadece türetilen sınıfların yapıcı metotları kullanılarak
            oluşturulacak.
            Sabit veri tipleri:(enum)
            ----------------------
            Marka:
            Honda,Mazda,Ford,Mercedes,Renault,Toyota,Tofaş,Lamborghini,Ferrari,Sca
            nia,Volvo
            Vites: Manuel, Otomatik, Yarı_Otomatik
            Renk: Kırmızı,Beyaz,Siyah,Turuncu,Yeşil,Mavi,Mor
            Sınıf Adı: Arac
            -------------------
            Marka,
            Vites,
            Renk,
            protected MotorHacmi,
            SınıfAdı: Otomobil
            -------------------------
            KapiSayisi,
            Model,
            Ceker4, (4x4 mü?)
            ParkSensoru, (Park sensörü var mı?)
            public void OtomobilBilgiYaz() => Araca ait tüm bilgileri ekrana
            yazdırsın.
            SınıfAdi: Ticari
            -------------------------
            TasimaKapasitesi,
            Ceker4, (4x4 mü?)
            YolcuKapasitesi
            public void TicariBilgiYaz() => Araca ait tüm bilgileri ekrana
            yazdırsın

            */
            #endregion
        }
    }
}
