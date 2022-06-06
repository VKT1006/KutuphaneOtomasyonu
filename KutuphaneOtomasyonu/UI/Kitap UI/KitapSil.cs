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

namespace KutuphaneOtomasyonu.UI.Kitap_UI
{
    public partial class KitapSil : Form
    {
        KitapManager km = new KitapManager();

        public KitapSil()
        {
            InitializeComponent();
        }

        private void KitapSil_Load(object sender, EventArgs e)
        {
            tumKitaplariGoster();
        }

        public void tumKitaplariGoster()
        {
            DataSet ds = km.getAll();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            string ISBN = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
            string kitapAdi = dataGridView1.CurrentRow.Cells["kitap_adi"].Value.ToString();
            string sayfaSayisi = dataGridView1.CurrentRow.Cells["sayfa_sayisi"].Value.ToString();
            string yazarAd = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            int yazarId = new YazarManager().GetIdByName(yazarAd);


            Kitap kitap = new Kitap(id, yazarId, ISBN, kitapAdi, sayfaSayisi);

            km.delete(kitap);

            tumKitaplariGoster();

            MessageBox.Show(kitapAdi + " Adlı Kitap Silindi!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana_sayfa ana_Sayfa = new Ana_sayfa();
            ana_Sayfa.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            DataSet ds = km.getByName(textBox1.Text.ToString());
            dataGridView1.DataSource = ds;

        }
    }
}
