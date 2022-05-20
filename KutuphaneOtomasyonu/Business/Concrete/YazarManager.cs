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
    internal class YazarManager : YazarService
    {

        IYazarDataAccess YazarDao;

        public YazarManager(IYazarDataAccess YazarDao)
        {
            this.YazarDao = YazarDao;
        }

        public void delete(Yazar yazar)
        {
            throw new NotImplementedException();
        }

        public List<Yazar> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Yazar> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Yazar> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void save(Yazar yazar)
        {
            throw new NotImplementedException();
        }

        public void update(Yazar yazar)
        {
            throw new NotImplementedException();
        }
    }
}
