namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gizli bir �ekilde parola girmesini sa�lar. 
            Parola_textBox.Text = "";
            Parola_textBox.PasswordChar = '*';




        }

        private void Parola_textBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}