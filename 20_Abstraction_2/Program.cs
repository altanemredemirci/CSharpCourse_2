namespace _20_Abstraction_2
{
    internal class Program
    {
        /*AÇIKLAMA*/
        /*1- Abstract olarak işaretlenen FiyatHesapla() metodunun gövdesi abstract olarak işaretlendiği sınıfta kodlanamaz.

          2- Abstract olan ElektronikEsya sınıfından türetilen sınıflar, ElektronikEsya’nın abstract üyelerini içermek zorundadır.


          Bir oop tasarımında, sınıf içerisinde abstract üyeler tanımlayarak, bu sınıftan türetilen sınıfları, tanımladığımız abstact üyelerin gövdelerini kodlamaya zorlayabiliriz. 
          Örneğimiz üzerinden bir cümle kuracak olursak bir nevi şunu demiş oluruz: “Eğer sen bir elektronik eşya isen, fiyatını hesaplayabileceğim bir metodu bana sunmak zorundasın.”

          Kaldığımız yerden devam edersek kodun son hali aşağıdaki gibi olacaktır. Bilgisayar fiyatı hesaplanırken ek bir masraf alındığını farz edelim.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    abstract class ElektronikEsya
    {
        public decimal AlisFiyati { get; set; }
        public decimal KarYüzdesi { get; set; }

        public abstract decimal FiyatHesapla();
    }

    class Telefon : ElektronikEsya
    {
        public override decimal FiyatHesapla()
        {
            return AlisFiyati + (AlisFiyati * KarYüzdesi);
        }
    }

    class Bilgisayar : ElektronikEsya
    {
        public decimal EkMasraf { get; set; }

        public override decimal FiyatHesapla()
        {
            return EkMasraf+ AlisFiyati + (AlisFiyati * KarYüzdesi);
        }
    }

}
