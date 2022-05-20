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
    internal class OduncManager : OduncService
    {

        IOduncDataAccess OduncDao;

        public OduncManager(IOduncDataAccess OduncDao)
        {
            this.OduncDao = OduncDao;
        }


        public void delete(Odunc odunc)
        {
            throw new NotImplementedException();
        }

        public List<Odunc> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Odunc> GetByBookId(int bookID)
        {
            throw new NotImplementedException();
        }

        public List<Odunc> GetByBookISBN(int ISBN)
        {
            throw new NotImplementedException();
        }

        public List<Odunc> GetByUser(int userId)
        {
            throw new NotImplementedException();
        }

        public void save(Odunc odunc)
        {
            throw new NotImplementedException();
        }

        public void update(Odunc odunc)
        {
            throw new NotImplementedException();
        }
    }
}
