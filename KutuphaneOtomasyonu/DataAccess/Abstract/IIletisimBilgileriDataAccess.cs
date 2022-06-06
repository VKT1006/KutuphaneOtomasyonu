using System;
using System.Collections.Generic;
using System.Data;
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
        DataSet getAll();
        DataSet getById(int id);
        DataSet getByUyeId(int uyeId);
        int getLastSavedId();
        int getIdByEmail(string email);

    }
}
