namespace _12_Methods_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sonuc =Yazdir("Altan Emre");
            Console.WriteLine(sonuc);
        }

        //Default Parametre Değeri
        static string Yazdir(string ad,string soyad = "Demirci") //soyad parametresi gönderilmezse default demirci al.
        {
            return ad + " " + soyad;
        }

        //ref - out
        static void Revize(int sayi)
        {
            sayi = 7;
        }

    }
}
