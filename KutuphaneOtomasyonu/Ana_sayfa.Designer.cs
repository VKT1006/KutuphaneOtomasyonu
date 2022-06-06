namespace KutuphaneOtomasyonu
{
    partial class Ana_sayfa
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
            this.kitap_ara_TextBox = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar_ara_textbox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEklToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçTeslimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümÜyeleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1099, 494);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kitap_ara_TextBox
            // 
            this.kitap_ara_TextBox.Location = new System.Drawing.Point(12, 40);
            this.kitap_ara_TextBox.Name = "kitap_ara_TextBox";
            this.kitap_ara_TextBox.PlaceholderText = "Kitap Ara";
            this.kitap_ara_TextBox.Size = new System.Drawing.Size(1099, 23);
            this.kitap_ara_TextBox.TabIndex = 5;
            this.kitap_ara_TextBox.TextChanged += new System.EventHandler(this.kitap_ara_TextBox_TextChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // yazar_ara_textbox
            // 
            this.yazar_ara_textbox.Location = new System.Drawing.Point(12, 82);
            this.yazar_ara_textbox.Name = "yazar_ara_textbox";
            this.yazar_ara_textbox.PlaceholderText = "Yazar Ara";
            this.yazar_ara_textbox.Size = new System.Drawing.Size(1099, 23);
            this.yazar_ara_textbox.TabIndex = 7;
            this.yazar_ara_textbox.TextChanged += new System.EventHandler(this.yazar_ara_textbox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapİşlemleriToolStripMenuItem,
            this.ödünçİşlemleriToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.üyeİşlemleriToolStripMenuItem,
            this.yazarİşlemleriToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1123, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            this.kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEklToolStripMenuItem,
            this.kitapSilToolStripMenuItem,
            this.kitapGüncelleToolStripMenuItem});
            this.kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            this.kitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // kitapEklToolStripMenuItem
            // 
            this.kitapEklToolStripMenuItem.Name = "kitapEklToolStripMenuItem";
            this.kitapEklToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.kitapEklToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEklToolStripMenuItem.Click += new System.EventHandler(this.kitapEklToolStripMenuItem_Click);
            // 
            // kitapSilToolStripMenuItem
            // 
            this.kitapSilToolStripMenuItem.Name = "kitapSilToolStripMenuItem";
            this.kitapSilToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.kitapSilToolStripMenuItem.Text = "Kitap Sil";
            this.kitapSilToolStripMenuItem.Click += new System.EventHandler(this.kitapSilToolStripMenuItem_Click);
            // 
            // kitapGüncelleToolStripMenuItem
            // 
            this.kitapGüncelleToolStripMenuItem.Name = "kitapGüncelleToolStripMenuItem";
            this.kitapGüncelleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.kitapGüncelleToolStripMenuItem.Text = "Kitap Güncelle";
            this.kitapGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kitapGüncelleToolStripMenuItem_Click);
            // 
            // ödünçİşlemleriToolStripMenuItem
            // 
            this.ödünçİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödünçVerToolStripMenuItem,
            this.ödünçTeslimToolStripMenuItem});
            this.ödünçİşlemleriToolStripMenuItem.Name = "ödünçİşlemleriToolStripMenuItem";
            this.ödünçİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.ödünçİşlemleriToolStripMenuItem.Text = "Ödünç İşlemleri";
            // 
            // ödünçVerToolStripMenuItem
            // 
            this.ödünçVerToolStripMenuItem.Name = "ödünçVerToolStripMenuItem";
            this.ödünçVerToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ödünçVerToolStripMenuItem.Text = "Ödünç Ver";
            // 
            // ödünçTeslimToolStripMenuItem
            // 
            this.ödünçTeslimToolStripMenuItem.Name = "ödünçTeslimToolStripMenuItem";
            this.ödünçTeslimToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ödünçTeslimToolStripMenuItem.Text = "Ödünç Teslim";
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıEkleToolStripMenuItem,
            this.kullanıcıSilToolStripMenuItem,
            this.kullanıcıGüncelleToolStripMenuItem});
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.kullanıcıEkleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEkleToolStripMenuItem_Click);
            // 
            // kullanıcıSilToolStripMenuItem
            // 
            this.kullanıcıSilToolStripMenuItem.Name = "kullanıcıSilToolStripMenuItem";
            this.kullanıcıSilToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kullanıcıSilToolStripMenuItem.Text = "Kullanıcı Sil";
            this.kullanıcıSilToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıSilToolStripMenuItem_Click);
            // 
            // kullanıcıGüncelleToolStripMenuItem
            // 
            this.kullanıcıGüncelleToolStripMenuItem.Name = "kullanıcıGüncelleToolStripMenuItem";
            this.kullanıcıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kullanıcıGüncelleToolStripMenuItem.Text = "Kullanıcı Güncelle";
            this.kullanıcıGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıGüncelleToolStripMenuItem_Click);
            // 
            // üyeİşlemleriToolStripMenuItem
            // 
            this.üyeİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümÜyeleriGörüntüleToolStripMenuItem,
            this.üyeEkleToolStripMenuItem,
            this.üyeSilToolStripMenuItem,
            this.üyeGüncelleToolStripMenuItem});
            this.üyeİşlemleriToolStripMenuItem.Name = "üyeİşlemleriToolStripMenuItem";
            this.üyeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.üyeİşlemleriToolStripMenuItem.Text = "Üye İşlemleri";
            // 
            // tümÜyeleriGörüntüleToolStripMenuItem
            // 
            this.tümÜyeleriGörüntüleToolStripMenuItem.Name = "tümÜyeleriGörüntüleToolStripMenuItem";
            this.tümÜyeleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.tümÜyeleriGörüntüleToolStripMenuItem.Text = "Tüm Üyeleri Görüntüle";
            this.tümÜyeleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.tümÜyeleriGörüntüleToolStripMenuItem_Click);
            // 
            // üyeEkleToolStripMenuItem
            // 
            this.üyeEkleToolStripMenuItem.Name = "üyeEkleToolStripMenuItem";
            this.üyeEkleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.üyeEkleToolStripMenuItem.Text = "Üye Ekle";
            this.üyeEkleToolStripMenuItem.Click += new System.EventHandler(this.üyeEkleToolStripMenuItem_Click);
            // 
            // üyeSilToolStripMenuItem
            // 
            this.üyeSilToolStripMenuItem.Name = "üyeSilToolStripMenuItem";
            this.üyeSilToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.üyeSilToolStripMenuItem.Text = "Üye Sil";
            this.üyeSilToolStripMenuItem.Click += new System.EventHandler(this.üyeSilToolStripMenuItem_Click);
            // 
            // üyeGüncelleToolStripMenuItem
            // 
            this.üyeGüncelleToolStripMenuItem.Name = "üyeGüncelleToolStripMenuItem";
            this.üyeGüncelleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.üyeGüncelleToolStripMenuItem.Text = "Üye Güncelle";
            this.üyeGüncelleToolStripMenuItem.Click += new System.EventHandler(this.üyeGüncelleToolStripMenuItem_Click);
            // 
            // yazarİşlemleriToolStripMenuItem
            // 
            this.yazarİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazarEkleToolStripMenuItem,
            this.yazarSilToolStripMenuItem,
            this.yazarGüncelleToolStripMenuItem});
            this.yazarİşlemleriToolStripMenuItem.Name = "yazarİşlemleriToolStripMenuItem";
            this.yazarİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.yazarİşlemleriToolStripMenuItem.Text = "Yazar İşlemleri";
            // 
            // yazarEkleToolStripMenuItem
            // 
            this.yazarEkleToolStripMenuItem.Name = "yazarEkleToolStripMenuItem";
            this.yazarEkleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.yazarEkleToolStripMenuItem.Text = "Yazar Ekle";
            this.yazarEkleToolStripMenuItem.Click += new System.EventHandler(this.yazarEkleToolStripMenuItem_Click);
            // 
            // yazarSilToolStripMenuItem
            // 
            this.yazarSilToolStripMenuItem.Name = "yazarSilToolStripMenuItem";
            this.yazarSilToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.yazarSilToolStripMenuItem.Text = "Yazar Sil";
            this.yazarSilToolStripMenuItem.Click += new System.EventHandler(this.yazarSilToolStripMenuItem_Click);
            // 
            // yazarGüncelleToolStripMenuItem
            // 
            this.yazarGüncelleToolStripMenuItem.Name = "yazarGüncelleToolStripMenuItem";
            this.yazarGüncelleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.yazarGüncelleToolStripMenuItem.Text = "Yazar Güncelle";
            this.yazarGüncelleToolStripMenuItem.Click += new System.EventHandler(this.yazarGüncelleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Ana_sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1123, 638);
            this.ControlBox = false;
            this.Controls.Add(this.yazar_ara_textbox);
            this.Controls.Add(this.kitap_ara_TextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Ana_sayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Ana_sayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox kitap_ara_TextBox;
        private DataGridViewTextBoxColumn Id;
        private TextBox yazar_ara_textbox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private ToolStripMenuItem kitapEklToolStripMenuItem;
        private ToolStripMenuItem kitapSilToolStripMenuItem;
        private ToolStripMenuItem kitapGüncelleToolStripMenuItem;
        private ToolStripMenuItem ödünçİşlemleriToolStripMenuItem;
        private ToolStripMenuItem ödünçVerToolStripMenuItem;
        private ToolStripMenuItem ödünçTeslimToolStripMenuItem;
        private ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private ToolStripMenuItem kullanıcıSilToolStripMenuItem;
        private ToolStripMenuItem kullanıcıGüncelleToolStripMenuItem;
        private ToolStripMenuItem üyeİşlemleriToolStripMenuItem;
        private ToolStripMenuItem üyeEkleToolStripMenuItem;
        private ToolStripMenuItem üyeSilToolStripMenuItem;
        private ToolStripMenuItem üyeGüncelleToolStripMenuItem;
        private ToolStripMenuItem yazarİşlemleriToolStripMenuItem;
        private ToolStripMenuItem yazarEkleToolStripMenuItem;
        private ToolStripMenuItem yazarSilToolStripMenuItem;
        private ToolStripMenuItem yazarGüncelleToolStripMenuItem;
        private ToolStripMenuItem tümÜyeleriGörüntüleToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
    }
}