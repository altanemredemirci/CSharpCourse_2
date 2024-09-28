namespace _18_OOP_4_Inheritance_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Çeşitli seviyelerdeki öğrenci bilgilerini tutan ve aşağıda verilen işlemleri yapan programı; 
        Kalıtım, kapsülleme ve isimlendirme standartlarını dikkate alarak yazınız.
        Kullanılacak bilgiler: Sınıf tanımlama,yapıcı metot kullanımı ve kalıtımı, kalıtım, kapsülleme, list   kullanımı, akış kontrol mekanizmaları kullanımı,

        Soru: 
        Tüm öğrenciler(Ogrenci) için saklanacak bilgiler:
        ----------------------------------------
            * Ad Soyad(tek özellikte tutulacak)
            * Okul Numarası
            * Okul Adı = "Açıktan Eğitim"	(Alt sınıflarda tanımlanırsa değişecek)
            * Ögretim Duzeyi(IlkOgretim,OrtaOgretim,Lise,Lisans) enum tipinde  4 elemanlı

            NOT: Yukarıdaki bilgileri tutmak için bir ArrayList tanımlanacak(sadece bu 4 bilgi tutacak)

        Tüm öğrenciler(Ogrenci) için uygulanacak işlemler:
        -----------------------------------------
            * Yapıcı metot ile nesne tanımlandığında notlar otomatik olarak ArrayListe eklenecek.(constructer 4     parametre   ile çağırılacak.)
            * NotHesapla(): Ekrana "Not Bilgisi Eksik !" yazdıracak.(Alt sınıflarda tanımlanırsa değişecek)


        LiseOgrencisi için saklanacak bilgiler:
        ---------------------------------------
            * Okul Adı
            * Not1 (1. sınav notu)
            * Not2 (2. sınav notu)


        LiseOgrencisi için uygulanacak işlemler:
        ----------------------------------------
            * Constructer metot 3 özelliği parametre olarak isteyecek.
            * NotHesapla(): 2 notun aritmetik ortalamasını alacak ekrana yazdıracak.

        5	85.00-100	Pekiyi
        4	70.00-84.99	İyi
        3	60.00-69.99	Orta
        2	50.00-59.99	Geçer	
        1	0 - 49.99	Tekrar

        LisansOgrencisi için saklanacak bilgiler:
        -----------------------------------------
            * Fakülte
            * VizeNotu
            * FinalNotu

        LisansOgrencisi için uygulanacak işlemler:
        ------------------------------------------
            * Constructer metot 3 özelliği parametre olarak isteyecek.
            * NotHesapla(): vizenin %40 ını finalin %60 ını alıp ortalamayı aşağıdaki gibi derecelendirerek ekrana       yazdıracak.

            85.00-100	A
            70.00-84.99	B
            60.00-69.99	C
            50.00-59.99	D
            45- 49.99	E
            0 - 44.99	F
        Program sınıfında tanımlanacak metot:

        OgrenciNotHesapla(Ogrenci ogr)
            ogr.NotHesapla

        Main metodunda yapılacak işlemler:
        ----------------------------------
            Lise ve Lisans tipinde ayrı nesne bilgileri girilerek tanımlanacak.
            Nesneler OgrenciNotHesapla metoduna parametre olarak gönderilerek not hesaplama metotları çalıştırılacak.


             */

            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            //IlkOgretim ilkOgretim = new IlkOgretim("Altan Uras Demirci",1,"Mehmet Ali Yilmaz İlkokulu",OkulDuzeyi.IlkOgretim);
            //IlkOgretim ilkOgretim2 = new IlkOgretim("Kıvanç Demirci",2,"",OkulDuzeyi.IlkOgretim);

            //ogrenciler.Add(ilkOgretim);
            //ogrenciler.Add(ilkOgretim2);


            //ogrenciler.Add(new Lise("Kerem Demirci", 3, "Mehmet Ali Yilmaz İlkokulu", OkulDuzeyi.Lise,100,90));
            
            //ogrenciler.Add(new Lisans("Ceylan Demirci", 3, "Mehmet Ali Yilmaz İlkokulu", OkulDuzeyi.Lisans,"Eğitim Fakültesi",45,30));



            ogrenciler.AddRange(new List<Ogrenci>()
            {
                new Lise("Kerem Demirci", 3, "Mehmet Ali Yilmaz İlkokulu", OkulDuzeyi.Lise,100,90),
                new Lisans("Ceylan Demirci", 3, "Mehmet Ali Yilmaz İlkokulu", OkulDuzeyi.Lisans,"Eğitim Fakültesi",45,30),
                new IlkOgretim("Altan Uras Demirci",1,"Mehmet Ali Yilmaz İlkokulu",OkulDuzeyi.IlkOgretim),
                new OrtaOgretim("Kıvanç Demirci",2,"",OkulDuzeyi.OrtaOgretim)
            });



        }
    }
}
