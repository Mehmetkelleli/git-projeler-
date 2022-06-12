using blog.businnes.Abstract;
using blog.data.Concrete.EfCoreMysql;
using myblog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.businnes.Concrete
{
    public class CvManager : ICvService
    {
        EfCvRepository _Cv = new EfCvRepository();
        public void create(Cv t)
        {
            _Cv.create(t);
        }

        public Cv GetById(int id)
        {
            return _Cv.GetById(id); 
        }

        public List<Cv> GetList()
        {
            return _Cv.GetList();
        }

        public void update(Cv t)
        {
            _Cv.update(t);
        }
    }
}
