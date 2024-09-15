namespace _18_OOP_4_Inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KOPEK(ad,cins,boy,kilo,renk) VE KEDI(ad,cins,boy,kilo,cinsiyet) 

            Kopek kopek = new Kopek();
            kopek.ad = "Rex";
            kopek.kilo = 45;
            kopek.renk = "Siyah";
            kopek.boy = 50;
            kopek.cins = "Doberman";

            kopek.OzellikleriYaz();
        }
    }
    class Hayvan
    {
        public string ad { get; set; }
        public string cins { get; set; }
        public int boy { get; set; }
        public int kilo { get; set; }

        protected void OzellikleriYaz()
        {
            Console.WriteLine(ad+" "+cins+" "+boy+" "+kilo);
        }

    }
    class Kopek : Hayvan
    {
        public string renk { get; set; }

        //NameHiding
        //public new void OzellikleriYaz()
        //{
        //    Console.WriteLine(ad + " " + cins + " " + boy + " " + kilo+" "+renk);
        //}

        public new void OzellikleriYaz()
        {
            base.OzellikleriYaz();
            Console.WriteLine(renk);
        }
    }
    class Kedi : Hayvan
    {
        public string cinsiyet { get; set; }

    }
}
