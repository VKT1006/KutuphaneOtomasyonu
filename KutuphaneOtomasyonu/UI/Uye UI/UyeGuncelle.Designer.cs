namespace KutuphaneOtomasyonu.UI.Uye_UI
{
    partial class UyeGuncelle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.uye_ara_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 482);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // ad_textbox
            // 
            this.ad_textbox.Location = new System.Drawing.Point(103, 25);
            this.ad_textbox.Name = "ad_textbox";
            this.ad_textbox.Size = new System.Drawing.Size(627, 23);
            this.ad_textbox.TabIndex = 6;
            // 
            // soyad_textbox
            // 
            this.soyad_textbox.Location = new System.Drawing.Point(103, 54);
            this.soyad_textbox.Name = "soyad_textbox";
            this.soyad_textbox.Size = new System.Drawing.Size(627, 23);
            this.soyad_textbox.TabIndex = 7;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(103, 83);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(627, 23);
            this.email_textbox.TabIndex = 8;
            // 
            // telefon_textbox
            // 
            this.telefon_textbox.Location = new System.Drawing.Point(103, 112);
            this.telefon_textbox.Name = "telefon_textbox";
            this.telefon_textbox.Size = new System.Drawing.Size(627, 23);
            this.telefon_textbox.TabIndex = 9;
            // 
            // adres_textbox
            // 
            this.adres_textbox.Location = new System.Drawing.Point(103, 141);
            this.adres_textbox.Multiline = true;
            this.adres_textbox.Name = "adres_textbox";
            this.adres_textbox.Size = new System.Drawing.Size(627, 67);
            this.adres_textbox.TabIndex = 10;
            // 
            // uye_ara_textbox
            // 
            this.uye_ara_textbox.Location = new System.Drawing.Point(12, 242);
            this.uye_ara_textbox.Name = "uye_ara_textbox";
            this.uye_ara_textbox.PlaceholderText = "Üye Ara";
            this.uye_ara_textbox.Size = new System.Drawing.Size(1044, 23);
            this.uye_ara_textbox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(804, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ana Menüye Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UyeGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 765);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uye_ara_textbox);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "UyeGuncelle";
            this.Text = "Üye Güncelle";
            this.Load += new System.EventHandler(this.UyeGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
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
        private TextBox uye_ara_textbox;
        private Button button1;
        private Button button2;
    }
}