using System;
using System.Collections.Generic;
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
    }
}
