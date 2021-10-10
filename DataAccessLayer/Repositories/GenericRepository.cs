using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        public void Add(T data)
        {
            using var c = new Context();
            c.Add(data);
            c.SaveChanges();
        }

        public void Delete(T data)
        {
            using var c = new Context();
            c.Remove(data);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> ListAllData()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
            
        }

        public void Update(T data)
        {
            using var c = new Context();
            c.Update(data);
            c.SaveChanges();
        }
    }
}
