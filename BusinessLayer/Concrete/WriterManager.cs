using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDAL _writerDAL;

        public WriterManager(IWriterDAL writerDAL)
        {
            _writerDAL = writerDAL;
        }

        public void Add(Writer data)
        {
            _writerDAL.Add(data);
        }

        public void Delete(Writer data)
        {
            _writerDAL.Delete(data);
        }

        public Writer GetById(int id)
        {
            return _writerDAL.GetById(id);
        }

        public List<Writer> ListAllData()
        {
            return _writerDAL.ListAllData();
        }

        public void Update(Writer data)
        {
            _writerDAL.Update(data);
        }
    }
}
