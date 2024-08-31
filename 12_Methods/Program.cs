
using _12_Methods_1;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace _12_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            METHODS - FONKSİYONLAR
           
            Metotlar: Yazılımcılar tarafından geliştirilen ve diğer yazılımcıların kullanımına sunulan hazır kod yapılarıdır. Metoda bir isim verilir ve o isim altında bir iş yapar kod bloğu yazılır ve yazılımcı o işi yapmak için kod bloğunu yazmak yerine metodu ismini yazarak çağırır.Çağrılan metot kendi içindeki kod bloğunu çalıştırır. Bu sayede yazılımcı tanımlı işin kodunu defalarca yazmaktan kurtulur.

            Metotlar ve Fonksiyonlar () ile tanımlanır.
            Metotlar iç içe TANIMLANAMAZLAR.
            Metotlar çağrılmadığı sürece bir işlem yapmazlar.
            Metotlar UNIQUE(benzersiz) olmalıdır. Aynı isme sahip metotların, metot imzaları farklı olmalıdır.(parametre sayısı,parametre veri tipi)

            Fonksiyonlar ise yazılımcının kendisinin oluşturduğu metotlardır.

            Metotlar 2'ye ayrılır.

            *Değer Döndüren(parametreli/parametresiz)
            *Değer Döndürmeyen(parametreli/parametresiz)


            Parametre: metot parantezleri içerisine yazılan ve metodu kullanırken gönderilecek verilerdir. 
            
                
             */

            //Yaz();
            //YazIsim("Altan Emre");

            //Metot tanımlanırken verilen parametre ismi ile metodu çağırırken gönderilen parametre ismi AYNI OLMAK ZORUNDA DEĞİLDİR.
            //string isim = "Altan Emre";
            ////YazIsim(isim);

            //int sayi1 = 12;
            //double sayi2 = 15.5;

            //int sayi3 = (int)sayi2;
            //Console.WriteLine(sayi3);


            //Topla(sayi1, sayi2);

            DortIslem.Toplama();
            
        }

        static void Yaz()
        {
            Console.WriteLine("Altan Emre");
        }

        static void YazIsim(string ad)
        {
            Console.WriteLine(ad);
        }

        //Metot çağrılırken tanımında olan parametre sayısını ve parametre veritipini aynı sıra ile karşılamalıdır.
        static void Topla(int s1,double s2)
        {           
            Console.WriteLine(s1+s2);
        }
    }

  
}
