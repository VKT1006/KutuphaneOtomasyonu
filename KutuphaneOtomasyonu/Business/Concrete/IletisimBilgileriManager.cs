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
    internal class IletisimBilgileriManager : IletisimBilgileriService
    {

        IIletisimBilgileriDataAccess iletisimBilgileriDataAccess = new IletisimBilgileriDataAccess();

        public void delete(İletisimBilgileri iletisimBilgileri)
        {
            iletisimBilgileriDataAccess.delete(iletisimBilgileri);
        }

        public DataSet getAll()
        {
            return iletisimBilgileriDataAccess.getAll();
        }

        public DataSet getById(int id)
        {
            return iletisimBilgileriDataAccess.getById(id);
        }

        public DataSet getByUyeId(int uyeId)
        {
            return iletisimBilgileriDataAccess.getByUyeId(uyeId);
        }

        public int getIdByEmail(string email)
        {
            return this.iletisimBilgileriDataAccess.getIdByEmail(email);
        }

        public int getLastSavedId()
        {
            return this.iletisimBilgileriDataAccess.getLastSavedId();
        }

        public void save(İletisimBilgileri iletisimBilgileri)
        {
            iletisimBilgileriDataAccess.save(iletisimBilgileri);    
        }

        public void update(İletisimBilgileri iletisimBilgileri)
        {
            iletisimBilgileriDataAccess.update(iletisimBilgileri);
        }

        

    }
}
