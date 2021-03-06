﻿using System.Diagnostics;
using Knnithyanand.RazorSamples.ViewComponentBasic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Knnithyanand.RazorSamples.ViewComponentBasic.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult License()
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
