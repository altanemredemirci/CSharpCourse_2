using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_Rent_A_Car
{
    public partial class Login : Form
    {
        DataContext db;
        public Login()
        {
            InitializeComponent();
            db = new DataContext();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

            if (txt_Rpass.Text != txt_Rpass2.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
                return;
            }

            var customer = db.Musteris.Where(i=> i.Telefon==txt_Rphone.Text).FirstOrDefault();
            if(customer != null)
            {
                MessageBox.Show("Kayıtlı Müşteri!!!");
                return ;
            }

            Musteri musteri = new Musteri();
            musteri.Telefon = txt_Rphone.Text;
            musteri.Bakiye = Convert.ToDouble(txt_Rbalance.Text);
            musteri.AdSoyad = txt_Rname.Text;
            musteri.Password = txt_Rpass.Text;

            db.Musteris.Add(musteri);
            int EKS = db.SaveChanges();
            if(EKS> 0) 
            {
                MessageBox.Show("Kayıt Başarılı");
                txt_Rpass.Clear();
                txt_Rpass2.Clear();
                txt_Rname.Clear();
                txt_Rphone.Clear();
                txt_Rbalance.Clear();
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string telefon = txt_phone.Text;
            string sifre = txt_password.Text;

            var musteri = db.Musteris.FirstOrDefault(i => i.Telefon == telefon && i.Password == sifre);

            if (musteri == null)
            {
                MessageBox.Show("Giriş Bilgileri Hatalı!");
                txt_password.Clear();
            }
            else
            {
                MessageBox.Show("Giriş Bilgileri Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                ArabaForm form = new ArabaForm(musteri);
                form.Show();
            }
        }
    }
}
