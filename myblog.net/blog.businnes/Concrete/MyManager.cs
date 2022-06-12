﻿using blog.businnes.Abstract;
using blog.data.Concrete.EfCoreMysql;
using myblog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.businnes.Concrete
{
    public class MyManager : IMyService
    {
        EfMyRepository _my = new EfMyRepository();
        public void create(My t)
        {
            _my.create(t);
        }

        public My GetById(int id)
        {
            return _my.GetById(id);
        }

        public List<My> GetList()
        {
            return _my.GetList();
        }

        public void update(My t)
        {
            _my.update(t);
        }
    }
}
