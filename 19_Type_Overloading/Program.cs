namespace _19_Type_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun<double> urun = new Urun<double>(15,150.5);
            //urun.Fiyat = 15;
            //urun.Kdv = 500.5;

            //int ve double tipi ile overload edilmiş versiyonu kullanan bir Urun nesnesi
            Urun<int, double> urun2 = new Urun<int, double>(1000, 0.18);

            //double ve string tipi ile overload edilmiş versiyonu kullanan bir Urun nesnesi 
            Urun<double, string> urun3 = new Urun<double, string>(200.01, "Yüzde On Sekiz Kdv");

        }
    }

    class Urun<T>
    {
        public T Fiyat { get; set; }
        public T Kdv { get; set; }
        public string Ad { get; set; }

        public Urun(T fiyat, T kdv)
        {
            Fiyat = fiyat;
            Kdv = kdv;
        }

    }

    class Urun<T,K>
    {
        public K Fiyat { get; set; }
        public T Kdv { get; set; }
        public string Ad { get; set; }

        public Urun( T kdv,K fiyat)
        {
            Fiyat = fiyat;
            Kdv = kdv;
        }

    }
}
