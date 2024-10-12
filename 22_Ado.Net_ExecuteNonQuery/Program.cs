using System.Data.SqlClient;

namespace _22_Ado.Net_ExecuteNonQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXECUTENONQUERY : Veritabanında bir tabloya manipülasyon(Insert,Update,Delete) yapılacak ise kullanılır.

          SqlConnection connect = new SqlConnection("Server=202-HOCAPC\\SQLDERS; Database=OkulDB; User Id=sa; Password=1");


            SqlCommand cmd = new SqlCommand("Insert into Ogrenci (Numara,Ad,Soyad) values (1,'Altan Emre','Demirci')", connect);

            connect.Open();

            cmd.ExecuteNonQuery();

            connect.Close();

        }
    }
}
