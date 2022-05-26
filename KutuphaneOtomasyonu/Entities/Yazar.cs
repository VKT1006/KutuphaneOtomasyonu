using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{

    internal class Yazar
    {

        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string aciklama { get; set; }


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
