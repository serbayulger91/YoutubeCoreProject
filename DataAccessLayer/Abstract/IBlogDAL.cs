using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDAL : IGenericDAL<Blog>
    {
        List<Blog> GetListWithCategory();
    }
}
