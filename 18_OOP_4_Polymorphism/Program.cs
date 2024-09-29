namespace _18_OOP_4_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             POLYMORPHISM NEDİR? 

             Çokbiçimlilik (Polymorphism) bir nesnenin farklı amaçlar için de kullanılabileceği anlamına gelir ve statik ve dinamik olmak üzere ikiye ayrılır.

                * Statik çokbiçimlilik; metot ve operatörlerin aşırı yüklenmesi (overload) olarak belirtilir.
                * Dinamik çokbiçimlilik; özet sınıflardan miras alma yoluyla işlemlerin gerçekleştirilmesi işlemine verilen isimdir.

             Statik çokbiçimlilik türünden, metotların aşırı yüklenmesine yönelik bir çalışma yapacağız.


            //StatikPolimorphism sp = new StatikPolimorphism();

            //sp.Yaz(30, "altan");

            //Console.ReadLine();

            Dinamik çokbiçimlilik türünden, metodu override etmeliyiz.

            VIRTUAL() METODU

            *Temel sınıfa ait bir metodun bazen türemiş sınıfta farklı bir şekilde kullanılması gerekebilir. Bu durumda temel sınıfın söz konusu metodu türemiş sınıfın değiştirip kullanabileceği yönünde izin vermesi gerekir. Bu izin, metodun temel sınıfta “virtual” olarak tanımlanması sonucu verilmektedir. Diğer bir ifadeyle temel sınıfta “virtual” olarak tanımlanmış bir metodun türemiş sınıfta yeniden yazılabileceği belirtilmiş olunuyor.


            METODU OVERRIDE ETMEK, OVERRIDE NEDİR?METOTUN EZİLMESİ

            *Temel sınıfta “virtual” tanımlanmış bir metodun türemiş sınıfta yeniden yazılması için (geçersiz kılma) “override” sözcüğü kullanılır. 
             *Temel sınıfta “virtual” tanımlanmamış ya da “static” tanımlanmış olan üyeler (metot, özellik, dizinleyici ya da olay) türemiş sınıfta yeniden yazılamaz (Geçersiz kılınamaz.).



         

            Ayrıca temel sınıfta “virtual”, “abstract” ya da “override” olarak tanımlanmış
            metotlar türemiş sınıfta geçersiz kılınabilir.
            Bir diğer önemli nokta da “override” metotlar “new”, “static” ya da “virtual”
            sözcükleri ile tanımlanamaz.

            Son olarak “virtual” metodun erişim belirteci “override” sırasında değiştirilemez.
            Yani temel sınıfta metot “public” ise türemiş sınıfta da “public”, “protected” ise “protected” kalmalıdır.
            */

            // *** STATIC POLYMORPHISM ***
            //Matematik m = new Matematik();
            //m.Topla();


            Kopek kopek = new Kopek();
            kopek.Konus();

            Kedi kedi = new Kedi();
            kedi.Konus();

            Balina balina = new Balina();
            balina.Konus();


            Kurt kurt = new Kurt();
            kurt.Konus();

        }
    }

    // *** STATIC POLYMORPHISM ***
    class Matematik
    {
        public void Topla()
        {
            Console.WriteLine("1.Sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(s1+s2);
        }

        public void Topla(int s1,int s2)
        {
            Console.WriteLine(s1+s2);
        }

        public void Topla(double s1, int s2)
        {
            Console.WriteLine(s1 + s2);
        }

        public void Topla(int s1, double s2)
        {
            Console.WriteLine(s1 + s2);
        }


        public void Topla(int s1, int s2,int s3)
        {
            Console.WriteLine(s1 + s2 + s3);
        }
    }
}
