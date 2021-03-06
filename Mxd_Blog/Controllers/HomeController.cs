﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mxd_Blog.Models;

namespace Mxd_Blog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Home")]
        public IActionResult Home()
        {
            ViewBag.Index = 1;
            return View();
        }
        public IActionResult Privacy()
        {
            ViewBag.Index = 6;
            return View();
        }
        [Route("/WriteBlog")]
        public IActionResult WriteBlog()
        {
            ViewBag.Index = 2.1;
            return View();
        }
        [Route("/Login")]
        public IActionResult Login()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
