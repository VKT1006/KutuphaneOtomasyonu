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

namespace KutuphaneOtomasyonu.UI.Uye_UI
{
    public partial class UyeEkle : Form
    {

        UyeManager uyeManager = new UyeManager();
        AdresManager adresManager = new AdresManager();
        IletisimBilgileriManager iletisimbileriManager = new IletisimBilgileriManager();

        public UyeEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana_sayfa anaSayfa = new Ana_sayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Adres adres = new Adres(0, adres_textbox.Text.ToString());
            adresManager.save(adres);
            int adresId = adresManager.getLastSavedId();

            İletisimBilgileri iletisimBilgileri = new İletisimBilgileri(0,telefon_textbox.Text.ToString(), email_textbox.Text.ToString());
            iletisimbileriManager.save(iletisimBilgileri);
            int iletisimBilgileriId = iletisimbileriManager.getLastSavedId();

            Uye uye = new Uye(0,ad_textbox.Text.ToString(), soyad_textbox.Text.ToString(), adresId, iletisimBilgileriId);
            uyeManager.save(uye);

            MessageBox.Show("Üye Kaydedildi!");

            foreach (Control c in Controls )
            {
                if (c is TextBox) c.Text = "";
            }
            

        }
    }
}
