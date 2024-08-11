namespace _07_ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Anlatımı
            // 1-10 arasındaki sayıların ekrana yazılışı

            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);

            //    i++;
            //}

            //for(int i=1; i<11; i++)
            //{
            //    Console.WriteLine(i);
            //}



            /*
             1-sayacı tanımlıyor
             2-koşul kontrolü
             3-Yapılacak işlem kodu
             4-sayacı manipüle ediyor

             5-koşul kontrolü
             6-Yapılacak işlem kodu
             7-sayacı manipüle ediyor

            ...
             */
            #endregion

            #region Ekrana 20 den 0 a doğru sayıları yazdırınız

            //for (int i = 20; i >=0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Ekrana kullanıcıdan alınan başlangıç ve bitiş değeri arasındaki 3'ün katları olan sayıları yazdırınız


            //while (true)
            //{
            //    Console.WriteLine("Başlangıç değeri:");
            //    int basla = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Bitiş değeri:");
            //    int bitis = Convert.ToInt32(Console.ReadLine());

            //    if (basla > bitis)
            //    {
            //        Console.WriteLine("Başlangıç Değeri Bitiş Değerinden Küçük Olmalıdır!!");
            //    }
            //    else
            //    {
            //        for (int i = basla; i < bitis; i++)
            //        {
            //            //Koşul = Condition(if,switch)
            //            if (i % 3 == 0)
            //            {
            //                Console.WriteLine(i);                            
            //            }

            //        }
            //        break;
            //    }

            //}





            #endregion


            #region Ekrana kullanıcıdan alınan başlangıç ve bitiş değeri arasındaki 3'ün katları olan sayıları yazdırınız
            //while (true)
            //{
            //    Console.WriteLine("Başlangıç değeri:");
            //    int basla = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Bitiş değeri:");
            //    int bitis = Convert.ToInt32(Console.ReadLine());

            //    if (basla > bitis)
            //    {
            //        Console.WriteLine("Başlangıç Değeri Bitiş Değerinden Küçük Olmalıdır!!");
            //    }
            //    else
            //    {
            //        for (int i = basla; i < bitis; i++)
            //        {
            //            //Koşul = Condition(if,switch)
            //            if (i % 3 == 0)
            //            {
            //                Console.WriteLine(i);
            //            }

            //        }
            //        break;
            //    }

            //}
            #endregion

            #region Ekrana kullanıcıdan alınan başlangıç ve bitiş değeri arasındaki 13'ün katları olan sayıların toplamını yazdırınız.Başlangıç değeri bitiş değerinden büyük girilirse değerler birbiri ile değiştirilsin

            //int sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Başlangıç değeri:");//20
            //    int basla = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Bitiş değeri:");//10
            //    int bitis = Convert.ToInt32(Console.ReadLine());

            //    if (basla > bitis)
            //    {
            //        Console.WriteLine("Başlangıç Değeri Bitiş Değerinden Küçük Olmalıdır!!");
            //        int deger = basla;
            //        basla = bitis; //basla=10; deger=20
            //        bitis = deger; //bitis=20
            //    }

            //    for (int i = basla; i < bitis; i++)
            //    {
            //        //Koşul = Condition(if,switch)
            //        if (i % 13 == 0)
            //        {
            //            sum += i;
            //        }

            //    }
            //    break;


            //}

            //Console.WriteLine(sum);
            #endregion
            #region Kullanıcıdan alınan bir sayının faktörüyeli hesaplayan for döngüsünü yazınız.
            // 5 => 1*2*3*4*5 =120

            //Console.WriteLine("faktöriyel hesaplanacak sayı:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int fakt = 1;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    fakt *= i;
            //}
            //Console.WriteLine("Faktöriyel:"+fakt);
            //Console.WriteLine("Faktöriyel:{0}",fakt);
            //Console.WriteLine($"Faktöriyel:{fakt}");



            #endregion

            #region PASCAL ÜÇGENİ
            /*
             
            *
            **
            ***
            ****
            *****
            ******
             
             */

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j <i ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region KARE
            /*
             
            *********
            *       *
            *       *
            *       *
            *       *
            *       *
            *********
               
             */
            //for (int i = 1; i < 10; i++)
            //{
            //    if(i==1 || i == 9)
            //    {
            //        Console.WriteLine("*********");
            //    }
            //    else
            //    {
            //        Console.WriteLine("*       *");
            //    }
            //}




            #endregion

            #region KARE
            /*
             
                    *
                   ***
                  *****
                 *******
                *********
               ***********
              
             */

            //int sayac = 1;
            //int bosluk = 10;

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j < bosluk; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    bosluk--;

            //    for (int k = 0; k < sayac; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    sayac += 2;
            //    Console.WriteLine();

            //}




            #endregion

            #region ÇARPIM TABLOSU

            /*
             1*1=1  2*1=2 3*1=3
             1*2=2  2
             
             */



            //for (int i = 1; i < 11; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write($"{j}x{i}={i*j}\t");
            //    }

            //    Console.WriteLine();
            //}

            #endregion




        }
    }
}
