using MySql.Data.MySqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class Kullanici_giris : Form
    {
        public Kullanici_giris()
        {
            InitializeComponent();

            // Gizli bir þekilde parola girmesini saðlar. 
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

            String server = "localhost";
            String db = "kutuphane_otomasyon";
            String username = "root";
            String password = "";
            String conString = "SERVER=" + server + ";" + "DATABASE=" + db+";" + 
                "UID=" + username + ";"+"PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(conString);

            conn.Open();
            String query = "select * from kullanicilar";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["kullanici_id"]);
                Console.WriteLine(reader["kullanici_ad"]);
                Console.WriteLine(reader["kullanici_parola"]);
            }

            

        }
    }
}