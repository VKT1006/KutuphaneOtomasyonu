using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu.Business.Abstract;
using KutuphaneOtomasyonu.DataAccess.Abstract;
using KutuphaneOtomasyonu.DataAccess.Concrete;

namespace KutuphaneOtomasyonu.Business.Concrete
{
    internal class KitapManager : KitapService
    {

        IKitapDataAccess kitapDataAccess = new KitapDataAccess();

        public void delete(Kitap kitap)
        {
            kitapDataAccess.delete(kitap);  
        }

        public DataSet get(Kitap kitap)
        {
            return kitapDataAccess.get(kitap);
        }

        public DataSet getAll()
        {
            return kitapDataAccess.getAll();
        }

        public DataSet getById(int id)
        {
            return kitapDataAccess.getById(id);
        }

        public DataSet getByISBN(string isbn)
        {
            return kitapDataAccess.getByISBN(isbn);
        }

        public DataSet getByName(string name)
        {
            return kitapDataAccess.getByName(name);
        }

        public void save(Kitap kitap)
        {
            kitapDataAccess.save(kitap);
        }

        public void update(Kitap kitap)
        {
            kitapDataAccess.update(kitap);
        }
    }
}
