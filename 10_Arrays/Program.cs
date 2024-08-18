namespace _10_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                 *******  ARRAYS - DİZİLER *******
                 *Değişkenlerin aksine diziler Index adı verilen numaralandırma yöntemi ile birden fazla değeri tutabilen koleksiyon türüdür.
                 *Index numaraları 0 dan başlar ve 1'er 1'er artar.
                 *Arrays kendileri aitm metotlara sahiptirler.
                 *Array [] ile tanımlanır.
                 *Tek veri tipinde verilen uzunluk kadar elaman tutar.

             //DİZİ TANIMLAMA

            //veriTipi[] diziAdi = new veriTipi[uzunluk]

            //Boş Dizi Tanımı
            string[] isimler = new string[5];

            //Dolu Dizi Tanımı
            string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Koray" };

             */
            //int[] sayilar = new int[5];

            //sayilar[0] = 11;
            //sayilar[1] = 12;
            //sayilar[2] = 13;
            //sayilar[3] = 14;
            //sayilar[4] = 15;
            //sayilar[5] = 16;//HATA:System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'


            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Koray" };


            //Console.WriteLine(sayilar[2]);
            //Console.WriteLine(adlar[3]);


            //Dizi Elemanlarını Ekrana Yazdırma

            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Koray" };

            //int i = 0;
            //while (i < adlar.Length) //i=0,1,2,3,4
            //{
            //    Console.WriteLine(adlar[i]);
            //    i++;
            //}

            //Console.WriteLine("*************");
            //for (int j = 0; j < adlar.Length; j++)
            //{
            //    Console.WriteLine(adlar[j]);
            //}

            //Console.WriteLine("*************");

            ////FOREACH: Koleksiyon yapılarını ekrana yazdırır.

            //foreach (string ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}


            #region Kullanıcıya kaç personeli olduğunu sorunuz. Verilen cevapdan sonra her personelin adını sorup bir diziye ekleyiniz. Dizi tamamlandığında personel isimlerini ekrana yazdırınız.

            //Console.WriteLine("Personel Sayınız:");
            //int personelSayisi = Convert.ToInt32(Console.ReadLine());

            //string[] personeller = new string[personelSayisi];

            ////Dizi doldurma alanı
            //for (int i = 0; i < personeller.Length; i++)
            //{
            //    Console.WriteLine("Personel Adı:");
            //    string ad = Console.ReadLine();

            //    personeller[i] = ad;
            //}

            ////Diziyi ekrana yazdırma alanı
            //foreach (string personel in personeller)
            //{
            //    Console.WriteLine(personel);
            //}
            #endregion

            #region Object Type
            //object[] nesneler = new object[5];

            //nesneler[0] = "Yiğit";
            //nesneler[1] =  12;

            //foreach (var item in nesneler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region ARRAY SINIFININ METOTLARI

            #region Clear()
            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Koray" };

            ////Array.Clear(adlar);
            //Array.Clear(adlar,1,2);

            //foreach (string ad in adlar)
            //{
            //    Console.WriteLine(ad);
            //}

            #endregion

            #region Copy()

            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Koray" };

            //string[] adlar2 = new string[10];


            ////Array.Copy(adlar, adlar2, 3);

            ////Array.Copy(adlar, 1, adlar2, 2, 3);


            //foreach (string ad in adlar2)
            //{
            //    Console.WriteLine(ad);
            //}


            #endregion

            #region IndexOf()
            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Arhan", "Koray" };

            //int index = Array.IndexOf(adlar, "Ercan");

            //Console.WriteLine(index);
            //Console.WriteLine(adlar[index]);

            //string[] adlar = { "Mehmet", "Ercan", "Bahir","Ercan", "Arhan","Ercan", "Koray","Ercan" };
            //int index = Array.IndexOf(adlar, "Ercan");
            //int index2 = Array.IndexOf(adlar, "Ercan",index+1);

            //Console.WriteLine(index);
            //Console.WriteLine(index2);


            #region Yukarıdaki dizi elemanlarından Ercan olanların indexlerini ekrana yazdıran döngü 
            //string[] adlar = { "Mehmet", "Ercan", "Bahir", "Ercan", "Arhan", "Ercan", "Koray", "Ercan" };

            //BAHİR
            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    int index = Array.IndexOf(adlar, "Ercan", i);
            //    //if (index == i)
            //    //{
            //    //    Console.WriteLine(index);
            //    //}
            //}


            //YİĞİT
            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    int index = Array.IndexOf(adlar, "Ercan", i);    
            //    i = index;
            //    Console.WriteLine(index);

            //}


            //int i = 0;
            //while (i < adlar.Length)
            //{
            //    i = Array.IndexOf(adlar, "Ercan", i);

            //    Console.WriteLine(i);
            //    i++;
            //}


            #endregion



            #endregion

            #region LastIndexOf()       
            //string[] adlar = { "Mehmet","Altan", "Ercan", "Bahir", "Ercan", "Arhan", "Ercan", "Koray", "Ercan" };

            //Console.WriteLine(Array.LastIndexOf(adlar,"Ercan"));
            //Console.WriteLine(Array.LastIndexOf(adlar,"Ercan",4,2));
            //Console.WriteLine(Array.LastIndexOf(adlar,"Ercan",1,1));


            #endregion

            #region Sort()

            //A->Z 0->9 sıralama yapar

            //int[] sayilar = { 11, 2, 33, 43, 23, 65, 99, 34 };

            //Array.Sort(sayilar);

            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}


            //string[] sehirler = { "Zonguldak", "Adana", "Mersin", "Çanakkale", "Adıyaman", "İzmir", "İstanbul", "Şırnak" };
            //Array.Sort(sehirler);

            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Reverse

            //string[] sehirler = { "Zonguldak", "Adana", "Mersin", "Çanakkale", "Adıyaman", "İzmir", "İstanbul", "Şırnak" };

            //Array.Sort(sehirler);
            //Array.Reverse(sehirler);

            //foreach (var sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}


            //int[] sayilar = { 11, 2, 33,11, 43, 23, 65, 99, 34 };
            //Array.Sort(sayilar);
            //Array.Reverse(sayilar);

            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}



            #endregion


            #region Resize

            //int[] sayilar = new int[5];
            //sayilar[0] = 1;
            //sayilar[1] = 2;
            //sayilar[2] = 3;
            //sayilar[3] = 4;
            //sayilar[4] = 5;


            //Array.Resize(ref sayilar, 8);

            //sayilar[5] = 6;


            //out:Daha önce tanımlanmış ama değer atanmamış değişkeni işleme sokmamızı sağlar.
            //ref: Daha önce tanımlanmış değişkeni revize etmeyi sağlar.


            //string sayi = "50";
            //int s;
            //int.TryParse(sayi, out s);

            #endregion



            //string[] sehirler = { "Zonguldak", "Adana", "Mersin", "Çanakkale", "Adıyaman", "İzmir", "İstanbul", "Şırnak" };

            //Console.WriteLine(sehirler[sehirler.Length-1]);
            #endregion

            #region Kullanıcıdan alınan bir kelimenin harflerini alt alta ekrana yazdırınız.

            //Console.WriteLine("Kelime:");
            //string kelime = Console.ReadLine();

            //foreach (char harf in kelime)
            //{
            //    Console.WriteLine(harf);
            //}


            //for (int i = 0; i < kelime.Length; i++)
            //{
            //    Console.WriteLine(kelime[i]);
            //}



            #endregion

            #region Bir dizinin eleman sayısı 10 ile 20 arasında olacak şekilde sistem tarafında otomatik atılmaktadır.
            //Bu dizinin elemanlarını da sistem 0,100 arasında otomatik atmaktadır.
            //Otomatik oluşturulan bu dizinin eleman sayısını ve elemanlarını kullanıcıya gösteriniz
            //Aynı sayılar tekrar atanmayacak
            //Dizideki en büyük ve en küçük sayılar sort() kullanılmadan bulup ekrana yazdırılacak 

            #endregion

        }
    }
}
