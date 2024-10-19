using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Ado.Net_ExecuteReader
{
    internal class Execute
    {
        SqlConnection conn;
        public Execute()
        {
           conn = new SqlConnection("Server=202-HOCAPC\\SQLDERS; Database=Northwind; User Id=sa; Password=1");
        }

        internal List<Category> CategoryList()
        {
            SqlCommand cmd = new SqlCommand("Select * from Categories where CategoryName='Condiments'", conn);

            conn.Open();

            SqlDataReader reader= cmd.ExecuteReader();

            List<Category> categories = new List<Category>();

            while (reader.Read())
            {
                Category cat = new Category();
                cat.CategoryId = (int)reader[0];
                cat.CategoryName = reader.GetString(1);
                cat.Description = reader[2].ToString();
                categories.Add(cat);
            }


            conn.Close();

            return categories;

        }
    }
}
