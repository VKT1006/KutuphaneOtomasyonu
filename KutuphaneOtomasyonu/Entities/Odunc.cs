using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{
    internal class Odunc
    {
        private int id { get; set; }
        private int kullaniciId { get; set; }
        private int kitapId { get; set; }
        private DateTime tarih { get; set; }
        private DateTime teslimTarihi {  get; set; }

        public Odunc() : this(0,0,0,new DateTime(0,0,0), new DateTime(0,0,0))
        {

        }

        public Odunc(int id, int kullaniciId, int kitapId, DateTime tarih, DateTime teslimTarihi)
        {
            this.id = id;
            this.kullaniciId = kullaniciId;
            this.kitapId = kitapId;
            this.tarih = tarih;
            this.teslimTarihi = teslimTarihi;
        }


    }
}
