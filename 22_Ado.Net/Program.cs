using System.Data.SqlClient;

namespace _22_Ado.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MICRO ORM ARAÇLARI
            // Object Relation Mapping

            // Bir yazılım projesinde data arama, filtreleme, ekle, silme, güncelleme gibi işlemler için Yazılım Dili ile SQL arasında iletişim kurulmalıdır. Bunu en kolay ve performanslı yapmak için frameworkler kullanılır.

            /* EN POPÜLER FRAMEWORKLER
             * Entity Framework(C# <-> MSSQL 631ms)
             * Dapper (C# <-> MSSQL 49ms)
             * Ado.Net (C# <-> MSSQL 47ms) 
             */

            #region SQLCONNECTION
            //Windows Authentication ConnectString
            //SqlConnection connect = new SqlConnection("Data Source=202-HOCAPC\\SQLDERS; Initial Catalog=OkulDB; Integrated Security=true");

            //SqlConnection connect = new SqlConnection("Server=202-HOCAPC\\SQLDERS; Database=OkulDB; Integrated Security=true");

            //SQL Authentication ConnectionString
            //SqlConnection connect = new SqlConnection("Data Source=202-HOCAPC\\SQLDERS; Initial Catalog=OkulDB; User Id=sa; Password=1");

            //SqlConnection connect = new SqlConnection("Server=202-HOCAPC\\SQLDERS; Database=OkulDB; User Id=sa; Password=1");


            //connect.Open();
            //Console.WriteLine("Bağlantı Yapıldı");
            //connect.Close();
            //Console.WriteLine("Bağlantı Kapatıldı");
            #endregion

            Execute execute = new Execute();

            execute.CreateTable();
            //execute.AddColumn();
            //execute.AlterColumn("Ogrenci","Numara","int","Not Null");
            //execute.DropColumn();

        }
    }
}
