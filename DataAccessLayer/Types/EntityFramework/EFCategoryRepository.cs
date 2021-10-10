using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Types.EntityFramework
{
    public class EFCategoryRepository : GenericRepository<Category>, ICategoryDAL
    {

    }
}
