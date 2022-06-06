using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtomasyonu.Business.Abstract;
using KutuphaneOtomasyonu.Business.Concrete;
using KutuphaneOtomasyonu.UI.Kitap_UI;
using KutuphaneOtomasyonu.UI.Kullanici_UI;
using KutuphaneOtomasyonu.UI.Uye_UI;
using KutuphaneOtomasyonu.UI.Yazar_UI;

namespace KutuphaneOtomasyonu
{

    

    public partial class Ana_sayfa : Form
    {
        KitapService kitapManager = new KitapManager();
        YazarManager yazarManager = new YazarManager();
        

        public Ana_sayfa()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ana_sayfa_Load(object sender, EventArgs e)
        {
            tumKitaplariYukle();   
        }

        public void tumKitaplariYukle()
        {

            DataSet ds = kitapManager.getAll();
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void kitapEklToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.Show();
            this.Hide();
        }

        private void kitap_ara_TextBox_TextChanged(object sender, EventArgs e)
        {

            DataSet ds = kitapManager.getByName(kitap_ara_TextBox.Text.ToString());
            dataGridView1.DataSource = ds.Tables[0];
            
               
        }

        private void yazar_ara_textbox_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = yazarManager.GetByName(yazar_ara_textbox.Text.ToString());
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void kitapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapSil kitapSil = new KitapSil();
            kitapSil.Show();
            this.Hide();
        }

        private void kitapGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapGuncelle kitap_guncelle = new KitapGuncelle();
            kitap_guncelle.Show();
            this.Hide();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciEkle kullanici_ekle = new KullaniciEkle();
            kullanici_ekle.Show();
            this.Hide();
        }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciSil kullaniciSil = new KullaniciSil();
            kullaniciSil.Show();
            this.Hide();
        }

        private void kullanıcıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciGuncelle kullaniciGuncelle = new KullaniciGuncelle();
            kullaniciGuncelle.Show();
            this.Hide();
        }

        private void yazarEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YazarEkle yazarEkle = new YazarEkle();
            yazarEkle.Show();
            this.Hide();
        }

        private void yazarSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YazarSil yazarSil = new YazarSil();
            yazarSil.Show();
            this.Hide();
        }

        private void yazarGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YazarGuncelle yazarGuncelle = new YazarGuncelle();
            yazarGuncelle.Show();
            this.Hide();
        }

        private void tümÜyeleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TumUyeler tumUyeler = new TumUyeler();
            tumUyeler.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }

        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.Show();
            this.Hide();
        }

        private void üyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeSil uyeSil = new UyeSil();   
            uyeSil.Show();
            this.Hide();
        }

        private void üyeGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeGuncelle uyeGuncelle = new UyeGuncelle();
            uyeGuncelle.Show();
            this.Hide();
        }
    }
}

