using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        ISubscribeDAL _subscribeDAL;

        public SubscribeManager(ISubscribeDAL subscribeDAL)
        {
            _subscribeDAL = subscribeDAL;
        }
        public void Add(Subscribe data)
        {
            _subscribeDAL.Add(data);
        }

        public void Delete(Subscribe data)
        {
            _subscribeDAL.Delete(data);
        }

        public Subscribe GetById(int id)
        {
            return _subscribeDAL.GetById(id);
        }

        public List<Subscribe> ListAllData()
        {
            return _subscribeDAL.ListAllData();
        }

        public void Update(Subscribe data)
        {
            _subscribeDAL.Update(data);
        }
    }
}
