namespace KutuphaneOtomasyonu.UI.Kullanici_UI
{
    partial class KullaniciGuncelle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullanici_ara_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // kullanici_adi_textbox
            // 
            this.kullanici_adi_textbox.Location = new System.Drawing.Point(133, 33);
            this.kullanici_adi_textbox.Name = "kullanici_adi_textbox";
            this.kullanici_adi_textbox.Size = new System.Drawing.Size(369, 23);
            this.kullanici_adi_textbox.TabIndex = 2;
            // 
            // parola_textbox
            // 
            this.parola_textbox.Location = new System.Drawing.Point(133, 62);
            this.parola_textbox.Name = "parola_textbox";
            this.parola_textbox.Size = new System.Drawing.Size(369, 23);
            this.parola_textbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ana Menüye Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 322);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // kullanici_ara_textbox
            // 
            this.kullanici_ara_textbox.Location = new System.Drawing.Point(12, 120);
            this.kullanici_ara_textbox.Name = "kullanici_ara_textbox";
            this.kullanici_ara_textbox.PlaceholderText = "Kullanıcı Ara";
            this.kullanici_ara_textbox.Size = new System.Drawing.Size(776, 23);
            this.kullanici_ara_textbox.TabIndex = 7;
            this.kullanici_ara_textbox.TextChanged += new System.EventHandler(this.kullanici_ara_textbox_TextChanged);
            // 
            // KullaniciGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.kullanici_ara_textbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.parola_textbox);
            this.Controls.Add(this.kullanici_adi_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciGuncelle";
            this.Text = "KullaniciGuncelle";
            this.Load += new System.EventHandler(this.KullaniciGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private DataGridView dataGridView1;
        private TextBox kullanici_ara_textbox;
    }
}