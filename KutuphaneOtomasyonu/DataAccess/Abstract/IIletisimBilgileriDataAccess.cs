using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.DataAccess.Abstract
{
    internal interface IIletisimBilgileriDataAccess
    {

        void save(İletisimBilgileri iletisimBilgileri);
        void delete(İletisimBilgileri iletisimBilgileri);
        void update(İletisimBilgileri iletisimBilgileri);
        List<İletisimBilgileri> getAll();
        List<İletisimBilgileri> getById(int id);
        List<İletisimBilgileri> getByUyeId(int uyeId);



    }
}
