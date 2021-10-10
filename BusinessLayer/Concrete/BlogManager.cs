using BusinessLayer.Abstract;
using DataAccessLayer.Types.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        EFBlogRepository efRepository; 
        
        public BlogManager()        
        {
            efRepository = new EFBlogRepository();
        } 
        public void Add(Blog data)
        {
            efRepository.Add(data);
        }

        public void Delete(Blog data)
        {
            efRepository.Delete(data);
        }

        public Blog GetById(int id)
        {
            return efRepository.GetById(id);
        }

        public List<Blog> ListAllData()
        {
            return efRepository.ListAllData();
        }

        public void Update(Blog data)
        {
            efRepository.Update(data);
        }
    }
}
