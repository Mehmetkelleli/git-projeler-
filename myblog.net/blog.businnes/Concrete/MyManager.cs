using blog.businnes.Abstract;
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
        public void create(My t)
        {
            throw new NotImplementedException();
        }

        public My GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<My> GetList()
        {
            throw new NotImplementedException();
        }

        public void update(My t)
        {
            throw new NotImplementedException();
        }
    }
}
