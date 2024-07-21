namespace _03_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERATÖRLER

            #region Aritmatik Operatörler

            /* 
             +,-,*,/,%

            % : mod alma: bölme sonucunda kalanı verir.




            //int sayi1 = 10;
            //double sayi2 = 3;

            //double sonuc = sayi1 / sayi2;


            int s1 = 10;
            int s2 = 3;
            int sonuc = 10 % 4; 

            Console.WriteLine(sonuc);
             */

            #endregion


            #region Atama ve İşlemli Atama Operatörleri

            //Atama Operatörü
            //int sayi = 17;


            //int sayi = 5;
            //sayi = sayi + 2;
            //sayi = sayi - 2;
            //sayi = sayi * 2;
            //sayi = sayi / 2;


            //sayi += 2;
            //sayi -= 2;
            //sayi *= 2;
            //sayi /= 2;




            #endregion


            #region Kıyaslama Oparatörleri

            /*
            > 
            <
            <=
            >=            
            == eşit mi?
            != eşit değil mi?

             */

            //int s1 = 10;
            //int s2 = 5;

            //bool sonuc = s1 > s2;
            //bool sonuc2 = s1 < s2;
            //bool sonuc3 = s1 >= s2;
            //bool sonuc4 = s1 <= s2;
            //bool sonuc5 = s1 == s2;
            //bool sonuc6 = s1 != s2;

            //Console.WriteLine("Sonuç: "+sonuc);
            //Console.WriteLine("Sonuç: "+sonuc5);
            //Console.WriteLine("Sonuç: "+sonuc6);



            #endregion


            #region Mantıksal Operatörler

            // AND (VE) Operatörü (&&)
            // Birden fazla koşulun kontrol edilmesi ve hepsinin True olması durumunda True dönecek ise AND kullanılır.
            /*
            True=1 False=0
            yas > 17 && yas<46
                0          0    0
                0          1    0
                1          0    0
                1          1    1

             */

            // Çalışan adayının yaşı 18 ile 45 arasında ise işe alınacak

            //int yas = 34;

            //bool sonuc = yas > 17 && yas<46 ;


            //Console.WriteLine("İşe Alındınız Mı?"+sonuc);



            // Kullanıcıdan Kullanıcı adı ve Şifre alınacak, kullanıcı adı=admin ve şifre 123 ise giriş başarılı yazdırılacak.


            //string username = "admin";
            //string password = "123";

            //Console.WriteLine("Kullanıcı Adı:");
            //string girilenkullaniciadi = Console.ReadLine();

            //Console.WriteLine("Şifre:");
            //string girilensifre = Console.ReadLine();

            //bool dogrulama = username == girilenkullaniciadi && password == girilensifre;
            //Console.WriteLine("Giriş Durumu:" + dogrulama);



            // OR (VEYA) Operatörü (||)
            // Birden fazla koşulun kontrol edilmesi ve herhangi bir koşulun True olması durumunda True dönecek ise OR kullanılır.

            //int sayi = 12;
            //True=1 False=0
            //sayi > 10 || sayi < 5
            //    0          0    0
            //    0          1    1
            //    1          0    1
            //    1          1    1

            //int sayi = 12;

            //bool sonuc = sayi > 10 || sayi < 5;

            //Console.WriteLine(sonuc);




            #endregion


            Console.WriteLine("Yeni Kod Yazıldı");
        }
    }
}
