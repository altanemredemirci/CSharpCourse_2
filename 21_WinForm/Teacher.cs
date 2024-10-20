using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_WinForm
{
    public partial class Teacher : Form
    {
        DbContext db;
        public Teacher()
        {
            InitializeComponent();
            db = new DbContext();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.FullName = textBox1.Text;
            ogretmen.Experience = (int)nmr_experience.Value;
            ogretmen.Phone = msk_phone.Text;
            ogretmen.Gender = radioButton1.Checked == true ? radioButton1.Text : radioButton2.Text;
            ogretmen.BirthDate = Convert.ToDateTime(dt_birthDate.Text);
           
            foreach(Control control in groupBox2.Controls)
            {
                if (((CheckBox)control).Checked == true)
                {
                    ogretmen.Courses.Add(control.Text);
                }
            }

            db.cmd.CommandText = $"insert into Teachers values ('{ogretmen.FullName}','{ogretmen.Gender}','{ogretmen.Courses}','{ogretmen.Experience}','{ogretmen.BirthDate}','{ogretmen.Phone}')";

            db.cmd.Connection=db.con;

            db.con.Open();

            db.cmd.ExecuteNonQuery();
            
            db.con.Close();




        }
    }
}
