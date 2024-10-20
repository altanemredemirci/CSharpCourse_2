using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_WinForm
{
    public partial class Register : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Register()
        {
            InitializeComponent();
            con = new SqlConnection("Server=202-HOCAPC\\SQLDERS; Database=OkulDB; User Id=sa; Password=1");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_surname.Text) || string.IsNullOrEmpty(cmb_branch.Text))
            {
                MessageBox.Show("Alanları Doldurunuz");
                return;
            }

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Branch = cmb_branch.Text;
            ogrenci.Surname = txt_surname.Text;
            ogrenci.Name = txt_name.Text;


            //cmd = new SqlCommand("Insert into Students values(@ad,@soyad,@bolum)", con);
            //cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = ogrenci.Name;
            //cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = ogrenci.Surname;
            //cmd.Parameters.Add("@bolum", SqlDbType.VarChar).Value = ogrenci.Branch;

            cmd = new SqlCommand($"Insert into Students values('{ogrenci.Name}','{ogrenci.Surname}','{ogrenci.Branch}')", con);

            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Kayıt Yapıldı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_name.Text = "";
                txt_surname.Clear();
                cmb_branch.SelectedIndex = -1;
                //cmb_branch.Text = "";

            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            con.Close();

        }
    }
}
