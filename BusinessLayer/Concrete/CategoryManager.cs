using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void Add(Category data)
        {
            _categoryDAL.Add(data);
        }

        public void Delete(Category data)
        {
            _categoryDAL.Delete(data);
        }

        public Category GetById(int id)
        {
            return _categoryDAL.GetById(id);
        }

        public List<Category> ListAllData()
        {
            return _categoryDAL.ListAllData();
        }

        public void Update(Category data)
        {
            _categoryDAL.Update(data);
        }
    }
}
