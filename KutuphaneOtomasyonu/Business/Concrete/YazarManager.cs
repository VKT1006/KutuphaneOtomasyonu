using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu.Business.Abstract;
using KutuphaneOtomasyonu.DataAccess.Abstract;
using KutuphaneOtomasyonu.DataAccess.Concrete;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.Business.Concrete
{
    internal class YazarManager : YazarService
    {

        IYazarDataAccess yazarDataAccess = new YazarDataAccess();

        public void delete(Yazar yazar)
        {
            yazarDataAccess.delete(yazar);
        }

        public DataSet GetAll()
        {
            return yazarDataAccess.GetAll();
        }

        public DataSet GetById(int id)
        {
            return yazarDataAccess.GetById(id);
        }

        public DataSet GetByName(string name)
        {
            return yazarDataAccess.GetByName(name);
        }

        public void save(Yazar yazar)
        {
            yazarDataAccess.save(yazar);    
        }

        public void update(Yazar yazar)
        {
            yazarDataAccess.update(yazar);
        }

        public int GetIdByName(string ad)
        {
            return yazarDataAccess.GetIdByName(ad);
        }
    }
}
