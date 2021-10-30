using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDAL _blogDAL;

        public BlogManager(IBlogDAL blogDAL)
        {
            _blogDAL = blogDAL;
        }

        public void Add(Blog data)
        {
            _blogDAL.Add(data);
        }

        public void Delete(Blog data)
        {
            _blogDAL.Delete(data);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDAL.GetListWithCategory();
        }

        public List<Blog> GetBlogListById(int id)
        {
            return _blogDAL.ListAllData(x => x.BlogID == id);
        }
        public Blog GetById(int id)
        {
            return _blogDAL.GetById(id);
        }

        public List<Blog> ListAllData()
        {
            return _blogDAL.ListAllData();
        }

        public void Update(Blog data)
        {
            _blogDAL.Update(data);
        }
    }
}
