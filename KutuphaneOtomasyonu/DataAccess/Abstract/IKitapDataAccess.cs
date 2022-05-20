using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.DataAccess.Abstract
{
    internal interface IKitapDataAccess
    {
        void save(Kitap kitap);

        void update(Kitap kitap);

        void delete(Kitap kitap);

        List<Kitap> getAll();
        Kitap get(Kitap kitap);
        Kitap getById(int id);
        List<Kitap> getByName(String name);
        Kitap getByISBN(String isbn);
    }
}
