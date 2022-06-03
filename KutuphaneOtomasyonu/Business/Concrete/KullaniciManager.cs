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
    internal class KullaniciManager : KullaniciService
    {

        IKullaniciDataAccess kullaniciAccess = new KullaniciDataAccess();

        public void delete(Kullanici kullanici)
        {
            kullaniciAccess.delete(kullanici);
        }

        public DataSet get(Kullanici kullanici)
        {
            return kullaniciAccess.get(kullanici);
        }

        public DataSet GetAll()
        {
            return kullaniciAccess.GetAll();            
        }

        public DataSet getById(int id)
        {
            return kullaniciAccess.getById(id);
        }

        public DataSet getByName(string name)
        {
            return kullaniciAccess.getByName(name);
        }

        public void save(Kullanici kullanici)
        {
            kullaniciAccess.save(kullanici);
        }

        public void update(Kullanici kullanici)
        {
            kullaniciAccess.update(kullanici);
        }
    }
}
