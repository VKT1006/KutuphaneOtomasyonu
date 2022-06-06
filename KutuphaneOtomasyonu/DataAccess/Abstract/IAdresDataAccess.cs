using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.DataAccess.Abstract
{
    internal interface IAdresDataAccess
    {
        void save(Adres adres);
        void delete(Adres adres);
        void update(Adres adres);
        DataSet getAll();
        DataSet getById(int id);
        DataSet getAdres(int uyeId);
        public int getLastSavedId();
        int getIdByAdres(string adres);
    }
}
