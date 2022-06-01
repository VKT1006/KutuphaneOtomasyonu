using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Business.Abstract
{
    internal interface KullaniciService
    {
        void save(Kullanici kullanici);
        void delete(Kullanici kullanici);
        void update(Kullanici kullanici);
        DataSet GetAll();
        DataSet get(Kullanici kullanici);
        DataSet getByName(String name);
        DataSet getById(int id);
    }
}
