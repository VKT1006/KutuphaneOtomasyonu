using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.DataAccess.Abstract
{
    internal interface IOduncDataAccess
    {

        void save(Odunc odunc);
        void update(Odunc odunc);
        void delete(Odunc odunc);
        DataSet GetAll();
        DataSet GetByUser(int userId);
        DataSet GetByBookId(int bookID);
        DataSet GetByBookISBN(int ISBN);

        

    }
}
