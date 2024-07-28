namespace _07_WhileLoop
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

            #endregion


        }
    }
}
