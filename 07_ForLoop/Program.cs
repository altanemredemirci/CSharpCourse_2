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

            int sum = 0;
            while (true)
            {
                Console.WriteLine("Başlangıç değeri:");//20
                int basla = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Bitiş değeri:");//10
                int bitis = Convert.ToInt32(Console.ReadLine());

                if (basla > bitis)
                {
                    Console.WriteLine("Başlangıç Değeri Bitiş Değerinden Küçük Olmalıdır!!");
                    int deger = basla;
                    basla = bitis; //basla=10; deger=20
                    bitis = deger; //bitis=20
                }

                for (int i = basla; i < bitis; i++)
                {
                    //Koşul = Condition(if,switch)
                    if (i % 13 == 0)
                    {
                        sum += i;
                    }

                }
                break;


            }

            Console.WriteLine(sum);





            #endregion






        }
    }
}
