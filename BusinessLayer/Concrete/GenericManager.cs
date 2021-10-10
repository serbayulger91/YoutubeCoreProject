using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        GenericRepository<T> repository = new GenericRepository<T>();
        public void Add(T data)
        {
            repository.Add(data);
        }

        public void Delete(T data)
        {
            repository.Delete(data);
        }

        public T GetById(int id)
        {
            return repository.GetById(id);
        }

        public List<T> ListAllData()
        {
            return repository.ListAllData();
        }

        public void Update(T data)
        {
            repository.Update(data);
        }
    }
}
