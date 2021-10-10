using BusinessLayer.Abstract;
using DataAccessLayer.Types.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        EFAboutRepository efRepository; 
        
        public AboutManager()
        {
            efRepository = new EFAboutRepository();
        } 
        public void Add(About data)
        {
            efRepository.Add(data);
        }

        public void Delete(About data)
        {
            efRepository.Delete(data);
        }

        public About GetById(int id)
        {
            return efRepository.GetById(id);
        }

        public List<About> ListAllData()
        {
            return efRepository.ListAllData();
        }

        public void Update(About data)
        {
            efRepository.Update(data);
        }
    }
}
