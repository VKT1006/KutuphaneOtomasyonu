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
    public partial class KitapEkle : Form
    {
        KitapManager km = new KitapManager();
        YazarManager ym = new YazarManager();
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            int yazarId = ym.GetIdByName(comboBox1.Text.ToString());
            Kitap kitap = new Kitap(0,yazarId, ISBN_textbox.Text.ToString(), kitap_ad_textbox.Text.ToString(), sayfa_sayisi_textbox.Text.ToString());
            km.save(kitap);
            
            MessageBox.Show("Kİtap Kayıt Edildi!");

            foreach (Control c in Controls)
            {
                if (c is TextBox) c.Text = "";
                if (c is ComboBox) c.Text = "";
            }

        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            DataSet ds = ym.GetAll();
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                comboBox1.Items.Add(row["Ad"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana_sayfa anaSayfa = new Ana_sayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
