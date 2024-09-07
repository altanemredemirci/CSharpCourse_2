using System.Collections;
using System.Drawing;

namespace _14_ManavOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MANAV OTOMASYONU
            /*
            HAL - Toptancı
           * Manava ürün almaya geliyor. Manava "Meyve mi Sebze mi?"
           * 5 adet meyve listelenecek
           * Meyve seçildikten sonra "Kaç Kilo?"
           * Meyve satıldıktan sonra "Başka bir arzunuz var mı?" 
           * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
           * Hayır. "iyi günler" diyerek manav kısmına geçeceğiz
           * 
           * 
            MANAV
           * "Meyve mi Sebze mi?" diye müşteriye soracağız.
           * Halden almış olduğumuz meyve veya sebzeleri listeleyeceğiz.
           * Müşteri ürün seçtikten sonra "Kaç Kilo?" sorusunu sorun
           * Girilen kilo bilgisini manavın halden aldığı kilo ile kıyaslayarak ürün satınız.
           * Elde olan ürün var olan kilosu kadar satılırsa, manavın ürünlerinden silin.
           * Ürün satıldıktan sonra "Başka bir arzunuz var mı?"
           * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
           * Hayır derse "Afiyet olsun" Müşteri kısmına geçiniz

           MÜŞTERİ
           * Alınan ürünleri ekrana yazdırınız.
            */
            #endregion

            ArrayList halMeyveler = new ArrayList() { "ELMA", "ARMUT", "MUZ" };
            ArrayList manavMeyveler = new ArrayList();
            ArrayList manavMeyveKilo = new ArrayList();
            ArrayList manavSebzeler = new ArrayList();
            ArrayList manavSebzeKilo = new ArrayList();
            ArrayList musteri = new ArrayList();
          


            while (true)
            {
                Console.WriteLine("**** HALE HOŞGELDİNİZ ****");
                Console.WriteLine("Meyve Mi Sebze Mi?(M/S) Çıkış Q");
                string halSecim = Console.ReadLine().ToUpper();

                if (halSecim == "M") 
                {
                    Console.WriteLine("1-Elma\n2-Armut\n3-Muz\nSeçiniz:");
                    try
                    {
                        #region 1.Yol
                        int meyve = Convert.ToInt32(Console.ReadLine());

                        if (meyve == 1)
                        {
                            UrunAl(manavMeyveler, "ELMA", manavMeyveKilo);
                        }
                        else if (meyve == 2)
                        {
                            UrunAl(manavMeyveler, "ARMUT", manavMeyveKilo);
                        }
                        else if (meyve == 3)
                        {
                            UrunAl(manavMeyveler, "MUZ", manavMeyveKilo);
                        }
                        else
                        {
                            Console.WriteLine("Yanlış Meyve Seçimi!!");
                            Thread.Sleep(2000);
                        }
                        #endregion


                        //string meyve = Console.ReadLine().ToUpper();
                        //if (halMeyveler.Contains(meyve))
                        //{
                        //    UrunAl(manavMeyveler, meyve, manavMeyveKilo);
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Olmayan Ürün Seçildi!!");
                        //}

                        Console.Clear();
                        Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap == "E")
                            continue;
                        else
                            break; 
                    }
                    catch (FormatException)
                    { Console.WriteLine("Lütfen Seçiminizi Rakam ile Giriniz."); }
                    catch (Exception)
                    {
                        Console.WriteLine("Bilinmeyen Hata!! Sistem Yöneticinizle Görüşünüz.");
                    }
                }
                else if (halSecim == "S")
                {

                    Console.WriteLine("1-Domates\n2-Patlıcan\n3-Biber\nSeçiniz:");
                    try
                    {
                        int sebze = Convert.ToInt32(Console.ReadLine());

                        if (sebze == 1)
                        {
                            UrunAl(manavSebzeler, "DOMATES", manavSebzeKilo);
                        }
                        else if (sebze == 2)
                        {
                            UrunAl(manavSebzeler, "PATLICAN", manavSebzeKilo);
                        }
                        else if (sebze == 3)
                        {
                            UrunAl(manavSebzeler, "BIBER", manavSebzeKilo);
                        }
                        else
                        {
                            Console.WriteLine("Yanlış Sebze Seçimi!!");
                            Thread.Sleep(2000);
                        }
                        Console.Clear();
                        Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap == "E")
                            continue;
                        else
                            break;
                    }
                    catch (FormatException)
                    { Console.WriteLine("Lütfen Seçiminizi Rakam ile Giriniz."); }
                    catch (Exception)
                    {
                        Console.WriteLine("Bilinmeyen Hata!! Sistem Yöneticinizle Görüşünüz.");
                    }
                }
                else if (halSecim == "Q") { Console.WriteLine("Yine Bekleriz.."); break; }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }
            }



            while (true)
            {
                Console.WriteLine("**** MANAVA HOŞGELDİNİZ ****");
                Console.WriteLine("Meyve Mi Sebze Mi?(M/S) Çıkış Q");
                string manavSecim = Console.ReadLine().ToUpper();

                if (manavSecim == "M")
                {
                    if (manavMeyveler.Count == 0)
                    {
                        Console.WriteLine("Meyveler Tükenmiştir.");
                        continue;
                    }
                    for (int i = 0; i < manavMeyveler.Count; i++)
                    {
                        Console.WriteLine($"{i}-{manavMeyveler[i]}");
                    }
                    try
                    {
                        Console.WriteLine("Ürün Seçiniz:");
                        string meyve = Console.ReadLine().ToUpper();

                        if (manavMeyveler.Contains(meyve))
                        {
                            Console.WriteLine("Kaç kilo?");
                            int kilo = Convert.ToInt32(Console.ReadLine());

                            int index = manavMeyveler.IndexOf(meyve);

                            int meyveKilo = (int)manavMeyveKilo[index];

                            if (meyveKilo >= kilo)
                            {
                                meyveKilo -= kilo;
                                musteri.Add(meyve);
                                if (meyveKilo == 0)
                                {
                                    manavMeyveler.RemoveAt(index);
                                    manavMeyveKilo.RemoveAt(index);
                                }
                                else
                                {
                                    manavMeyveKilo[index] = meyveKilo;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"İstenilen Kilo Mevcut Değildir. {meyve} - {manavMeyveKilo[index]} kilo mevcut");
                                Thread.Sleep(2000);
                            }

                        }
                        else
                        {
                            Console.WriteLine("Olmayan Ürün Seçildi!!");
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Lütfen Seçiminizi Rakam ile Giriniz.");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Bilinmeyen Hata!! Sistem Yöneticinizle Görüşünüz.");
                    }
                    Console.Clear();
                    Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap == "E")
                        continue;
                    else
                        break;
                }
                else if (manavSecim == "S")
                {
                    if (manavSebzeler.Count == 0)
                    {
                        Console.WriteLine("Sebzeler Tükenmiştir.");
                        continue;
                    }
                    for (int i = 0; i < manavSebzeler.Count; i++)
                    {
                        Console.WriteLine($"{i}-{manavSebzeler[i]}");
                    }
                    try
                    {
                        Console.WriteLine("Ürün Seçiniz:");
                        string sebze = Console.ReadLine().ToUpper();

                        if (manavSebzeler.Contains(sebze))
                        {
                            Console.WriteLine("Kaç kilo?");
                            int kilo = Convert.ToInt32(Console.ReadLine());

                            int index = manavSebzeler.IndexOf(sebze);

                            int sebzeKilo = (int)manavSebzeKilo[index];

                            if (sebzeKilo >= kilo)
                            {
                                sebzeKilo -= kilo;
                                musteri.Add(sebze);
                                if (sebzeKilo == 0)
                                {
                                    manavSebzeler.RemoveAt(index);
                                    manavSebzeKilo.RemoveAt(index);
                                }
                                else
                                {
                                    manavSebzeKilo[index] = sebzeKilo;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"İstenilen Kilo Mevcut Değildir. {sebze} - {manavSebzeKilo[index]} kilo mevcut");
                                Thread.Sleep(2000);
                            }


                        }
                        else
                        {
                            Console.WriteLine("Olmayan Ürün Seçildi!!");
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Lütfen Seçiminizi Rakam ile Giriniz.");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Bilinmeyen Hata!! Sistem Yöneticinizle Görüşünüz.");
                    }
                    Console.Clear();
                    Console.WriteLine("Başka bir arzunuz var mı?(E/H)");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap == "E")
                        continue;
                    else
                        break;
                }
                else if (manavSecim == "Q") { Console.WriteLine("Yine Bekleriz."); break; }
                else
                {
                    Console.WriteLine("Hatalı Seçim.");
                }

            }


            foreach (string item in musteri)
            {
                Console.WriteLine(item);
            }
        }

        static void UrunAl(ArrayList list, string urun, ArrayList kiloList)
        {
            if (list.Contains(urun)==false)
            {
                list.Add(urun);
                Console.WriteLine("Kaç Kilo?");
                int kilo = Convert.ToInt32(Console.ReadLine());
                kiloList.Add(kilo);
            }
            else
            {
                Console.WriteLine("Kaç Kilo?");
                int kilo = Convert.ToInt32(Console.ReadLine());
                int index = list.IndexOf(urun);
                int eskiKilo = (int)kiloList[index];
                kiloList[index] = eskiKilo + kilo;
            }
          

            

        }
    }
}
