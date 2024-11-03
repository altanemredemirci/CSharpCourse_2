using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _24_Rent_A_Car
{
    public partial class ArabaForm : Form
    {
        DataContext db;
        Araba kiralikAraba;
        Musteri musteri;
        DateTime finishDate;
        DateTime startDate;
        public ArabaForm(Musteri musteri)
        {
            InitializeComponent();
            db = new DataContext();
            this.musteri = musteri;
        }

        private void ArabaForm_Load(object sender, EventArgs e)
        {
            cmb_marka.DataSource = db.Markas.ToList();
            cmb_marka.DisplayMember = "Ad";
            cmb_marka.ValueMember = "Id";
            cmb_marka.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // LINQ ile yazılan sorgu ToList() ifadesi ile sonlandırılır. AsQueryable() metodu ile sorgü cümlesi . değilde , ile bitirilmiş olur. Yani devamında ekleme yapılabilir.
            var arabaList = db.Arabas.AsQueryable();

            if (cmb_marka.SelectedValue != null)
            {
                arabaList = arabaList.Where(i => i.MarkaId == (int)cmb_marka.SelectedValue);
            }

            //List<Araba>list= new List<Araba>();

            //foreach (var item in arabaList.ToList())
            //{
            //    list.Add(new Araba()
            //    {
            //        Id= item.Id,
            //        Fiyat=item.Fiyat,
            //        Km=item.Km,
            //        Marka=item.MarkaId,
            //    })
            //}


            //dt_araba.DataSource = arabaList.Include("Marka").ToList();
            dt_araba.DataSource = arabaList.Include(i => i.Marka).ToList();
        }

        private void dt_araba_DoubleClick(object sender, EventArgs e)
        {

            int id = (int)dt_araba.SelectedRows[0].Cells[0].Value;
            //var araba = db.Arabas.Where(i => i.Id == id).FirstOrDefault();
            //var araba = db.Arabas.FirstOrDefault(i => i.Id == id);
            kiralikAraba = db.Arabas.Find(id);
            if (kiralikAraba == null)
            {
                MessageBox.Show("Araba bulunamadı!");
            }
            
            txt_karaba.Text = kiralikAraba.Marka.Ad + " " + kiralikAraba.Model;
        }

        private void btn_kirala_Click(object sender, EventArgs e)
        {
            if(txt_karaba.Text.Length > 0)
            {
                btn_hesapla_Click(sender, e);

                DateTime teslimTarihi = db.Kiralamas.Where(i => i.ArabaId == kiralikAraba.Id).Select(i => i.BitisTarihi).FirstOrDefault();

                if (teslimTarihi > startDate)
                {
                    MessageBox.Show("Bu Tarihler Müsait Değil.");
                    return;
                }

                Kiralama kiralama = new Kiralama();
                kiralama.ArabaId = kiralikAraba.Id;               
                kiralama.BitisTarihi= dt_bitisTarih.Value.Date + dt_bitisSaat.Value.TimeOfDay;
                kiralama.BaslangicTarihi= dt_baslaTarih.Value.Date + dt_baslaSaat.Value.TimeOfDay;
                kiralama.Ucret=Convert.ToDecimal(txt_ktoplam.Text.Trim('₺'));
                kiralama.MusteriId = musteri.Id;
                db.Kiralamas.Add(kiralama);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Araç Kiralandı.");
                }

            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            finishDate = dt_bitisTarih.Value.Date +
                    dt_bitisSaat.Value.TimeOfDay;

            startDate = dt_baslaTarih.Value.Date +
                    dt_baslaSaat.Value.TimeOfDay;

            if (finishDate > startDate)
            {
                TimeSpan timeSpan = finishDate.Subtract(startDate);

                int totalHours = Convert.ToInt32(Math.Ceiling(timeSpan.TotalHours));

                double total = (double)kiralikAraba.Fiyat * totalHours;
                txt_ktoplam.Text = Math.Ceiling(total).ToString("c");
                txt_ktoplamSaat.Text = totalHours.ToString();
            }

            else
            {
                MessageBox.Show("Kiralama tarihi teslim tarihinden ileri olamaz","HATA",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

           
        }
    }
}
