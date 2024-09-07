using System.Collections;

namespace _15_SortedList_QueueList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    SortedList sozluk = new SortedList() {
            //        {"Bugun","Today"},
            //        {"Yarin","Tommorrow"},
            //        {"Hava","Wheather" },
            //        {"Gokyuzu","Sky" },
            //        {"Karli","Snowy" },
            //        {"Gunesli","Sunny" },
            //        {"Bulutlu","Cloudy" },
            //        {"Acik","Clear" },
            //        {"Kapali","Cloudy" },
            //        {"Mahmut",1 },
            //        {"Kamil",2 },
            //        //{3,"HATA" } // HATA Verir. Key tipleri aynı olmalıdır.
            //    };

            //Console.WriteLine(sozluk["Acik"]);
            //Console.WriteLine(sozluk["Mahmut"]);

            //sozluk["Bir"] = "One"; // Yoksa ekler
            //sozluk["Bir"] = "Yek"; // Varsa günceller.


            //foreach (DictionaryEntry item in sozluk)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in sozluk.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in sozluk.Values)
            //{
            //    Console.WriteLine(item);
            //}

            #region Sozluk Uygulaması
            /*
             
              sözlük uygulaması istenmektedir.Tr - Eng
         sözlük = { "siyah":"black",,,,}
            kullanıcı 4 girene kadar sorulur.
             1 - Arama
             2 - Çıkarma
             3 - Listeleme
             4 - Çıkış

        Kullanıcı 1'e basarsa ->
            - Aranacak olan kelimeyi giriniz:
                -Bu kelime dizide varsa eng karşılığı yazılır.
            -Yoksa uygulamanın gelişmesine yardımcı olmak ister msiniz(E-H):
                -E ise bu kelimenin karşılığı istenir ve sözlüğe eklenir
                -H ise bişey yapılmaz
        Kullanıcı 2'ye basarsa ->
            - Çıkarılmak istenen kelime :
            -Kelime sözlükte varsa çıkartılır
            - Yoksa uyarı verilir.
        Kullanıcı 3'e basarsa ->
            - Tum key value lar listelenir
            -KEY->VALUE
        Kullanıcı 4'e basarsa ->
            - Döngü sonlanır.
             */
            #endregion

            SortedList sozluk = new SortedList()
            {
                { "siyah","black" },
                { "beyaz","white" }
            };

            while (true)
            {
                Console.WriteLine("1-Arama\n2-Çıkarma\n3-Listeleme\n4-Çıkış\nSeçiminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1) 
                {
                    Console.WriteLine("Aranacak Kelime:");
                    string kelime = Console.ReadLine();

                    if (sozluk.Contains(kelime))
                    {
                        Console.WriteLine(sozluk[kelime]);
                    }
                    else
                    {
                        Console.WriteLine("Kelime bulunamadı. Sözlüğü geliştirmek ister misiniz?(E/H)");
                        string cevap = Console.ReadLine().ToUpper();

                        if (cevap == "E")
                        {
                            Console.WriteLine("Kelimenin ingilizcesini gir");
                            string word = Console.ReadLine();

                            sozluk[kelime] = word;
                        }
                        else
                        {
                            Console.WriteLine("Peki...");
                        }

                    }

                }
                else if (secim == 2) 
                {
                    Console.WriteLine("Çıkarılacak Kelime:");
                    string kelime = Console.ReadLine();

                    if (sozluk.Contains(kelime))
                    {
                        sozluk.Remove(kelime);
                    }
                    else
                    {
                        Console.WriteLine("Kelime zaten yok!!!");
                    }

                }
                else if (secim == 3) 
                {
                    foreach (DictionaryEntry item in sozluk)
                    {
                        Console.WriteLine(item.Key+":"+item.Value);
                    }
                }
                else if (secim == 4) 
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Tuşlama");
                }

            }
         




        }
    }
}
