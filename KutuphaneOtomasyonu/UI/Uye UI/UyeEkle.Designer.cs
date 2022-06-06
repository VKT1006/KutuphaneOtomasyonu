namespace KutuphaneOtomasyonu.UI.Uye_UI
{
    partial class UyeEkle
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ad_textbox = new System.Windows.Forms.TextBox();
            this.soyad_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.telefon_textbox = new System.Windows.Forms.TextBox();
            this.adres_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres";
            // 
            // ad_textbox
            // 
            this.ad_textbox.Location = new System.Drawing.Point(123, 31);
            this.ad_textbox.Name = "ad_textbox";
            this.ad_textbox.Size = new System.Drawing.Size(297, 23);
            this.ad_textbox.TabIndex = 5;
            // 
            // soyad_textbox
            // 
            this.soyad_textbox.Location = new System.Drawing.Point(123, 60);
            this.soyad_textbox.Name = "soyad_textbox";
            this.soyad_textbox.Size = new System.Drawing.Size(297, 23);
            this.soyad_textbox.TabIndex = 6;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(123, 89);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(297, 23);
            this.email_textbox.TabIndex = 7;
            // 
            // telefon_textbox
            // 
            this.telefon_textbox.Location = new System.Drawing.Point(123, 118);
            this.telefon_textbox.Name = "telefon_textbox";
            this.telefon_textbox.Size = new System.Drawing.Size(297, 23);
            this.telefon_textbox.TabIndex = 8;
            // 
            // adres_textbox
            // 
            this.adres_textbox.Location = new System.Drawing.Point(123, 147);
            this.adres_textbox.Multiline = true;
            this.adres_textbox.Name = "adres_textbox";
            this.adres_textbox.Size = new System.Drawing.Size(297, 139);
            this.adres_textbox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ana Menüye Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 322);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adres_textbox);
            this.Controls.Add(this.telefon_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.soyad_textbox);
            this.Controls.Add(this.ad_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UyeEkle";
            this.Text = "Üye Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ad_textbox;
        private TextBox soyad_textbox;
        private TextBox email_textbox;
        private TextBox telefon_textbox;
        private TextBox adres_textbox;
        private Button button1;
        private Button button2;
    }
}