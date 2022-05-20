using System;
using System.Collections.Generic;
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

        IKullaniciDataAccess KullaniciDao;


        public KullaniciManager(IKullaniciDataAccess KullaniciDao)
        {
            this.KullaniciDao = KullaniciDao;
        }


        public void delete(Kullanici kullanici)
        {
            throw new NotImplementedException();
        }

        public Kullanici get(Kullanici kullanici)
        {
            throw new NotImplementedException();
        }

        public List<Kullanici> GetAll()
        {
            throw new NotImplementedException();
        }

        public Kullanici getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Kullanici> getByName(string name)
        {
            throw new NotImplementedException();
        }

        public void save(Kullanici kullanici)
        {
            throw new NotImplementedException();
        }

        public void update(Kullanici kullanici)
        {
            throw new NotImplementedException();
        }
    }
}
