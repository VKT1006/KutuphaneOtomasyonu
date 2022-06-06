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
    public partial class YazarEkle : Form
    {

        YazarManager ym = new YazarManager();

        public YazarEkle()
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
            //string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            MessageBox.Show(theDate);

            Yazar yazar = new Yazar(0,ad_textbox.Text.ToString(),soyad_textbox.Text.ToString(), theDate, aciklama_textbox.Text.ToString());
            ym.save(yazar);
            MessageBox.Show("Yazar Kaydedildi!");

            foreach(Control c  in Controls)
            {
                if (c is TextBox) c.Text = "";
                if (c is DateTimePicker) c.Text = "";
            }

        }
    }
}
