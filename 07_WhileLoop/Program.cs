﻿namespace _07_WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             LOOPS - DÖNGÜLER
                *While
                *For
                *Do-While
                *Foreach
                
            Döngüler belirli kodları veya görevleri tekrar  tekrar çalışmasını sağlayan kod yapısıdır.

            *** WHILE ***
            
            // 1-10 arasındaki sayıları ekrana alt alta yazdırınız
            
            int sayac = 1;

            while (sayac < 11) //true olduğu sürece tekrarlar.
            {
                Console.WriteLine(sayac);
                sayac++;
            }
             */

            //BREAK    : break komutu döngüyü kırar.   

            /*
            int sayac = 1;

            while (sayac < 11) //true olduğu sürece tekrarlar.
            {
                Console.WriteLine(sayac);
                if (sayac == 5)
                {
                    break;
                }
                sayac++;
            }
             */


            //CONTINUE : continue komutu döngü koşul satırına geri gitmeyi sağlar.

            //int sayac = 1;

            //while (sayac < 11) //true olduğu sürece tekrarlar.
            //{
            //    Console.WriteLine(sayac);
            //    if (sayac == 5)
            //    {
            //        continue;
            //    }
            //    sayac++;
            //}

            #region 200 den başlayarak 0 a kadar olan ve 3'ün katı olan sayıları ekrana yazdırınız.

            //int i = 200;

            //while (i > 0)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);                   
            //    }
            //    i--;

            //}


            #endregion

            #region 1 ile 5 arasındaki sayıların toplamını ekrana yazdıran while döngüsü

            //int i = 1;
            //int toplam=0;
            //while (i < 6)
            //{
            //    toplam = toplam + i;
            //    i++;
            //}
            //Console.WriteLine("Toplam:"+toplam);

            #endregion

            #region Ödev

            // Kullanıcıdan 0 girilene kadar pozitif sayılar girmesi istensin. 0 girilene kadar girilen pozitif sayılar toplansın ve ortalaması hesaplansın.
            // Kullanıcı 0 girdiğinde döngü bitsin ve toplam,ortalama ekrana yazdırılsın.
            // ** Kullanıcı ilk sayıyı 0 girerse tekrar sayı istensin
            // ** kullanıcı negatif sayı girerse "lütfen Pozitif Sayı Giriniz!!" uyarısını verilsin.

            //int sayac = 0;
            //int toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0 && sayac == 0)
            //        continue;

            //   if (sayi == 0)
            //        break;

            //    if (sayi < 0)
            //    {
            //        Console.WriteLine("Lütfen Pozitif Sayı Giriniz!!!");
            //        continue;
            //    }

            //    toplam += sayi;
            //    sayac++;
            //}

            //Console.WriteLine("Toplam:"+toplam);
            //Console.WriteLine("Ortalama:"+(toplam/sayac));



            #endregion


            #region Kullanıcıya kayıtlı username ve şifre giriş paneli için 3 hak veriniz ve 3 hak giriş yapamaz ise sistemi 10 saniye kitleyiniz. Kullanıcıya gerekli bütün uyarıları yapınız.

            string username = "admin";
            string password = "ab18";

            int hak = 3;
            while (hak > 0)
            {
                Console.WriteLine("Kullanıcı adınız:");
                string kullaniciadi = Console.ReadLine();

                Console.WriteLine("Şifreniz:");
                string sifre = Console.ReadLine();

                hak--;

                if (kullaniciadi == username && sifre == password)
                {
                    Console.WriteLine("Giriş Başarılı");
                    break;
                }

                else if (hak == 0)
                {
                    Console.WriteLine("Giriş Hakkınız Kalmadı...");
                    Console.WriteLine("Sistem kilitlendi");
                    Thread.Sleep(5000);
                    Console.WriteLine("Sistem açıldı");
                    hak = 3;
                }

                else
                {
                    Console.WriteLine("Giriş Başarısız!!");
                    Console.WriteLine("Tekrar Deneyiniz.");
                }


            }


            Console.WriteLine("Sistem kilitlendi");
            Thread.Sleep(5000);
            // Console.WriteLine("Sistem açıldı");
            Environment.Exit(0);

            #endregion



        }
    }
}
