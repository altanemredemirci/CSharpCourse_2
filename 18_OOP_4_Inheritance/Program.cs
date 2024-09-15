namespace _18_OOP_4_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INHERITANCE - KALITIM
            // Ortak özelliklere sahip classların tek bir class üzerinden miras alma yöntemi ile ortak olan özellikleri yazılmadan çekmesine ve sadece kendisine özel olan özellikleri tanımlamasına denir.

            Anasinifi anasinifi = new Anasinifi();
       
        }
    }
    //KOLEJ => Anasınıfı(Ad,Soyad,TC,Numara,Veli Numarası,BoyamaSayisi)
    //         İlkokul(Ad,Soyad,TC,Numara,Veli Numarası,KitapSayisi)
    //         Ortaokul(Ad,Soyad,TC,Numara,Veli Numarası,GeziSayisi)
    //         Lise(Ad,Soyad,TC,Numara,Veli Numarası,Telefon)
    
    class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TC { get; set; }
        public int OkulNumara { get; set; }
        public string VeliNumara { get; set; }

        //protected: Sadece kendisinden türeyen classlarda kullanılabilir.


        public void Yaz()
        {
            Console.WriteLine("Ben bir öğrenciyim!!");
        }

        protected void Oku()
        {
            Console.WriteLine("Okuyom Ben YAAA!!");
        }
    }

    class Anasinifi:Ogrenci
    {
        public Anasinifi() //Constructor Method -  Kurucu Metot
        {
            this.Oku();
        }
        public int BoyamaSayisi { get; set; }
    }

    class Ilkokul:Ogrenci
    {
        public int KitapSayisi { get; set; }
    }
    class Ortaokul : Ogrenci
    {
        public int GeziSayisi { get; set; }
    }
    class Lise : Ogrenci
    {
        public string TelefonNumara { get; set; }
    }
}
