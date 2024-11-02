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
    public partial class ArabaForm : Form
    {
        DataContext db;
        public ArabaForm()
        {
            InitializeComponent();
            db = new DataContext();

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
            dt_araba.DataSource = db.Arabas.Where(i => i.MarkaId == (int)cmb_marka.SelectedValue).ToList();
        }
    }
}
