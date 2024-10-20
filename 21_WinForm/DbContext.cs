using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_WinForm
{
    internal class DbContext
    {
        public SqlConnection con;
        public SqlCommand cmd;

        public DbContext()
        {
            con = new SqlConnection("Server=202-HOCAPC\\SQLDERS; Database=OkulDB; User Id=sa; Password=1");
            cmd = new SqlCommand();
        }
    }
}
