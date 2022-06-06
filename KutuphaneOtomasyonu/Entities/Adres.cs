using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entities
{
    internal class Adres
    {
        public int id { get; set; }
        public string adres { get; set; }

        public Adres(): this(0, "Bilgi Yok")
        {

        }

        public Adres (int id, string adres){

            this.id = id;
            this.adres = adres;

        }


    }



}
