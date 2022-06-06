using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.Business.Abstract
{
    internal interface YazarService
    {
        void save(Yazar yazar);
        void delete(Yazar yazar);
        void update(Yazar yazar);
        DataSet GetAll();
        DataSet GetByName(String name);
        DataSet GetById(int id);
        int GetIdByName(string nane);
    }
}
