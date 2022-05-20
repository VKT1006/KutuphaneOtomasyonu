using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{
    internal class İletisimBilgileri
    {

        private int id { get; set; }
        private int uyeId { get; set; }
        private string telefon { get; set; }
        private string email { get; set; }

        public İletisimBilgileri() : this(0, 0, "Bilgi Yok", "Bilgi Yok")
        {

        }

        public İletisimBilgileri(int id, int uyeId, string telefon, string email)
        {
            this.id = id;
            this.uyeId = uyeId;
            this.telefon = telefon;
            this.email = email;
        }


    }
}
