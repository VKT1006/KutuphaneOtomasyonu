namespace KutuphaneOtomasyonu
{
    partial class Kullanici_kayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanici_adi_textBox = new System.Windows.Forms.TextBox();
            this.Parola_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // kullanici_adi_textBox
            // 
            this.kullanici_adi_textBox.Location = new System.Drawing.Point(173, 62);
            this.kullanici_adi_textBox.Name = "kullanici_adi_textBox";
            this.kullanici_adi_textBox.Size = new System.Drawing.Size(220, 23);
            this.kullanici_adi_textBox.TabIndex = 2;
            // 
            // Parola_textBox
            // 
            this.Parola_textBox.Location = new System.Drawing.Point(173, 104);
            this.Parola_textBox.Name = "Parola_textBox";
            this.Parola_textBox.Size = new System.Drawing.Size(220, 23);
            this.Parola_textBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Kullanıcı Girş Ekranına Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Kullanici_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(496, 341);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Parola_textBox);
            this.Controls.Add(this.kullanici_adi_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kullanici_kayit";
            this.Text = "Kullanici_kayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox kullanici_adi_textBox;
        private TextBox Parola_textBox;
        private Button button1;
        private Button button2;
    }
}