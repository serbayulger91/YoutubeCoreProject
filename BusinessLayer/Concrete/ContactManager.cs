using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDAL _contactDAL;
        
        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }

        public void Add(Contact data)
        {
            _contactDAL.Add(data);
        }

        public void Delete(Contact data)
        {
            _contactDAL.Delete(data);
        }

        public Contact GetById(int id)
        {
            return _contactDAL.GetById(id);
        }

        public List<Contact> ListAllData()
        {
            return _contactDAL.ListAllData();
        }

        public void Update(Contact data)
        {
            _contactDAL.Update(data);
        }
    }
}
