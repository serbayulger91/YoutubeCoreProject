using BusinessLayer.Abstract;
using DataAccessLayer.Types.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        EFWriterRepository efRepository;

        public WriterManager()
        {
            efRepository = new EFWriterRepository();
        }
        public void Add(Writer data)
        {
            efRepository.Add(data);
        }

        public void Delete(Writer data)
        {
            efRepository.Delete(data);
        }

        public Writer GetById(int id)
        {
            return efRepository.GetById(id);
        }

        public List<Writer> ListAllData()
        {
            return efRepository.ListAllData();
        }

        public void Update(Writer data)
        {
            efRepository.Update(data);
        }
    }
}
