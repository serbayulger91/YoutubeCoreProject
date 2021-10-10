using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccessLayer.Types.EntityFramework;

namespace CoreDemo.Controllers
{
    public class CategoriesController : Controller
    {
        CategoryManager manager = new CategoryManager(new EFCategoryRepository());
        
        public IActionResult Index()
        {
            var values = manager.ListAllData();
            return View(values);
        }
    }
}
