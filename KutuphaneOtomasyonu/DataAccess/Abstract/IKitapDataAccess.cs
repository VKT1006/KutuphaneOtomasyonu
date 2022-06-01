using System;
using System.Collections.Generic;
using System.Data;
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

        DataSet getAll();
        DataSet get(Kitap kitap);
        DataSet getById(int id);
        DataSet getByName(String name);
        DataSet getByISBN(String isbn);
    }
}
