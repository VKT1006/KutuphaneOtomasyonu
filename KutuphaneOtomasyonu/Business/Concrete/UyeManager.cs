using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu.Business.Abstract;
using KutuphaneOtomasyonu.DataAccess.Abstract;

namespace KutuphaneOtomasyonu.Business.Concrete
{
    internal class UyeManager : UyeService
    {

        IUyeDataAccess UyeDao;

        public UyeManager(IUyeDataAccess UyeDao)
        {
            this.UyeDao = UyeDao;
        }

        public void delete(IUyeDataAccess uye)
        {
            throw new NotImplementedException();
        }

        public List<IUyeDataAccess> get(IUyeDataAccess uye)
        {
            throw new NotImplementedException();
        }

        public List<IUyeDataAccess> getAll()
        {
            throw new NotImplementedException();
        }

        public List<IUyeDataAccess> getByName(string name)
        {
            throw new NotImplementedException();
        }

        public void save(IUyeDataAccess uye)
        {
            throw new NotImplementedException();
        }

        public void update(IUyeDataAccess uye)
        {
            throw new NotImplementedException();
        }
    }
}
