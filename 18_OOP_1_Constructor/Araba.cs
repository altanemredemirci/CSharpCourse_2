using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP_1_Constructor
{
    /*
             Araba:Marka,Model,Renk,MotorHacmi,UretimYili
                * Araba classı oluşturulacak.Oluşturulan classın propertyleri(marka,model,...) eklenecek
            

             Kayıt,Listeleme,Guncelleme,Filtreleme(Marka)
             */
    internal class Araba
    {
        internal static List<Araba> arabalar = new List<Araba>();

        int Id;
        string Marka;
        string Model;
        string Renk;
        int MotorHacmi;
        int UretimYili;


        public Araba(int id,string marka,string model, string renk, int motorHacmi, int uretimYili)
        {
            Kayit(id,marka, model, renk, motorHacmi, uretimYili);
        }

        private void Kayit(int id, string marka, string model, string renk, int motorHacmi, int uretimYili)
        {
            this.Id = id;
            this.Marka = marka;
            this.Model = model;
            this.Renk = renk;
            this.MotorHacmi = motorHacmi;
            this.UretimYili = uretimYili;

            arabalar.Add(this);
        }

        internal static void Listele()
        {
            foreach (Araba item in arabalar)
            {
                Console.WriteLine(item.Id+"-"+item.Marka+" "+item.Model+" "+item.Renk+" "+item.UretimYili+" "+item.MotorHacmi);
            }

        }


        internal static void Ara()
        {
            Console.WriteLine("Marka:");
            string marka = Console.ReadLine();

            bool bulundu = false;

            foreach (Araba item in arabalar)
            {
                if (marka == item.Marka)
                {
                    Console.WriteLine(item.Marka + " " + item.Model + " " + item.Renk + " " + item.UretimYili + " " + item.MotorHacmi);
                    bulundu = true;
                }
                
            }

            Console.WriteLine(bulundu==false ? "Aradığınız Marka Bulunamadı!!" :"");
        }

        internal static void Guncelleme()
        {
            Listele();

            Console.WriteLine("Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            //Araba araba = arabalar.Where(i => i.Id == id).FirstOrDefault();
            Araba araba = arabalar.FirstOrDefault(i => i.Id == id);

            Console.WriteLine("Marka:");
            araba.Marka = Console.ReadLine();

            Console.WriteLine("Model:");
            araba.Model = Console.ReadLine();

            Console.WriteLine("Renk:");
            araba.Renk = Console.ReadLine();

            Console.WriteLine("Motor Hacmi:");
            araba.MotorHacmi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Üretim Yılı:");
            araba.UretimYili = Convert.ToInt32(Console.ReadLine());

        }

    }
}
