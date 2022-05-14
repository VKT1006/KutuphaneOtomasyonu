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
    }
}