using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T: class
    {
        void Add(T data);
        void Delete(T data);
        void Update(T data);
        T GetById(int id);
        List<T> ListAllData();
    }
}
