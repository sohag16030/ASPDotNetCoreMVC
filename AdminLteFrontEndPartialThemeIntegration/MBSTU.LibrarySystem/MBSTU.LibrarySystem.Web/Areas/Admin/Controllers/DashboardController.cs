﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MBSTU.LibrarySystem.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace MBSTU.LibrarySystem.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
      
        public IActionResult Index()
        {
            var model = new DashboardModel();
           
            return View(model);
        }
    }
}