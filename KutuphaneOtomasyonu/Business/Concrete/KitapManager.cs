using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu.Business.Abstract;
using KutuphaneOtomasyonu.DataAccess.Concrete;

namespace KutuphaneOtomasyonu.Business.Concrete
{
    internal class KitapManager : KitapService
    {

        KitapDataAccess kitapDao;

        public KitapManager(KitapDataAccess kitapDao)
        {
            this.kitapDao = kitapDao;
        }


        public void delete(Kitap kitap)
        {
            throw new NotImplementedException();
        }

        public Kitap get(Kitap kitap)
        {
            throw new NotImplementedException();
        }

        public List<Kitap> getAll()
        {
            throw new NotImplementedException();
        }

        public Kitap getById(int id)
        {
            throw new NotImplementedException();
        }

        public Kitap getByISBN(string isbn)
        {
            throw new NotImplementedException();
        }

        public List<Kitap> getByName(string name)
        {
            throw new NotImplementedException();
        }

        public void save(Kitap kitap)
        {
            throw new NotImplementedException();
        }

        public void update(Kitap kitap)
        {
            throw new NotImplementedException();
        }
    }
}
