namespace _11_OtomatMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 

           Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
          Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, aksi durumda para ekle seçeneği ile tekrar para girmesi sağlanacak.

           // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek
           */

            #region Bahir
            /*
            string[] products = { "Meyve Suyu", "Su", "Biskuvi", "Kek" };
            int[] prices = { 15, 10, 7, 8 };
            while (true)
            {
                int choice = 0;
                Console.Clear();
                for (int i = 0; i < products.Length; i++) // menü yazdırma
                {
                    Console.Write($"{i + 1}.");
                    Console.Write(products[i]);
                    Console.Write($" {prices[i]} TL\n");
                }
                Console.WriteLine("Seçmek İstediğiniz Ürün Numarasını Giriniz:");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == -1) // admin paneline erişim
                {
                    Console.WriteLine("Yönetici Paneline Erişmek için Şifre Giriniz:");
                    string password = "ab18";
                    int attemt = 3;
                    while (attemt > 0)
                    {
                        string entry = Console.ReadLine();
                        if (entry == password)//giriş başarılı
                        {
                            attemt = 3;
                            Console.WriteLine("Giriş Başarılı");
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Şifre Yanlış!!\nTekrar Deneyiniz.");
                            attemt--;
                            if (attemt == 0)
                            {
                                Console.WriteLine("3 kez yanlış şifre girdiniz. Cihaz kitlendi");
                                Thread.Sleep(6000);
                                break;
                            }
                        }
                    }
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Menüdeki Ürünler");
                        for (int i = 0; i < products.Length; i++) // menü yazdırma
                        {
                            Console.Write($"{i + 1}.");
                            Console.Write(products[i]);
                            Console.Write($" {prices[i]} TL\n");
                        }
                        Console.WriteLine("\nÜrün Eklemek için 1\nÜrün Silmek için 2\nFiyat Güncellemek için 3\nAnamenüye Dönmek için 9 Tuşlayınız.");
                        string choiceAdmin = Console.ReadLine();
                        if (choiceAdmin == "1") //ürün ekleme
                        {
                            int productPrice = 0;
                            Console.WriteLine("Ürün Adı:");
                            string productName = Console.ReadLine();
                            Console.WriteLine("Ürün Fiyatı");
                            try
                            {
                                productPrice = Convert.ToInt32(Console.ReadLine());
                                if (productPrice <= 0)
                                {
                                    Console.WriteLine("Ürün Fiyatı Sıfır veya Sıfırdan Küçük Olamaz!");
                                    Thread.Sleep(2000);
                                    continue;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Hatalı Giriş!");
                                Thread.Sleep(2000);
                                continue;
                            }
                            Console.WriteLine(products.Length);
                            Array.Resize(ref products, products.Length + 1);
                            Array.Resize(ref prices, prices.Length + 1);
                            products[products.Length - 1] = productName;
                            prices[prices.Length - 1] = productPrice;
                        }
                        else if (choiceAdmin == "2") // ürün silme
                        {
                            string[] productsCopy = new string[products.Length];
                            int[] pricesCopy = new int[prices.Length];
                            Console.WriteLine("Ürün Adı:");
                            string productName = Console.ReadLine();
                            int index = Array.IndexOf(products, productName);
                            Array.Copy(products, productsCopy, products.Length);
                            Array.Copy(prices, pricesCopy, prices.Length);
                            for (int i = 0; i < products.Length - index - 1; i++)
                            {
                                Console.WriteLine("dizi uzunluğu - index - 1" + (products.Length - index - 1) + " index" + (index + 1));

                                products[index + i] = productsCopy[index + i + 1];
                                prices[index + i] = pricesCopy[index + i + 1];

                            }
                            Array.Clear(prices, prices.Length - 1, 1);
                            Array.Clear(products, products.Length - 1, 1);
                            Array.Resize(ref prices, prices.Length - 1);
                            Array.Resize(ref products, products.Length - 1);
                        }
                        else if (choiceAdmin == "3") //fiyat güncelleme
                        {
                            int productPrice = 0;
                            Console.WriteLine("Ürün Adı:");
                            string productName = Console.ReadLine();
                            Console.WriteLine("Yeni Fiyatı");
                            try
                            {
                                productPrice = Convert.ToInt32(Console.ReadLine());
                                if (productPrice <= 0)
                                {
                                    Console.WriteLine("Ürün Fiyatı Sıfır veya Sıfırdan Küçük Olamaz!");
                                    Thread.Sleep(2000);
                                    continue;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Hatalı Giriş!");
                                Thread.Sleep(2000);
                                continue;
                            }
                            int index = Array.IndexOf(products, productName);
                            if (index == -1)
                            {
                                Console.WriteLine("Ürün Bulunamadı!");
                                Thread.Sleep(2000);
                                continue;
                            }
                            prices[index] = productPrice;
                        }
                        else if (choiceAdmin == "9")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz Değer");

                        }
                    }
                }
                else
                {
                    int paymentMethod = 0;
                    try
                    {
                        Console.WriteLine($"{products[choice - 1]} fiyatı {prices[choice - 1]}'dır\n Kart ile ödemek için 1, Nakit yüklemek için 2 tuşlayınız.");
                        paymentMethod = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Geçersiz Seçim!");
                        continue;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Geçersiz Değer");
                        continue;
                    }

                    if (paymentMethod == 1)
                    {
                        Console.WriteLine("Kartınızı Okutunuz!");
                        Thread.Sleep(5000);
                        Console.WriteLine("Ödeme Başarılı!");
                    }
                    else if (paymentMethod == 2)
                    {
                        int money = 0;
                        Console.WriteLine("Lütfen para girişi yapınız.");
                        while (true)
                        {

                            Console.WriteLine("Yatırdığınız Miktar:");
                            money += Convert.ToInt32(Console.ReadLine());
                            if (money < prices[choice - 1])
                            {
                                Console.WriteLine($"Eksik Bakiye!!\n {prices[choice - 1] - money} TL daha eklemeniz gerekmektedir.");
                            }
                            else if (money > prices[choice - 1])
                            {
                                Console.WriteLine("Ödeme Başarılı!!\n Para üstünü almayı unutmayınız.");
                                Thread.Sleep(3000);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ödeme Başarılı!!");
                                Thread.Sleep(3000);
                                break;
                            }
                        }

                    }
                    else { Console.WriteLine("Geçersiz Seçim!"); }
                }
            }*/
            #endregion
            bool admin = false;
            string pass = "-1";
            string[] products = {"Kola","Fanta","Bisküvi","Çikolata" };
            double[] prices = { 20, 20, 30, 15 };
            double balance = 0;
            while (true)
            {    
                try
                {
                    for (int i = 0; i < products.Length; i++)
                    {
                        Console.WriteLine($"{i}-{products[i]}:{prices[i]}");
                    }
                    Console.WriteLine("Ürün Numarası Seçiniz:");
                    int productNo = Convert.ToInt32(Console.ReadLine());

                    if (productNo == -1)
                    {
                        admin = true;
                        Console.Clear();
                        break;
                    }

                    Console.WriteLine("Para Girişi Yapınız:");
                     balance= Convert.ToDouble(Console.ReadLine());

                    if (balance >= prices[productNo])
                    {
                        Console.WriteLine("Ürünü alınız.\nAfiyet Olsun.\nPara Üstü:" + (balance - prices[productNo]));
                        Thread.Sleep(2000);
                        balance = 0;
                        Console.Clear();
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("Yetersiz Bakiye!");
                            Console.WriteLine("Para Ekle-1\nPara İade-2");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim == 1)
                            {
                                Console.WriteLine("Para Ekle:");
                                balance += Convert.ToDouble(Console.ReadLine());

                                if (balance >= prices[productNo])
                                {
                                    Console.WriteLine("Ürünü alınız.\nAfiyet Olsun.\nPara Üstü:" + (balance - prices[productNo]));
                                    Thread.Sleep(2000);
                                    balance = 0;
                                    Console.Clear();
                                    break;
                                }                              

                            }
                            else if (secim == 2)
                            {
                                Console.WriteLine("Para iade edildi.");
                                balance = 0;
                                Console.Clear();
                                break;
                            }
                            else { Console.WriteLine("Hatalı tuşlama!"); }
                        }
                       
                    }



                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Lütfen rakam tuşlayınız!");

                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Lütfen ekrandaki sayılardan birini tuşlayınız!");
                }
            }


            if (admin)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("******** ADMİN PANEL *********");
                    Console.WriteLine("1-Ürün Ekle\n2-Ürün Güncelle\n3-Ürün Sil\n4-Ürün Listesi\n5-Çıkış\nSeçiminiz:");
                    int secim = Convert.ToInt32(Console.ReadLine());

                    if (secim == 1)
                    {
                        Console.WriteLine("Ürün Adı:");
                        string urunAd = Console.ReadLine();
                        Console.WriteLine("Ürün Fiyatı:");
                        double fiyat = Convert.ToDouble(Console.ReadLine());

                        Array.Resize(ref products, products.Length + 1);
                        Array.Resize(ref prices, prices.Length + 1);

                        products[products.Length - 1] = urunAd;
                        prices[prices.Length - 1] = fiyat;                       
                    }

                    else if (secim == 2)
                    {
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine($"{i}-{products[i]}:{prices[i]}");
                        }
                        Console.WriteLine("Güncellenecek ürün numarasi:");
                        int guncellenecekNo = Convert.ToInt32(Console.ReadLine());

                        if (guncellenecekNo >= products.Length)
                        {
                            Console.WriteLine("Yanlış ürün seçimi");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine("Ürün Adı:");
                            string urunAd = Console.ReadLine();
                            Console.WriteLine("Ürün Fiyatı:");
                            double fiyat = Convert.ToDouble(Console.ReadLine());

                            products[guncellenecekNo] = urunAd;
                            prices[guncellenecekNo] = fiyat;
                        }
                    }
                    else if (secim == 3) 
                    {
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine($"{i}-{products[i]}:{prices[i]}");
                        }
                        Console.WriteLine("Silienecek ürün numarasi:");
                        int silienecekNo = Convert.ToInt32(Console.ReadLine());

                        if (silienecekNo >= products.Length)
                        {
                            Console.WriteLine("Yanlış ürün seçimi");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Array.Clear(products, silienecekNo, 1);
                            Array.Clear(prices, silienecekNo, 1);
                        }

                    }
                    else if (secim == 4)
                    {
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine($"{i}-{products[i]}:{prices[i]}");
                        }
                        Thread.Sleep(2000);
                    }
                    else if (secim == 5)
                    {
                        break;
                    }

                }



            }
        }
    }
}
