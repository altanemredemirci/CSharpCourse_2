namespace _12_Methods_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OVERLOAD METHOD - AŞIRI YÜKLENMİŞ

            // Bir metodun aynı isimle birden fazla kez tanımlanmış olmasıdır.
            // Methodlar aynı isimle tanımlandıklarında METOT IMZALARININ FARKLI OLMASI GEREKLİDİR.
            // Metot İmzası: * Parametre sayısı * Parametre veritipi


            Matematik.Topla();
            Matematik.Topla(11,12);
            Matematik.Topla();

        }
    }
}
