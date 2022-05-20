using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{

    internal class Yazar
    {

        private int id { get; set; }
        private string ad { get; set; }
        private string soyad { get; set; }
        private DateTime dogumTarihi { get; set; }
        private string aciklama { get; set; }


        public Yazar() : this(0, "Bilgi Yok", "Bilgi Yok", new DateTime(0,0,0), "Bilgi Yok")
        {
            
        }

        public Yazar(int id, string ad, string soyad, DateTime dogumTarihi, string aciklama)
        {
            this.id = id;
            this.ad = ad;   
            this.soyad = soyad; 
            this.dogumTarihi = dogumTarihi;
            this.aciklama = aciklama;
        }

    }
}
