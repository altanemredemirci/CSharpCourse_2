namespace _12_Methods_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen değerler arasında rastgele sayı üreten  ve bu değerleri 10 elemanlı bir diziye atayan SayiUret() isimli bir metot yazın.
            //Bu dizinin elemanlarını yazan DiziYazdır() isimli bir metot daha yazarak elemanları listeleyin.
            //Daha sonra bu dizi içerisinde EnBuyukDeger() adında bir metot ile dizinin en büyük değerini bulan,
            //en küçük değerinin bulan EnKucukDeger() adından başka bir metot daha yazınız.
            //EnBuyukDeger ve EnKucukDeger metotlarında dönen değerleri ekranda gösteren programı yazınız
            //kullanıcının bütün hataları kontrol altına alınmalı
            CreateArrayItems(10);

        }
        static void MinMax(int[] ints)
        {
            int minimumValue = MinimumValue(ints);
            int maximumValue = MaximumValue(ints);
            Console.WriteLine($"\nDizideki;\nEn Büyük Değer:{maximumValue}\nEn Küçük Değer:{minimumValue} ");
        }
        static int MinimumValue(int[] ints)
        {
            Array.Sort(ints);

            int minimumValue = ints[0];
            return minimumValue;
        }
        static int MaximumValue(int[] ints)
        {
            Array.Sort(ints);

            int maximumValue = ints[ints.Length - 1];
            return maximumValue;
        }
        static void Write(int[] ints)
        {
            Console.WriteLine();
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i]);
                if (i < ints.Length - 1)
                {
                    Console.Write(",");
                }
            }
        }
        static void CreateArrayItems(int arrayLength)
        {
            int startPoint = 0;
            int endPoint = 5;
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Başlangıç değerini giriniz ");
                    startPoint = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Bitiş değerini giriniz:\n(Benzersiz üyelerden oluşan bir dizi için başlangıç değerinden en az 10 fazla olan bir değer girmelisiniz.\nGirebileceğiniz minimum değer {startPoint + 10}'tir.)");
                    endPoint = Convert.ToInt32(Console.ReadLine());
                    if (startPoint > endPoint)
                    {
                        Console.WriteLine("Başlangıç Değeri Bitiş Değerinden Büyük Olamaz!!");
                        Thread.Sleep(1000);
                        continue;
                    }
                    else if (endPoint == startPoint)
                    {
                        Console.WriteLine("Başlangıç Değeri Bitiş Değerime Eşit Olamaz!!");
                        Thread.Sleep(1000);
                        continue;
                    }
                    else if ((endPoint - startPoint) < arrayLength)
                    {
                        Console.WriteLine("Benzersiz üyelerden oluşan bir dizi oluşturmak için aralık en az 10 olmalıdır. Aralık güncellemek için 1,\nDevam etmek için 2'yi tuşlayınız. ");
                        string choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            continue;
                        }
                        else if (choice == "2")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçerli Bir Değer Giriniz.");
                            Thread.Sleep(1000);
                            continue;
                        }
                    }
                    break;
                }
                catch (Exception FormatException)
                {
                    Console.WriteLine("Geçersiz Değer");
                    Thread.Sleep(1000);
                }
            }

            Random r = new Random(); //Instance - Örneklem

            int[] ints = new int[arrayLength];
                       
            int i = 0;
           
                while (i < ints.Length) //i<10
                {
                    int sayi = r.Next(startPoint, endPoint);

                    bool varMi = false;

                    foreach (var item in ints)
                    {
                        if (item == sayi)
                        {
                            varMi = true;
                        if (ints.Length > (endPoint - startPoint))
                        {
                            ints[i] = sayi;
                            i++;
                        }
                        break;
                        }
                    }
                    if (varMi == false)
                    {
                        ints[i] = sayi;
                        i++;
                    }

                }
               
            Console.Clear();
            Write(ints);
            MinMax(ints);
        }
    }
}
