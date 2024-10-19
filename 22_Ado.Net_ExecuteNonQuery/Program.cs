using System.Data.SqlClient;

namespace _22_Ado.Net_ExecuteNonQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXECUTENONQUERY : Veritabanında bir tablo(Create,Alter,Drop,Truncate) veya data (Insert,Update,Delete)  üzerinde manipülasyonyapılacak ise kullanılır.

            Execute execute = new Execute();


            #region Insert
            //Ogretmen ogretmen = new Ogretmen();
            //Console.WriteLine("Adınız:");
            //ogretmen.Ad = Console.ReadLine();
            //Console.WriteLine("Soyadınız:");
            //ogretmen.Soyad = Console.ReadLine();

            //if (execute.OgretmenEkle(ogretmen) > 0)
            //{
            //    Console.WriteLine("Öğretmen Eklendi.");
            //}
            //else
            //{
            //    Console.WriteLine("Öğretmen Eklenemedi.");
            //}
            #endregion

            #region Delete
            //if (execute.OgretmenSil(12) > 0)
            //{
            //    Console.WriteLine("Silme Başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Silme Başarısız!!");
            //}
            #endregion

            #region Update
            Ogretmen ogretmen = new Ogretmen();
            Console.WriteLine("Numara:");
            ogretmen.Numara = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adınız:");
            ogretmen.Ad = Console.ReadLine();
            Console.WriteLine("Soyadınız:");
            ogretmen.Soyad = Console.ReadLine();

            if (execute.OgretmenGuncelle(ogretmen) > 0)
            {
                Console.WriteLine("Öğretmen Güncellendi.");
            }
            else
            {
                Console.WriteLine("Öğretmen Güncellenemedi.");
            }
            #endregion

            //Bir ürünler tablosu üzerinden ekleme,silme,güncelleme işlemleri yapılsın
            //Ürün: Id,Name,Price
            //SqlConnection con = new SqlConnection("Server=202-HOCAPC\\SQLDERS; Database=Market; User Id=sa; Password=1");
            ////SqlCommand cmd = new SqlCommand("Create Table Products (Id int Primary key Identity(1,1),Name varchar(20) Not Null,Price decimal(10,2))", con);

            ////SqlCommand cmd = new SqlCommand("Insert into Products (Name,Price) values ('Etek',150.55)", con);
            ////SqlCommand cmd = new SqlCommand("update Products set Price=250.15 where name='etek'", con);
            //SqlCommand cmd = new SqlCommand("delete from Products where name='etek'", con);



            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();

        }
    }
}
