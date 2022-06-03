using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu.Business.Abstract;
using KutuphaneOtomasyonu.DataAccess.Abstract;
using KutuphaneOtomasyonu.DataAccess.Concrete;

namespace KutuphaneOtomasyonu.Business.Concrete
{
    internal class UyeManager : UyeService
    {

        IUyeDataAccess uyeDataAccess = new UyeDataAccess();

        public void delete(Uye uye)
        {
            uyeDataAccess.delete(uye);
        }

        public DataSet get(Uye uye)
        {
            return uyeDataAccess.get(uye);
        }

        public DataSet getAll()
        {
            return uyeDataAccess.getAll();
        }

        public DataSet getByName(string name)
        {
            return uyeDataAccess.getByName(name);
        }

        public void save(Uye uye)
        {
            uyeDataAccess.save(uye);
        }

        public void update(Uye uye)
        {
            uyeDataAccess.update(uye);
        }
    }
}
