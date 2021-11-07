using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Types.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class SubscribeController : Controller
    {
        SubscribeManager sm = new SubscribeManager(new EFSubscribeRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(Subscribe data)
        {
            data.MailStatus = true;
            sm.Add(data);
            return PartialView();
        }
    }
}
