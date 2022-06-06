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
    public partial class KitapGuncelle : Form
    {

        KitapManager km = new KitapManager();
        YazarManager ym = new YazarManager();
        int kitap_id = 0;
        public KitapGuncelle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana_sayfa ana_sayfa = new Ana_sayfa();
            ana_sayfa.Show();
            this.Hide();
        }

        private void KitapGuncelle_Load(object sender, EventArgs e)
        {
            tumKitaplariGoster();
            DataSet ds = ym.GetAll();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                comboBox1.Items.Add(row["Ad"].ToString());
            }
        }

        public void tumKitaplariGoster()
        {
            DataSet ds = km.getAll();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            kitap_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()); //--> isbn
            ISBN_textbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //--> isbn
            kitap_adi_textbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); //--> Kitap Adi
            sayfa_sayisi_textbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); //--> sayfa sayisi
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); //--> yazar Ad



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Kitap kitap = new Kitap(kitap_id,ym.GetIdByName(comboBox1.Text.ToString()),ISBN_textbox.Text.ToString(), kitap_adi_textbox.Text.ToString(), sayfa_sayisi_textbox.Text.ToString());
            km.update(kitap);
            MessageBox.Show("Seçilen Kitap Güncellendi!");
            dataGridView1.Refresh(); // Maybe it changes the content
            
        }
    }

}
