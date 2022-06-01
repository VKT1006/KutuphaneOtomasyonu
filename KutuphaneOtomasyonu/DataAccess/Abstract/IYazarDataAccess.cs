using System;
using System.Collections.Generic;
using System.Data;
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
        DataSet GetAll();
        DataSet GetByName(String name);
        DataSet GetById(int id);


    }
}
