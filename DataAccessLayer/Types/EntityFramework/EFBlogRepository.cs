using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Types.EntityFramework
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDAL
    {
        public List<Blog> GetBlogListByWriterId(int Id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Writer).ToList();
            }
        }

        public List<Blog> GetListWithCategory()
        {
            using(var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
        }       
    }
}
