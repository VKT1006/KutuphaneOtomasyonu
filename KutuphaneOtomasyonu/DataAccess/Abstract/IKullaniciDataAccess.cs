﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.DataAccess.Abstract
{
    internal interface IKullaniciDataAccess
    {

        void save(Kullanici kullanici);
        void delete(Kullanici kullanici);
        void update(Kullanici kullanici);
        List<Kullanici> GetAll();
        Kullanici get(Kullanici kullanici);
        List<Kullanici> getByName(String name);
        Kullanici getById(int id);
    }
}