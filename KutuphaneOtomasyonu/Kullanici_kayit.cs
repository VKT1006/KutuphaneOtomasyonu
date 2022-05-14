using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            String server = "localhost";
            String db = "kutuphane_otomasyon";
            String username = "root";
            String password = "";
            String conString = "SERVER=" + server + ";" + "DATABASE=" + db + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(conString);


            MySqlCommand cmd = null;
            string cmdString = "";
            conn.Open();

            cmdString = "insert into kullanicilar(kullanici_ad,kullanici_parola) values('" + kullanici_adi_textBox.Text + "','" + Parola_textBox.Text + "')";

            cmd = new MySqlCommand(cmdString, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Başarılı Bir Şekilde Kayıt Olundu!");

        }
    }
}
