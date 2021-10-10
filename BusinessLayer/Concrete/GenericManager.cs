using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        IGenericDAL<T> _genericDAL;

        public GenericManager(IGenericDAL<T> genericDAL)
        {
            _genericDAL = genericDAL;
        }

        public void Add(T data)
        {
            _genericDAL.Add(data);
        }

        public void Delete(T data)
        {
            _genericDAL.Delete(data);
        }

        public T GetById(int id)
        {
            return _genericDAL.GetById(id);
        }

        public List<T> ListAllData()
        {
            return _genericDAL.ListAllData();
        }

        public void Update(T data)
        {
            _genericDAL.Update(data);
        }
    }
}
