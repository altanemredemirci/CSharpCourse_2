namespace _18_OOP_3_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();

            //customer.Name = "Altan";
            //customer.Surname = "Emre";
            //customer._TC = 12345678901; //value

            //Console.WriteLine(customer._TC);

            // Universite Öğrencilerinin Final ve Vize sınav notlarını öğrenciden alalım. %60 final %40 vize üzerinden ortalama hesaplayarak ekrana yazdırınız. Vize - Final 0-100 aralığı ENCAPSULATION ile kontrol edilecek 


            Ogrenci ogrenci = new Ogrenci();
            Console.WriteLine("Vize:");
            ogrenci._vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final:");
            ogrenci._final = Convert.ToInt32(Console.ReadLine());

            ogrenci.ortalama = 100;

            Console.WriteLine(ogrenci.ortalama);
        }
    }

    class Customer
    {
        //default olarak PRIVATE
        public string Name;
        public string Surname;
        private long TC;  // 11 rakamdan oluşması 

        public long _TC
        {
            //readonly
            get { return TC; }

            set
            {
                if (value.ToString().Length == 11)
                {
                    TC = value;
                }
                else
                {
                    TC = 0;
                }
            }
        }

    }

    class Ogrenci
    {
        private int final { get; set; }
        private int vize { get; set; }

        public double ortalama { get { return vize * 0.4 + final * 0.6; } }

        public int _final
        {
            get { return final; }
            set
            {
                if (value > 0 && value < 101)
                {
                    final = value;
                }
                else
                {
                    Console.WriteLine("Final Notunuz HATALI!!!");
                    final = 0;
                }
            }
        }
        public int _vize {
            get { return vize; }
            set
            {
                if (value > 0 && value < 101)
                {
                    vize = value;
                }
                else
                {
                    Console.WriteLine("Vize Notunuz HATALI!!!");
                    vize = 0;
                }

            }
        }
    }

}
