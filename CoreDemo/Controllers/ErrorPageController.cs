﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error(int code)
        {
            return View();
        }
    }
}
