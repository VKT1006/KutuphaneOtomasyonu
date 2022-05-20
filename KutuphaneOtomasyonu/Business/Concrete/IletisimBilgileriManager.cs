using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu.Business.Abstract;
using KutuphaneOtomasyonu.DataAccess.Abstract;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.Business.Concrete
{
    internal class IletisimBilgileriManager : IletisimBilgileriService
    {


        IIletisimBilgileriDataAccess iletisimBilgileriDao;


        public IletisimBilgileriManager(IIletisimBilgileriDataAccess iletisimBilgileriDao)
        {
            this.iletisimBilgileriDao = iletisimBilgileriDao;
        }


        public void delete(İletisimBilgileri iletisimBilgileri)
        {
            throw new NotImplementedException();
        }

        public List<İletisimBilgileri> getAll()
        {
            throw new NotImplementedException();
        }

        public List<İletisimBilgileri> getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<İletisimBilgileri> getByUyeId(int uyeId)
        {
            throw new NotImplementedException();
        }

        public void save(İletisimBilgileri iletisimBilgileri)
        {
            throw new NotImplementedException();
        }

        public void update(İletisimBilgileri iletisimBilgileri)
        {
            throw new NotImplementedException();
        }
    }
}
