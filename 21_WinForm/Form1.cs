using System.Data.SqlClient;

namespace _21_WinForm
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Server=202-HOCAPC\\SQLDERS; Database=OkulDB; User Id=sa; Password=1");

        }

        public void CreateTable()
        {
            command = new SqlCommand("Create table Users (Id int PRIMARY KEY Identity(1,1),KullaniciAdi varchar(20) NOT NULL,Sifre varchar(6) NOT NULL)", con);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        private void btn_createtable_Click(object sender, EventArgs e)
        {
            string message = "";

            try
            {
                CreateTable();
                message = "Tablo Oluþturuldu.";
            }
            catch (Exception em)
            {
                message = em.Message;
            }
            finally
            {
                MessageBox.Show(message);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            command = new SqlCommand($"Select * from Users where KullaniciAdi='{username}' and Sifre='{password}'", con);


            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Giriþ Baþarýlý");
            }
            else
            {
                MessageBox.Show("Giriþ bilgileriniz hatalý");
            }
            con.Close();
        }
    }
}
