namespace _18_OOP_4_Inheritance_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
           Şirket Otomasyonu

           IK:Ad,Soyad,TC,SGKGirisTarihi,PersonelSayisi
           IT:Ad,Soyad,TC,SGKGirisTarihi,ProgramSayisi
           MUH:Ad,Soyad,TC,SGKGirisTarihi,HesapSayisi
           PAZ:Ad,Soyad,TC,SGKGirisTarihi,TeklifSayisi

           PersonelEkle(),PersonelListele(),PersonelSil(),PersonelGuncelle()


           */
            List<IK> IKs = new List<IK>();
            List<IT> ITs = new List<IT>();
            List<MUH> MUHs = new List<MUH>();
            List<PAZ> PAZs = new List<PAZ>();

            IK ik = new IK();
            ik.PersonelEkle(IKs);

            foreach (IK personel in IKs)
            {
                IK.Listele(personel);
            }

            Console.WriteLine("******************");

            IK.Guncelle(IKs);
        }
    }

    class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TC { get; set; }
        public string SGKGirisTarihi { get; set; }


        public void PersonelEkle()
        {
            Console.WriteLine("Ad:");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
            Console.WriteLine("TC:");
            TC = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("SGK:");
            SGKGirisTarihi = Console.ReadLine();            
        }
        public static void Listele(Personel item)
        {
            Console.WriteLine("\nAdsoyad:" + item.Ad + " " + item.Soyad + "\nTC:" + item.TC + "\nSGK Giriş:" + item.SGKGirisTarihi);
        }
               
    }
    class IK:Personel
    {
        public int PersonelSayisi { get; set; }

        public void PersonelEkle(List<IK> liste)
        {
            base.PersonelEkle();
            Console.WriteLine("Personel Sayısı:");
            PersonelSayisi = Convert.ToInt32(Console.ReadLine());
            liste.Add(this);
        }

        public static void Listele(IK item)
        {
            Personel.Listele(item);
            Console.WriteLine("PersonelSayısı:"+item.PersonelSayisi);
        }

        public static void Silme(List<IK> liste)
        {
            foreach (IK item in liste)
            {
                Listele(item);
            }

            Console.WriteLine("Silmek istediğiniz Personel Tc:");
            long tc = Convert.ToInt64(Console.ReadLine());

            IK silinecek = liste.FirstOrDefault(i => i.TC == tc);

            liste.Remove(silinecek);
        }

        public static void Guncelle(List<IK> liste)
        {
            foreach (IK item in liste)
            {
                Listele(item);
            }

            Console.WriteLine("Güncellemek istediğiniz Personel Tc:");
            long tc = Convert.ToInt64(Console.ReadLine());

            IK guncellenecek = liste.FirstOrDefault(i => i.TC == tc);

            guncellenecek.PersonelEkle();
            Console.WriteLine("Personel Sayısı:");
            guncellenecek.PersonelSayisi = Convert.ToInt32(Console.ReadLine());
        }

    }
    class IT:Personel
    {
        public int ProgramSayisi { get; set; }

        public void PersonelEkle(List<Personel> liste)
        {
            base.PersonelEkle();
            Console.WriteLine("Program Sayısı:");
            ProgramSayisi = Convert.ToInt32(Console.ReadLine());
            liste.Add(this);
        }
        public static void Listele(IT item)
        {
            Personel.Listele(item);
            Console.WriteLine("ProgramSayısı:" + item.ProgramSayisi);
        }
    }
    class MUH:Personel
    {
        public int HesapSayisi { get; set; }
        public void PersonelEkle(List<Personel> liste)
        {
            base.PersonelEkle();
            Console.WriteLine("Hesap Sayısı:");
            HesapSayisi = Convert.ToInt32(Console.ReadLine());
            liste.Add(this);
        }
        public static void Listele(MUH item)
        {
            Personel.Listele(item);
            Console.WriteLine("PersonelSayısı:" + item.HesapSayisi);
        }
    }
    class PAZ:Personel
    {
        public int TeklifSayisi { get; set; }
        public void PersonelEkle(List<Personel> liste)
        {
            base.PersonelEkle();
            Console.WriteLine("Teklif Sayısı:");
            TeklifSayisi = Convert.ToInt32(Console.ReadLine());
            liste.Add(this);
        }
        public static void Listele(PAZ item)
        {
            Personel.Listele(item);
            Console.WriteLine("PersonelSayısı:" + item.TeklifSayisi);
        }
    }
}
