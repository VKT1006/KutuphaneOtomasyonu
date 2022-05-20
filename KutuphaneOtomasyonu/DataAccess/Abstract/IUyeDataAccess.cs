using System;
using System.Collections.Generic;
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
        List<IUyeDataAccess> get(IUyeDataAccess uye);
        List<IUyeDataAccess> getAll();
        List<IUyeDataAccess> getByName(String name);

    }
}
