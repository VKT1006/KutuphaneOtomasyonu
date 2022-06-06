using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{
    internal class İletisimBilgileri
    {

        public int id { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }

        public İletisimBilgileri() : this(0, "Bilgi Yok", "Bilgi Yok")
        {

        }

        public İletisimBilgileri(int id, string telefon, string email)
        {
            this.id = id;
            this.telefon = telefon;
            this.email = email;
        }


    }
}
