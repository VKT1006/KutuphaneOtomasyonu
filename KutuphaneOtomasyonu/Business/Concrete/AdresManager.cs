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
    internal class AdresManager : AdresService
    {
        IAdresDataAccess adresDataAccess = new AdresDataAccess();
        public void delete(Adres adres)
        {
            this.adresDataAccess.delete(adres);
        }

        public DataSet getAdres(int uyeId)
        {
            return this.adresDataAccess.getAdres(uyeId);
        }

        public DataSet getAll()
        {
            return this.adresDataAccess.getAll();
        }

        public DataSet getById(int id)
        {
            return this.adresDataAccess.getById(id);
        }

        public int getIdByAdres(string adres)
        {
            return this.adresDataAccess.getIdByAdres(adres);
        }

        public int getLastSavedId()
        {
            return this.adresDataAccess.getLastSavedId();            
        }

        public void save(Adres adres)
        {
            this.adresDataAccess.save(adres);
        }

        public void update(Adres adres)
        {
            this.adresDataAccess.update(adres);
        }

        

    }
}
