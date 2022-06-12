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
    public class PostManager : IPostService
    {
        EfPostRepository _post = new EfPostRepository();
        public void create(Post t)
        {
            _post.create(t);
        }

        public Post GetById(int id)
        {
            return _post.GetById(id); _
        }

        public List<Post> GetList()
        {
            return _post.GetList();
        }

        public void update(Post t)
        {
            _post.update(t);
        }
    }
}
