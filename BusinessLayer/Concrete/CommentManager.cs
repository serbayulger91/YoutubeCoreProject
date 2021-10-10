using BusinessLayer.Abstract;
using DataAccessLayer.Types.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        EFCommentRepository efRepository;
        
        public CommentManager()
        {
            efRepository = new EFCommentRepository();
        }
        public void Add(Comment data)
        {
            efRepository.Add(data);
        }

        public void Delete(Comment data)
        {
            efRepository.Delete(data);
        }

        public Comment GetById(int id)
        {
            return efRepository.GetById(id);
        }

        public List<Comment> ListAllData()
        {
            return efRepository.ListAllData();
        }

        public void Update(Comment data)
        {
            efRepository.Update(data);
        }
    }
}
