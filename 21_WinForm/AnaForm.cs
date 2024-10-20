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
    public partial class AnaForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public AnaForm()
        {
            InitializeComponent();
            con = new SqlConnection("Server=202-HOCAPC\\SQLDERS; Database=OkulDB; User Id=sa; Password=1");
            OgrenciDoldur();
        }

        private void btn_register_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Register form = new Register();
            form.Show();
        }

        private void OgrenciDoldur()
        {
            List<Ogrenci> ogrencis = new List<Ogrenci>();
            cmd = new SqlCommand("Select * from Students", con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            #region LISTBOX
            while (reader.Read())
            {
                //string ogrenciBilgi = reader[0].ToString()+" "+ reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString();

                //lst_ogrenciler.Items.Add(ogrenciBilgi);

                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Id = reader.GetInt32(0);
                ogrenci.Name = reader.GetString(1);
                ogrenci.Surname = reader.GetString(2);
                ogrenci.Branch = reader.GetString(3);

                ogrencis.Add(ogrenci);

                lst_ogrenciler.Items.Add(ogrenci);
            }
            #endregion


            #region LISTVIEW


            //while (reader.Read())
            //{
            //    ListViewItem lvi = new ListViewItem();
            //    lvi.Text = reader[0].ToString();
            //    lvi.SubItems.Add(reader[1].ToString());
            //    lvi.SubItems.Add(reader[2].ToString());
            //    lvi.SubItems.Add(reader[3].ToString());

            //    listView1.Items.Add(lvi);

            //}


            #endregion

            //DATAGRIDVIEW
            dtgridOgrenciler.DataSource = ogrencis;




            con.Close();

        }

        private void btn_ogretmen_Click(object sender, EventArgs e)
        {
            Teacher form = new Teacher();
            form.Show();
            this.Hide();
        }
    }
}
