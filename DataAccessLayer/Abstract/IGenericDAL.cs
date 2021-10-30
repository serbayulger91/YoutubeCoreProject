using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        List<T> ListAllData();
        void Add(T data);
        void Update(T data);
        void Delete(T data);
        T GetById(int id);
        List<T> ListAllData(Expression<Func<T, bool>> filter);
    }
}
