using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Ado.Net
{
    internal class Execute
    {
        SqlConnection con;
        public Execute()
        {
             con= new SqlConnection("Server=202-HOCAPC\\SQLDERS; Database=OkulDB; User Id=sa; Password=1");
        }

        public void CreateTable()
        {
            SqlCommand cmd = new SqlCommand("Create Table Ogretmen ( Numara int PRIMARY KEY Identity(1,1), Ad varchar(30),Soyad varchar(30))", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void AddColumn()
        {
            SqlCommand cmd = new SqlCommand("Alter Table Ogrenci Add Sinif varchar(10)", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void AlterColumn(string tableName,string columnName,string dataType,string notNull="")
        {
            SqlCommand cmd = new SqlCommand($"Alter Table {tableName} Alter Column {columnName} {dataType} {notNull}", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DropColumn()
        {
            SqlCommand cmd = new SqlCommand("Alter Table Ogrenci Drop Column Sinif", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
