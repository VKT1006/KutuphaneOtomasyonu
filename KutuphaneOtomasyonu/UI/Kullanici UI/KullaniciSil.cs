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
    public partial class KullaniciSil : Form
    {

        KullaniciManager km = new KullaniciManager();

        public KullaniciSil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana_sayfa ana_sayfa = new Ana_sayfa();
            ana_sayfa.Show();
            this.Hide();
        }

        private void KullaniciSil_Load(object sender, EventArgs e)
        {
            tumnKullanicilarigoster();
        }

        private void kullanici_ara_textbox_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = km.getByName(kullanici_ara_textbox.Text.ToString());
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            string kullanici_adi = dataGridView1.CurrentRow.Cells["kullanici_adi"].Value.ToString();
            string parola = dataGridView1.CurrentRow.Cells["parola"].Value.ToString();
                        
            Kullanici kullanici = new Kullanici(id,kullanici_adi, parola );
            
            km.delete(kullanici);
            MessageBox.Show(kullanici_adi + " Adlı Kullanıcı Silindi!");
            tumnKullanicilarigoster();

        }

        public void tumnKullanicilarigoster()
        {
            DataSet ds = km.GetAll();
            dataGridView1.DataSource = ds.Tables[0];
        }

    }
}
