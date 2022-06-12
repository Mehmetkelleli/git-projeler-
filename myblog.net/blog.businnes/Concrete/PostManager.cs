using blog.businnes.Abstract;
using myblog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.businnes.Concrete
{
    public class PostManager : IPostService
    {
        public void create(Post t)
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetList()
        {
            throw new NotImplementedException();
        }

        public void update(Post t)
        {
            throw new NotImplementedException();
        }
    }
}
