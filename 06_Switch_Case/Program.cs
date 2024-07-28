namespace _06_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch Case 
            /*
               Console.WriteLine("Sayı:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Bir");
                    break;

                case 2:
                    Console.WriteLine("İki");
                    break;

                default:
                    Console.WriteLine("Sayı yanlış");
                    break;
            }



             
             */

            #region Klavyeden iki sayı, bir işlem(+,-,*,/) girilecek. Sayılar girilen işleme göre sonucu ekrana yazdıran switch case.

            //Console.WriteLine("1. sayı");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("1. sayı");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("yapılacak işlem:");
            //string islem = Console.ReadLine();

            //switch (islem)
            //{
            //    case "+":
            //        Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
            //        break;
            //    case "-":
            //        Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
            //        break;
            //    case "*":
            //        Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
            //        break;
            //    case "/":
            //        if (sayi2 != 0)
            //        {
            //            Console.WriteLine("Sonuç: " + ((double)sayi1 / sayi2));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Hata: Bir sayı sıfıra bölünemez.");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz işlem.");
            //        break;

            //}






            #endregion


            #region    
            /*
            kullanıcıdan alınan cinsiyet bilgisine göre
         ==> ERKEK ise
            yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            ==> KADIN ise
             yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 5600 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5600 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            ==> cinsiyet bilgisi switch-case ile sorgulanacak
             */


            Console.WriteLine("Cinsiyet:");
            string cinsiyet = Console.ReadLine().ToLower();
            switch (cinsiyet)
            {
                case "erkek":
                    Console.WriteLine("Yaş:");
                    int yas = Convert.ToInt32(Console.ReadLine());
                    if (yas > 59)
                    {
                        Console.WriteLine("Maaş:");
                        double maas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Emekli İkramiyeniz:"+(maas*10));
                    }
                    else
                    {
                        Console.WriteLine("Prim Gün Sayısı:");
                        int prim= Convert.ToInt32(Console.ReadLine());

                        if (prim >= 6000)
                        {
                            Console.WriteLine("Maaş:");
                            double maas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Emekli İkramiyeniz:" + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik Hayal Çalışmaya Devam...");
                        }
                    }
                    break;

                case "kadın":
                    Console.WriteLine("Yaş:");
                    int yas2 = Convert.ToInt32(Console.ReadLine());
                    if (yas2 > 45)
                    {
                        Console.WriteLine("Maaş:");
                        double maas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Emekli İkramiyeniz:" + (maas * 10));
                    }
                    else
                    {
                        Console.WriteLine("Prim Gün Sayısı:");
                        int prim = Convert.ToInt32(Console.ReadLine());

                        if (prim >= 5600)
                        {
                            Console.WriteLine("Maaş:");
                            double maas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Emekli İkramiyeniz:" + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik Hayal Çalışmaya Devam...");
                        }
                    }

                    break;

                default:
                    Console.WriteLine("Hatalı Cinsiyet Bilgisi!!");
                    break;
            }

            #endregion
        }
    }
}
