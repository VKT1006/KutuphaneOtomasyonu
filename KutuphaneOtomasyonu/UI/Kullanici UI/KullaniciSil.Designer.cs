namespace KutuphaneOtomasyonu.UI.Kullanici_UI
{
    partial class KullaniciSil
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
            this.kullanici_ara_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(865, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // kullanici_ara_textbox
            // 
            this.kullanici_ara_textbox.Location = new System.Drawing.Point(12, 35);
            this.kullanici_ara_textbox.Name = "kullanici_ara_textbox";
            this.kullanici_ara_textbox.PlaceholderText = "Kullanıcı Ara";
            this.kullanici_ara_textbox.Size = new System.Drawing.Size(491, 23);
            this.kullanici_ara_textbox.TabIndex = 1;
            this.kullanici_ara_textbox.TextChanged += new System.EventHandler(this.kullanici_ara_textbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kullanıcı Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ana Menüye Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KullaniciSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 425);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kullanici_ara_textbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KullaniciSil";
            this.Text = "KullaniciSil";
            this.Load += new System.EventHandler(this.KullaniciSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox kullanici_ara_textbox;
        private Button button1;
        private Button button2;
    }
}