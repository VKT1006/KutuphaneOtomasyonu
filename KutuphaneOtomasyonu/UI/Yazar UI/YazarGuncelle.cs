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
    public partial class YazarGuncelle : Form
    {

        YazarManager ym = new YazarManager();


        public YazarGuncelle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana_sayfa anaSayfa = new Ana_sayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void YazarGuncelle_Load(object sender, EventArgs e)
        {
            tumYazarlariGoster();
        }

        public void tumYazarlariGoster()
        {
            DataSet ds = ym.GetAll();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void yazar_ara_textbox_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = ym.GetByName(yazar_ara_textbox.Text.ToString());
            dataGridView1.DataSource =ds.Tables[0];

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ad_textbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //--> isbn
            soyad_textbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); //--> isbn
            date_textbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); //--> Kitap Adi
            aciklama_textbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); //--> sayfa sayisi
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Yazar yazar = new Yazar(id, ad_textbox.Text.ToString(), soyad_textbox.Text.ToString(), date_textbox.Text.ToString(), aciklama_textbox.Text.ToString());
            ym.update(yazar);
            tumYazarlariGoster();
            MessageBox.Show("Yazar Güncellendi!");
        }
    }
}
