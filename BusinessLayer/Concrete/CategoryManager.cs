using BusinessLayer.Abstract;
using DataAccessLayer.Types.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EFCategoryRepository efRepository;

        public CategoryManager()
        {
            efRepository = new EFCategoryRepository();
        }
        public void Add(Category data)
        {
            efRepository.Add(data);
        }

        public void Delete(Category data)
        {
            efRepository.Delete(data);
        }

        public Category GetById(int id)
        {
            return efRepository.GetById(id);
        }

        public List<Category> ListAllData()
        {
            return efRepository.ListAllData();
        }

        public void Update(Category data)
        {
            efRepository.Update(data);
        }
    }
}
