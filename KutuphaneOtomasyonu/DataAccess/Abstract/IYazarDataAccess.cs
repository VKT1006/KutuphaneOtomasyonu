using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.DataAccess.Abstract
{
    internal interface IYazarDataAccess
    {

        void save(Yazar yazar);
        void delete(Yazar yazar);
        void update(Yazar yazar);
        List<Yazar> GetAll();
        List<Yazar> GetByName(String name);
        List<Yazar> GetById(int id);


    }
}
