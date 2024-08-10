namespace _05_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE_1
            // CONDITION - KOŞUL 
            /*
             - If Else 
             - Switch Case

            ******* IF ELSEIF ELSE *******
            Bir program akışı koşullara göre hareket edecek ise If Else yapısı kullanılır. 
            if veya elseif bloklarından biri çalışırsa geriye kalan durumlar kontrol edilmez.

            if(condition==true)
            {
                if koşulu true ise çalışacak kod bloğu
            }
            else if(condition2==true)
            {
                else if koşulu true ise çalışacak kod bloğu
            }
            else if(condition2==true)
            {
                else if koşulu true ise çalışacak kod bloğu
            }
            else if(condition2==true)
            {
               else if koşulu true ise çalışacak kod bloğu
            }
            else 
            {
                if ve elseif koşulları true olmazsa else çalışır.
            }


            Girilen sayı 10'dan büyük ise ekrana BÜYÜK değilse KÜÇÜK yazsın

            1-Başla
            2-Sayı Gir
            3-Eğer Sayı>10 ise Ekrana BÜYÜK yaz ->5 
            4-Değilse Ekrana KÜÇÜK yaz
            5-Bitti

            Console.WriteLine("Sayı Gir");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 10)
            {
                Console.WriteLine("BÜYÜK");
            }
            else
            {
                Console.WriteLine("KÜÇÜK");
            }


             // Kullanıcıdan bir sayı alınız. Alınan sayı negatif mi,pozitif mi,sıfıra eşit mi durumlarını kontrol ediniz ve cevabnı ekrana yazdırınız. 

            1-Başla
            2-Sayı Gir
            3-Eğer sayi>0 ise ekrana POZİTİF yaz
            4-Değilse Eğer sayi==0 ise ekrana SIFIR yaz
            5-Değilse ekrana NEGATİF yaz
             */
            //Console.WriteLine("Sayı Gir");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    Console.WriteLine("POZİTİF");
            //}
            //else if (sayi == 0)
            //{
            //    Console.WriteLine("SIFIR");
            //}
            //else
            //{
            //    Console.WriteLine("NEGATİF");
            //}





            //int yas = 15;
            //int notu = 75;
            //string brans = "yazılım";

            //if (yas > 18)
            //{
            //    if (notu >= 70)
            //    {
            //        if (brans == "yazılım")
            //        {
            //            Console.WriteLine("Bilgisayar Mühendisi");
            //        }
            //        else if (brans == "makine")
            //        {
            //            Console.WriteLine("Makine Mühendisi");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Mezun");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Kaldı");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Yaşınız küçük!!!");
            //}






            #endregion


            #region IF ELSE_2

            // Kullanıcıdan haftanın kaçıncı gününde olduğumuzu rakam olarak alalım ve alınan değere göre gün adını ekrana yazdıralım

            #region Abdullah
            //Console.WriteLine("Lütfen haftanın kaçıncı günü olduğunu giriniz (1: Pazartesi, 2: Salı, ... , 7: Pazar):");
            //int daysayi = int.Parse(Console.ReadLine());

            //string dayadi;

            //if (daysayi == 1)
            //{
            //    dayadi = "Pazartesi";
            //}
            //else if (daysayi == 2)
            //{
            //    dayadi = "Salı";
            //}
            //else if (daysayi == 3)
            //{
            //    dayadi = "Çarşamba";
            //}
            //else if (daysayi == 4)
            //{
            //    dayadi = "Perşembe";
            //}
            //else if (daysayi == 5)
            //{
            //    dayadi = "Cuma";
            //}
            //else if (daysayi == 6)
            //{
            //    dayadi = "Cumartesi";
            //}
            //else if (daysayi == 7)
            //{
            //    dayadi = "Pazar";
            //}
            //else
            //{
            //    dayadi = "Geçersiz gün numarası";
            //}

            //Console.WriteLine("Girdiğiniz gün: " + dayadi);
            #endregion

            #region Yiğit

            //Console.WriteLine("Haftanın kaçıncı günündeyiz?");
            //string gununsayisi = Console.ReadLine();
            //if (gununsayisi == "1")
            //{
            //    Console.WriteLine("Bugün Pazartesi");
            //}
            //else if (gununsayisi == "2")
            //{
            //    Console.WriteLine("Bugün Salı");
            //}
            //else if (gununsayisi == "3")
            //{
            //    Console.WriteLine("Bugün çarşamba");   
            //}
            //else if (gununsayisi == "4")
            //{
            //    Console.WriteLine("Bugün perşembe"); 
            //}
            //else if (gununsayisi == "5")
            //{
            //    Console.WriteLine("Bugün cuma");  
            //}
            //else if (gununsayisi == "6")
            //{
            //    Console.WriteLine("Bugün cumartesi");  
            //}
            //else if (gununsayisi == "7")
            //{
            //    Console.WriteLine("Bugün pazar");               
            //}
            //else
            //{
            //    Console.WriteLine("HATA");
            //}

            #endregion

            #region 1.Çözüm
            //DON:
            //Console.WriteLine("Haftanın Kaçıncı Günü?");
            //int gun = Convert.ToInt32(Console.ReadLine());
            ////int gun = int.Parse(Console.ReadLine());

            //if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //    //koşul içinde tek satır kod çalışacak ise {} gerek yoktur.
            //    Console.WriteLine("Çarşamba");

            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == 7)
            //{
            //    Console.WriteLine("Pazar");
            //}
            //else 
            //{
            //    Console.WriteLine("Gün olarak 1-7 arasında bir değer girilmeli!..");
            //    goto DON;
            //}
            #endregion

            //Console.WriteLine("Haftanın Kaçıncı Günü?");
            //int gun = Convert.ToInt32(Console.ReadLine());
            ////int gun = int.Parse(Console.ReadLine());

            //if(gun > 7 || gun < 1)
            //{
            //    Console.WriteLine("Gün olarak 1-7 arasında bir değer girilmeli!..");
            //}

            ////1,2,3,4,5,6,7
            //else if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}

            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}

            //else if (gun == 3)
            //{ 
            //    Console.WriteLine("Çarşamba");
            //}

            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}

            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}

            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}

            //else 
            //{
            //    Console.WriteLine("Pazar");
            //}



            #endregion


            #region IF ELSE_3
            //Kullanıcıdan iki ürün fiyatı isteyin, ürün fiyat toplamları 2500 tl geçerse ucuz ürüne  % 25 indirim uygulayınız

            #region Abdullah

            //Console.WriteLine("Birinci ürünün fiyatını giriniz:");
            //double urun1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("İkinci ürünün fiyatını giriniz:");
            //double urun2 = Convert.ToDouble(Console.ReadLine());


            //double toplam = urun1 + urun2;

            //if (toplam > 2500)
            //{

            //    //double digerurun = (urun1 < urun2) ? urun1 : urun2;
            //    double digerurun;
            //    if (urun1 < urun2)
            //    {
            //        digerurun = urun1;
            //    }
            //    else
            //    {
            //        digerurun = urun2;
            //    }


            //    double indirim = digerurun * 0.25;
            //    digerurun -= indirim;

            //    Console.WriteLine("Toplam fiyat 2500 TL'yi geçtiği için ucuz ürüne %25 indirim uygulandı.");
            //    Console.WriteLine($"İndirimli ucuz ürün fiyatı: {digerurun:F2} TL");


            //    toplam = (urun1 < urun2) ? digerurun + urun2 : urun1 + digerurun;
            //}

            //Console.WriteLine($"Toplam fiyat: {toplam:F2} TL");

            //Console.ReadLine();

            #endregion


            #region Arhan
            //Console.WriteLine("1.ürün fiyatlarını giriniz.");
            //int urun1 = Convert.ToInt32(Console.ReadLine());   //-10

            //Console.WriteLine("2.ürün fiyatlarını giriniz.");
            //int urun2 = Convert.ToInt32(Console.ReadLine());   //-5

            //if (urun1 < 1)
            //{
            //    Console.WriteLine("1. ürün geçersiz fiyat");
            //}

            //if (urun2 < 1)
            //{
            //    Console.WriteLine("2. ürün geçersiz fiyat");
            //}



            //if ((urun1 + urun2) <= 2500)
            //{
            //    Console.WriteLine(urun1 + urun2);
            //}
            //else
            //{
            //    if (urun1 > urun2)
            //    {
            //        Console.WriteLine("toplam:" + urun2 / 100 * 75 + urun1);
            //    }

            //    else
            //    {
            //        Console.WriteLine("toplam:" + urun1 / 100 * 75 + urun2);
            //    }
            //}
            #endregion

            #region Yiğit
            //Console.WriteLine("1. ürün :");
            //double firstprice = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2. ürün :");
            //double secondprice = Convert.ToDouble(Console.ReadLine());

            //double toplam = secondprice + firstprice;

            //if (toplam > 2500)
            //{
            //    if (firstprice < secondprice)
            //    {
            //        firstprice = firstprice * 0.75;
            //    }
            //    else
            //    {
            //        secondprice = secondprice * 0.75;
            //    }
            //}

            //toplam = secondprice + firstprice;

            //Console.WriteLine("Ödeyeceğiniz miktar: " + toplam);


            #endregion




            #endregion


            #region IF ELSE_4
            // Aylık geliri 40000 üstünde ise %12 vergi kesilecek,
            // 40000 ve altında ise %9 vergi kesimi yapılarak 
            // kullanıcıya yeni gelirini bu hesaplamalar sonucunda gösteriniz

            #region Abdullah

            //Console.WriteLine("Aylık gelirinizi giriniz:");
            //double aylik_gelir = Convert.ToDouble(Console.ReadLine());

            //double vergi;
            //double yeniIncome;


            //if (aylik_gelir > 40000)
            //{
            //    vergi = 0.12;
            //}

            //else
            //{
            //    vergi = 0.09;
            //}


            //double tax = aylik_gelir * vergi;
            //yeniIncome = aylik_gelir - tax;


            //Console.WriteLine($"Vergi oranı: %{vergi * 100}");
            //Console.WriteLine($"Kesilen vergi miktarı: {tax:F2} TL");
            //Console.WriteLine($"Yeni geliriniz: {yeniIncome:F2} TL");

            #endregion

            #region Arhan
            //Console.WriteLine("aylık gelirinizi giriniz:");
            //double gelir = Convert.ToDouble(Console.ReadLine());

            //if (gelir > 40000)
            //{
            //    Console.WriteLine("%12 vergi kesilmiştir. Mevcut aylık geliriniz:" + gelir * 0.88);
            //}

            //else
            //{
            //    Console.WriteLine("%9 vergi kesilmiştir. Mevcut aylık geliriniz:" + gelir * 0.91);
            //}

            #endregion

            #endregion


            #region IF ELSE_5
            /* 
            0-100 harcamışsa 0.35 ile fiyatlandırılacak
            101-250=> 0.38 üzerinde hesaplandırılacak
            251-400=> 0.41 üzerinde 
            401-600=> 0.42
            600 üstü ise 120 tl indirim yapılacak ve fiyatlandırma 0.43 üzerinde verilecek
            */


            //Console.WriteLine("Harcama:");
            //int harcama = Convert.ToInt32(Console.ReadLine());

            //if(harcama>=0 && harcama < 101)
            //{
            //    Console.WriteLine(harcama*0.35);
            //}
            //else if(harcama>100 && harcama < 251)
            //{
            //    Console.WriteLine(harcama*0.38);
            //}
            //else if (harcama > 250 && harcama < 401)
            //{
            //    Console.WriteLine(harcama * 0.41);
            //}
            //else if (harcama > 400 && harcama < 601)
            //{
            //    Console.WriteLine(harcama * 0.42);
            //}
            //else
            //{
            //    Console.WriteLine((harcama*0.43)-120);
            //}
            #endregion


            #region IF ELSE_6

            //1-50 arasındaki sayıların içinde 7'e tam bölünenleri ekrana teker teker yazdırınız.

            //int sayi = 1;

            //BASLA:
            //if (sayi % 7 == 0)
            //{
            //    Console.WriteLine(sayi);
            //}
            //sayi++;
            //if(sayi<50)
            //    goto BASLA;

            #endregion


            #region IF ELSE_7
            /*
             Kullanıcıdan isim, yaş, maaş ve çocuk sayısı alınsın.

                Eğer kulanıcının yaşı 45'in altındaysa;
                Çocuk sayısına bakılacak. Ve çocuk sayısı 3'ten az ise çocuk başına 2500₺,
                                                          3'ten çok ise çocuk başına 2000₺ 
                                                                maaşa ekleme yapılacak.
                45'in üzerinde ise çocuk başına para verilmeyecek ancak 5000₺ ekleme yapılacak.
                Son olarak ekrana : "Nesrin Yılmaz, Maaşınız: 40000₺" yazılacak. 
             */

            //Yiğit Ali
            //Console.WriteLine("Adınız:");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Yaşınız:");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kaç çocuğunuz var:");
            //int cocuksayisi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Maaş:");
            //int maas = Convert.ToInt32(Console.ReadLine());

            //if (yas > 0 && yas < 45)
            //{
            //    if (cocuksayisi > 3)
            //    {
            //        maas = maas + (cocuksayisi * 2500);
            //        Console.WriteLine("Sayın" + ad + "alacağınız maaş :", maas);
            //    }
            //    else
            //    {
            //        maas = maas + (cocuksayisi * 2000);
            //        Console.WriteLine("Sayın" + ad + "alacağınız maaş :", maas);

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sayın" + ad + "alacağınız maaş :" + (maas + 5000));
            //}



            #endregion


            #region ÖDEV

            // Kullanıcıdan 3 adet sayı alınız ve bu sayıları şekil A görüldüğü gibi büyükten küçüğe sıralı bir şekilde ekrana yazdırınız
            //Şekil a: 15>13>5

            int sayi1, sayi2, sayi3;
            Console.WriteLine("1. Sayıyı Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Sayıyı Giriniz");
            sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                Console.WriteLine("En Büyük Sayı:" + sayi1);
                if (sayi2 > sayi3)
                {
                    Console.WriteLine("Ortanca Sayı:" + sayi2);
                    Console.WriteLine("En Küçük Sayı:" + sayi3);
                }

                else
                {
                    Console.WriteLine("Ortanca Sayı:" + sayi3);
                    Console.WriteLine("En Küçük Sayı:" + sayi2);
                }
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                Console.WriteLine("En Büyük Sayı:" + sayi2);
                if (sayi1 > sayi3)
                {
                    Console.WriteLine("Ortanca Sayı:" + sayi1);
                    Console.WriteLine("En Küçük Sayı:" + sayi3);
                }

                else
                {
                    Console.WriteLine("Ortanca Sayı:" + sayi3);
                    Console.WriteLine("En Küçük Sayı:" + sayi3);
                }
            }
            else
            {
                Console.WriteLine("En Büyük Sayı:" + sayi3);
                if (sayi2 > sayi1)
                {
                    Console.WriteLine("Ortanca Sayı:" + sayi2);
                    Console.WriteLine("En Küçük Sayı:" + sayi1);
                }
                else
                {
                    Console.WriteLine("Ortanca Sayı:" + sayi1);
                    Console.WriteLine("En Küçük Sayı:" + sayi2);
                }
            }





            #endregion


        }
    }

}