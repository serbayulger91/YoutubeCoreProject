using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Types.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            var values = bm.ListAllData();
            return View(values);
        }
    }
}
