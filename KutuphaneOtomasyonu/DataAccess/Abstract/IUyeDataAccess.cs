using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.DataAccess.Abstract
{
    internal interface IUyeDataAccess
    {
        void save(Uye uye);
        void update(Uye uye);
        void delete(Uye uye);
        DataSet get(Uye uye);
        DataSet getAll();
        DataSet getByName(String name);
        int getLastSavedId();
        int getIdByName(string name);
    }
}
