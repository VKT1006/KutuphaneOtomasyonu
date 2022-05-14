namespace KutuphaneOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanici_adi_textBox = new System.Windows.Forms.TextBox();
            this.Parola_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // kullanici_adi_textBox
            // 
            this.kullanici_adi_textBox.Location = new System.Drawing.Point(213, 55);
            this.kullanici_adi_textBox.Name = "kullanici_adi_textBox";
            this.kullanici_adi_textBox.Size = new System.Drawing.Size(166, 23);
            this.kullanici_adi_textBox.TabIndex = 2;
            // 
            // Parola_textBox
            // 
            this.Parola_textBox.Location = new System.Drawing.Point(213, 93);
            this.Parola_textBox.Name = "Parola_textBox";
            this.Parola_textBox.Size = new System.Drawing.Size(166, 23);
            this.Parola_textBox.TabIndex = 3;
            this.Parola_textBox.TextChanged += new System.EventHandler(this.Parola_textBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 390);
            this.Controls.Add(this.Parola_textBox);
            this.Controls.Add(this.kullanici_adi_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox kullanici_adi_textBox;
        private TextBox Parola_textBox;
    }
}