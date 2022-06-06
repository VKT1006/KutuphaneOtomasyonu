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
    public partial class KullaniciGuncelle : Form
    {

        KullaniciManager km = new KullaniciManager();

        public KullaniciGuncelle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana_sayfa ana_sayfa = new Ana_sayfa();
            ana_sayfa.Show();
            this.Hide();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            kullanici_adi_textbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            parola_textbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Kullanici kullanici = new Kullanici(id, kullanici_adi_textbox.Text.ToString(), parola_textbox.Text.ToString());
            km.update(kullanici);
        }

        private void KullaniciGuncelle_Load(object sender, EventArgs e)
        {
            DataSet ds = km.GetAll();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void kullanici_ara_textbox_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = km.getByName(kullanici_adi_textbox.Text.ToString());
            dataGridView1.DataSource =ds.Tables[0];

        }
    }
}
