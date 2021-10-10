using BusinessLayer.Abstract;
using DataAccessLayer.Types.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        EFContactRepository efRepository; 
        
        public ContactManager()
        {
            efRepository = new EFContactRepository();
        } 
        public void Add(Contact data)
        {
            efRepository.Add(data);
        }

        public void Delete(Contact data)
        {
            efRepository.Delete(data);
        }

        public Contact GetById(int id)
        {
            return efRepository.GetById(id);
        }

        public List<Contact> ListAllData()
        {
            return efRepository.ListAllData();
        }

        public void Update(Contact data)
        {
            efRepository.Update(data);
        }
    }
}
