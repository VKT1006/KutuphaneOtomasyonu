using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{
    internal class Odunc
    {
        public int id { get; set; }
        public int kullaniciId { get; set; }
        public int kitapId { get; set; }
        public DateTime tarih { get; set; }
        public DateTime teslimTarihi {  get; set; }

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
