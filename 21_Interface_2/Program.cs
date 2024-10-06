namespace _21_Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    interface ICalisan
    {
        int id { get; set; }
        string departman { get; set; }
        ulong toplamCalismaSaati { get; set; }
    }


    interface IKisi
    {
        string adSoyad { get; set; }
        string adres { get; set; }
        double maas { get; set; }
    }

    class Yonetici : ICalisan, IKisi
    {
        public string adSoyad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string adres { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double maas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string departman { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ulong toplamCalismaSaati { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Isci : ICalisan, IKisi
    {
        public string adSoyad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string adres { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double maas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string departman { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ulong toplamCalismaSaati { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Robot : ICalisan
    {
        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string departman { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ulong toplamCalismaSaati { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
