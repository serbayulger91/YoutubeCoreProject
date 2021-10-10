using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Types.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }
        public void Add(About data)
        {
            _aboutDAL.Add(data);
        }

        public void Delete(About data)
        {
            _aboutDAL.Delete(data);
        }

        public About GetById(int id)
        {
            return _aboutDAL.GetById(id);
        }

        public List<About> ListAllData()
        {
            return _aboutDAL.ListAllData();
        }

        public void Update(About data)
        {
            _aboutDAL.Update(data);
        }
    }
}
