﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HiBlogs.Web.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        // GET: /<controller>/
        public IActionResult Migration()
        {
            return View();
        }
    }
}
