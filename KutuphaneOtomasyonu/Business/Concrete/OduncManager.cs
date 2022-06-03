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
    internal class OduncManager : OduncService
    {

        IOduncDataAccess oduncDataAccess = new OduncDataAccess();
        public void delete(Odunc odunc)
        {
            oduncDataAccess.delete(odunc);
        }

        public DataSet GetAll()
        {
            return oduncDataAccess.GetAll();
        }

        public DataSet GetByBookId(int bookID)
        {
            return oduncDataAccess.GetByBookId(bookID);
        }

        public DataSet GetByBookISBN(int ISBN)
        {
            return oduncDataAccess.GetByBookISBN(ISBN);
        }

        public DataSet GetByUser(int userId)
        {
            return oduncDataAccess.GetByUser(userId);
        }

        public void save(Odunc odunc)
        {
            oduncDataAccess.save(odunc);
        }

        public void update(Odunc odunc)
        {
            oduncDataAccess.update(odunc);
        }
    }
}
