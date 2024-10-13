using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Ado.Net_ExecuteNonQuery
{
    internal class Execute
    {
        public SqlConnection con;

        public Execute()
        {
            con = new SqlConnection("Server=202-HOCAPC\\SQLDERS; Database=OkulDB; User Id=sa; Password=1");
        }

        public int OgretmenEkle(Ogretmen ogretmen)
        {
            SqlCommand command = new SqlCommand($"Insert into Ogretmen (Ad,Soyad) values ('{ogretmen.Ad}','{ogretmen.Soyad}')",con);

            con.Open();
            var EKS = command.ExecuteNonQuery();
            con.Close();

            return EKS;
        }

        public int OgretmenSil(int numara)
        {
            SqlCommand command = new SqlCommand($"Delete from Ogretmen where numara={numara}", con);

            con.Open();
            var EKS = command.ExecuteNonQuery();
            con.Close();

            return EKS;
        }

        public int OgretmenGuncelle(Ogretmen ogretmen)
        {
            SqlCommand command = new SqlCommand($"update Ogretmen set Ad = '{ogretmen.Ad}', Soyad='{ogretmen.Soyad}' where Numara = {ogretmen.Numara}", con);

            con.Open();
            var EKS = command.ExecuteNonQuery();
            con.Close();

            return EKS;
        }

        
       
    }
}
