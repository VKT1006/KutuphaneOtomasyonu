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
using MySql.Data.MySqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class Kullanici_kayit : Form
    {
        public Kullanici_kayit()
        {
            InitializeComponent();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Kullanici kullanici = new Kullanici(0,kullanici_adi_textBox.Text, Parola_textBox.Text);

            KullaniciManager kullaniciManager = new KullaniciManager();
            kullaniciManager.save(kullanici);

            MessageBox.Show("Kayıt Alındı!");

            foreach (Control c in Controls) if (c is TextBox) c.Text = ""; // Formun Control sınıfına bakarken direkt controls yaz

        }
    }
}
