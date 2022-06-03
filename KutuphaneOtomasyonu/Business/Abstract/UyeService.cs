using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu.DataAccess.Abstract;

namespace KutuphaneOtomasyonu.Business.Abstract
{
    internal interface UyeService
    {
        void save(Uye uye);
        void update(Uye uye);
        void delete(Uye uye);
        DataSet get(Uye uye);
        DataSet getAll();
        DataSet getByName(String name);
    }
}
