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

namespace KutuphaneOtomasyonu.UI.Uye_UI
{
    public partial class TumUyeler : Form
    {

        UyeManager um = new UyeManager();

        public TumUyeler()
        {
            InitializeComponent();
        }

        private void TumUyeler_Load(object sender, EventArgs e)
        {
            tumUyeleriGoster();
        }

        public void tumUyeleriGoster()
        {
            DataSet ds = um.getAll();
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ana_sayfa anaSayfa = new Ana_sayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void uyeAra_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = um.getByName(uyeAra.Text.ToString());
            dataGridView1.DataSource=ds.Tables[0];  


        }
    }
}
