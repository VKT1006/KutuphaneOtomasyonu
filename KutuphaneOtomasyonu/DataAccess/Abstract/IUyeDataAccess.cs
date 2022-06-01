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
        void save(IUyeDataAccess uye);
        void update(IUyeDataAccess uye);
        void delete(IUyeDataAccess uye);
        DataSet get(IUyeDataAccess uye);
        DataSet getAll();
        DataSet getByName(String name);

    }
}
