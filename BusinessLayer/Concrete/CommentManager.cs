using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDAL _commentDAL;

        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public void Add(Comment data)
        {
            _commentDAL.Add(data);
        }

        public void Delete(Comment data)
        {
            _commentDAL.Delete(data);
        }

        public Comment GetById(int id)
        {
            return _commentDAL.GetById(id);
        }

        public List<Comment> ListAllData()
        {
            return _commentDAL.ListAllData();
        }

        public void Update(Comment data)
        {
            _commentDAL.Update(data);
        }
        public List<Comment> GetCommentListByBlogId(int id)
        {
            return _commentDAL.ListAllData(x => x.BlogID == id);
        }
    }
}
