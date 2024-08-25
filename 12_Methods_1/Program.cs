namespace _12_Methods_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Static: Farklı classta tanımlanan metodun class adı üzerinden direk erişilerek çağrılmasını sağlar.Static bir class içinde static methodlar kullanılır.



                DataAccessModifier:Tanımlanan yapıların erişilebilirliğini tanımlar.
                    *public: Solution altındaki bütün projelerin ve proje altındaki tanımların hepsinin erişimine açık demektir.
                    *internal: Kendi tanımlı olduğu proje altında erişime açık demektir.
                    *private: Kendi tanımlı olduğu class alrtında erişime açık demektir. Bir erişşim belirteci verilmezse yapılar default PRIVATE tanımını alır.
                    *protected: Miras alınan classlar altında erişime açık demektir.
          */


            //*** Matematik classı içindeki Yaz methoduna erişim

            //Matematik.Yaz();

            //Matematik matematik = new Matematik(); //Instance(Örneklem):Classı temsil eden bir nesne oluşturma işlemi.
            //matematik.NonStaticYaz();

            //DortIslem.Toplama();

            #region DEĞER DÖNDÜRMEYEN METOTLAR - void

            /*
            erişimbelirteci (static) void metotAdı(varsa parametreler)
            {
                metodun yapacağı işlem komutları yazılır.
            }


            */
            #endregion

            //Toplama();

            //Matematik.Yaz();

            //Matematik matematik = new Matematik(); //Instance(Örneklem):Classı temsil eden bir nesne oluşturma işlemi.
            //matematik.NonStaticYaz();


            //DortIslem.Cikarma();


            //DortIslem.Cikarma2(12, 4);


            //Console.WriteLine("1.sayıyı giriniz:");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz:");
            //int s2 = Convert.ToInt32(Console.ReadLine());
            //DortIslem.Cikarma2(s1, s2);


            #region Kullanıcıdan 2 sayı bir işlem alınız ve alınan sayılara istenilen işlemi uygulayarak ekran yazdıran metot
            //Console.WriteLine("1.sayıyı giriniz:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bir işlem giriniz(+,-,*,/):");
            //char islem = Convert.ToChar(Console.ReadLine());

            //if (islem == '+') {DortIslem.Toplama(sayi1, sayi2); }
            //else if (islem == '-') { DortIslem.Cikarma(sayi1, sayi2); }
            //else if (islem == '*') { DortIslem.Carpma(sayi1, sayi2); }
            //else if (islem == '/') { DortIslem.Bolme(sayi1, sayi2); }
            //else { Console.WriteLine("Hatalı İşlem Seçimi"); }


            //DortIslem.Islemler();

            #endregion

            #region  kullanıcıdan alınacak bir ürün fiyatın KDV uygulayarak yeni fiyatı kullanıcıya gösteriniz KDVUygula=>%20


            Console.WriteLine("Fiyat giriniz");
            double urunFiyat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kdv gir:");
            double kdv = Convert.ToDouble(Console.ReadLine());
            DortIslem.KDVUygula(urunFiyat, kdv);

            #endregion

        }

        //static void Yaz()
        //{
        //    Console.WriteLine("Data Access Modifier almayan yapılar default PRIVATE tanımlıdır.");
        //}

        static void Toplama()
        {
            Console.WriteLine(11+12);
        }

    }

    class Matematik
    {
        internal static void Yaz()
        {
            Console.WriteLine("Hello World");
        }

        internal void NonStaticYaz()
        {
            Console.WriteLine("NonStatic tanımlar class üzerinden nesne oluşturarak erişilir.");
        }
    }
}
