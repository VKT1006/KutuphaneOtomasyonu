﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Business.Abstract
{
    internal interface OduncService
    {
        void save(Odunc odunc);
        void update(Odunc odunc);
        void delete(Odunc odunc);
        List<Odunc> GetAll();
        List<Odunc> GetByUser(int userId);
        List<Odunc> GetByBookId(int bookID);
        List<Odunc> GetByBookISBN(int ISBN);

    }
}
