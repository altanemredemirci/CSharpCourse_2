namespace _18_OOP_4_Polymorphism_1
{
    internal class Program
    {   /*AŞAĞIDAKİ örnekte Daire, Kure ve Silindir sınıfları Sekil temel sınıfından türetilmişlerdir.
            Hepsinde de Sekil sınıfında “virtual” tanımlanan alan metodu yeniden yazılmıştır. Bu
            yeniden yazma (geçersiz kılma) esnasında “override” sözcüğünün kullanıldığına dikkat
            ediniz. Ayrıca burada dikkat edilmesi gereken nokta “virtual” ve “override” metotların imzalarının (dönüş türleri ile birlikte parametrelerinin tür ve sayıları) aynı olması gerekliliğidir.*/
        static void Main(string[] args)
        {
            //Sekil sekil = new Sekil(12,13);
            //Console.WriteLine(sekil.Alan());


            Daire daire = new Daire(5);
            Console.WriteLine(daire.Alan());
        }
    }
    public class Sekil
    {
        public const double PI = Math.PI;

        protected double x; //Sadece Şekil sınıfını miras alan sınıflar kendi içinde x ve y özelliklerine erişebilir.
        protected double y;

        public Sekil(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Alan()
        {
            return x * y;
        }
    }

    public class Daire : Sekil
    {
        public Daire(double r):base(r,0)
        {
            
        }

        public override double Alan()
        {
            return PI * x * x;
        }
    }

    public class Kure : Sekil
    {
        public Kure(double r) : base(r, 0)
        {

        }

        public override double Alan()
        {
            return 4 * PI * x * x;
        }
    }

    public class DikDortgen : Sekil
    {
        public DikDortgen(double a, double b) : base(a, b)
        {

        }
    }
}
