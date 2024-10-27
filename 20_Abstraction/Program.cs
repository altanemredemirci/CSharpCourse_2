namespace _20_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {/*ABSTRACT NEDİR?*/
            /*Abstract class’lar, oluşturulması istenen class’ların sadece base class olarak davranması
             * ve üzerinden bir instance oluşturulmamasının istendiği durumlarda kullanılır. 
             * C#’da bu fonksiyonaliteyi sağlamak için abstract anahtar sözcüğünü kullanmak yeterlidir. */
            //Insan insan = new Insan();

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Ali";
        }
    }

    //Insan sınıfı temel(base) sınıf olarak tanımlandı. Aktif olarak bir Instance alınmayacak.
    abstract class Insan
    {
        public abstract long TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }


        //Insan'dan türeyen her classta mutlaka Create(),Update(),Delete(),List(),Find()
        public abstract void Create(); //abstract keyword ünü alan Field lar türeyen classlarda tanımlanmalıdır.
        public abstract void Update(); //abstract keyword ünü alan Field lar türeyen classlarda tanımlanmalıdır.
        public abstract void Delete(); //abstract keyword ünü alan Field lar türeyen classlarda tanımlanmalıdır.
        public abstract void List(); //abstract keyword ünü alan Field lar türeyen classlarda tanımlanmalıdır.

        public void Find(int id)
        {

        }
       
    }

    class Ogrenci:Insan
    {
        public int OkulNo { get; set; }
        public override long TC { get; set; }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void List()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }

    class Ogretmen:Insan
    {
        public int Maas { get; set; }
        public override long TC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void List()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }

    class Veli : Insan
    {
        public string Telefon { get; set; }
        public override long TC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void List()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
