using System.Data;
using KutuphaneOtomasyonu.Business.Concrete;
using MySql.Data.MySqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class Kullanici_giris : Form
    {
        public Kullanici_giris()
        {
            InitializeComponent();

            // Gizli bir �ekilde parola girmesini sa�lar. 
            Parola_textBox.Text = "";
            Parola_textBox.PasswordChar = '*';




        }

        private void Parola_textBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kullanici_kayit kullanici_Kayit = new Kullanici_kayit();    
            kullanici_Kayit.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            KullaniciManager kullaniciManager = new KullaniciManager();
            DataSet ds =  kullaniciManager.GetAll();

            

            if(ds != null)
            {

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    //Console.WriteLine(row[]);

                    if (row["kullanici_adi"].ToString() == kullanici_adi_textBox.Text && row["parola"].ToString() == Parola_textBox.Text)
                    {
                        MessageBox.Show("Giri� Ba�ar�l�!");
                        Ana_sayfa ana_Sayfa = new Ana_sayfa();
                        ana_Sayfa.Show();
                        this.Hide();
                        return;
                    }
                   
                }

                MessageBox.Show("Yanl�� giri� bilgileri! L�tfen Tekrar deneyiniz!");
                foreach (Control c in Controls) if (c is TextBox) c.Text = ""; // Formun Control s�n�f�na bakarken direkt controls yaz

               

            }
            else
            {
                MessageBox.Show("Kay�tl� Kullan�c� Yok!");
            }
            



        }
    }
}