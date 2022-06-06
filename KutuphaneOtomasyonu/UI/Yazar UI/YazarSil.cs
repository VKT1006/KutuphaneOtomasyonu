using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtomasyonu.Business.Concrete;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.UI.Yazar_UI
{
    public partial class YazarSil : Form
    {
        YazarManager ym = new YazarManager();

        public YazarSil()
        {
            InitializeComponent();
        }

        private void YazarSil_Load(object sender, EventArgs e)
        {
            tumYazarlariGoster();
        }

        public void tumYazarlariGoster()
        {
            DataSet ds = ym.GetAll();
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = ym.GetByName(yazar_ara_textbox.Text.ToString());
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana_sayfa ana_sayfa = new Ana_sayfa();
            ana_sayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            string ad = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            string soyad = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            string[] dogum_tarihi = (dataGridView1.CurrentRow.Cells["dogum_tarihi"].Value.ToString()).Split(" ");
            string aciklama = dataGridView1.CurrentRow.Cells["aciklama"].Value.ToString();

            //MessageBox.Show(dogum_tarihi[0]);

            Yazar yazar = new Yazar(id,ad, soyad, dogum_tarihi[0], aciklama);
            ym.delete(yazar);

            MessageBox.Show(ad + " Adlı Yazar Silindi!");
            tumYazarlariGoster();

        }
    }
}
