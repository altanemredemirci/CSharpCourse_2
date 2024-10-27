namespace _19_Generic_Mimari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kategori kategori = new Kategori();

            Urun urun = new Urun();
            
            //urun.Create(urun);


            //Repository<Kategori> repository = new Repository<Kategori>();
            Repository<Urun> repository = new Repository<Urun>();
        }
    }
}
