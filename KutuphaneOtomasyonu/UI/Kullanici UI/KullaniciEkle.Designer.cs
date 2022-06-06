namespace KutuphaneOtomasyonu.UI.Kullanici_UI
{
    partial class KullaniciEkle
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
            this.kullanici_adi_textbox = new System.Windows.Forms.TextBox();
            this.parola_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // kullanici_adi_textbox
            // 
            this.kullanici_adi_textbox.Location = new System.Drawing.Point(184, 44);
            this.kullanici_adi_textbox.Name = "kullanici_adi_textbox";
            this.kullanici_adi_textbox.Size = new System.Drawing.Size(207, 23);
            this.kullanici_adi_textbox.TabIndex = 2;
            // 
            // parola_textbox
            // 
            this.parola_textbox.Location = new System.Drawing.Point(184, 83);
            this.parola_textbox.Name = "parola_textbox";
            this.parola_textbox.Size = new System.Drawing.Size(207, 23);
            this.parola_textbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ana Menüye Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 292);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.parola_textbox);
            this.Controls.Add(this.kullanici_adi_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciEkle";
            this.Text = "KullaniciEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox kullanici_adi_textbox;
        private TextBox parola_textbox;
        private Button button1;
        private Button button2;
    }
}