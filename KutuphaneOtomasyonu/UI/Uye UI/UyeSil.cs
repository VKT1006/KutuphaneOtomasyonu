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
    public partial class UyeSil : Form
    {

        UyeManager uyeManager = new UyeManager();
        IletisimBilgileriManager iletisimBilgileriManager = new IletisimBilgileriManager();
        AdresManager adresManager = new AdresManager(); 

        public UyeSil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana_sayfa anaSayfa = new Ana_sayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void UyeSil_Load(object sender, EventArgs e)
        {
            tumUyeleriGoster();

        }

        public void tumUyeleriGoster()
        {
            DataSet ds = uyeManager.getAll();
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void uye_ara_textbox_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = uyeManager.getByName(uye_ara_textbox.Text.ToString());
            dataGridView1.DataSource =ds.Tables[0]; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            string ad = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            string soyad = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            string adres = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            string telefon = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            string email = dataGridView1.CurrentRow.Cells["email"].Value.ToString();

            int ibId = iletisimBilgileriManager.getIdByEmail(email);
            int adresId = adresManager.getIdByAdres(adres);

            adresManager.delete(new Adres(adresId, adres));
            iletisimBilgileriManager.delete(new İletisimBilgileri(ibId, telefon, email));

            Uye uye = new Uye(0,ad, soyad, adresId, ibId);
            uyeManager.delete(uye);

            MessageBox.Show("Uye Silindi!");

            tumUyeleriGoster();
        }
    }
}
