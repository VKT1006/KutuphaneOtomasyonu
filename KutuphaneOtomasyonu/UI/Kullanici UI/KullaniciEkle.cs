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

namespace KutuphaneOtomasyonu.UI.Kullanici_UI
{
    public partial class KullaniciEkle : Form
    {

        KullaniciManager km = new KullaniciManager();

        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana_sayfa ana_sayfa = new Ana_sayfa();
            ana_sayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici(0,kullanici_adi_textbox.Text.ToString(), parola_textbox.Text.ToString());
            km.save(kullanici);
            MessageBox.Show("Kullanıcı Kaydedildi!");


            foreach (Control c in Controls) {
                if (c is TextBox)
                    c.Text = "";
            }



        }
    }
}
