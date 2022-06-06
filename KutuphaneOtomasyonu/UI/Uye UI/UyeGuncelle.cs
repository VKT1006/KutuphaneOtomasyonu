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
    public partial class UyeGuncelle : Form
    {

        UyeManager uyeManager = new UyeManager();
        IletisimBilgileriManager iletisimBilgileriManager = new IletisimBilgileriManager();
        AdresManager adresManager = new AdresManager();

        public UyeGuncelle()
        {
            InitializeComponent();
        }

        private void UyeGuncelle_Load(object sender, EventArgs e)
        {
            tumUyeleriGoster();
        }

        public void tumUyeleriGoster()
        {
            DataSet ds = uyeManager.getAll();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ad_textbox.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString(); 
            soyad_textbox.Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString(); 
            email_textbox.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString(); 
            telefon_textbox.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString(); 
            adres_textbox.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana_sayfa anaSayfa = new Ana_sayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int adresId = adresManager.getIdByAdres(dataGridView1.CurrentRow.Cells["adres"].Value.ToString());
            int ibId = iletisimBilgileriManager.getIdByEmail(dataGridView1.CurrentRow.Cells["email"].Value.ToString());
            int uyeId = uyeManager.getIdByName(dataGridView1.CurrentRow.Cells["ad"].Value.ToString());    

            adresManager.update(new Adres(adresId, adres_textbox.Text.ToString()));
            iletisimBilgileriManager.update(new İletisimBilgileri(ibId, telefon_textbox.Text.ToString(), email_textbox.Text.ToString()));

            uyeManager.update(new Uye(uyeId,ad_textbox.Text.ToString(), soyad_textbox.Text.ToString(), adresId, ibId));

            MessageBox.Show("Üye Güncellendi!");
            tumUyeleriGoster();
        }
    }
}
