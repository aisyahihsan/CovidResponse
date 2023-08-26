using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1001.Models;

namespace Test1001.Controllers
{
    public class CovidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CovidResponse001()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CovidResponse001(CovidDiagnosis result)
        {
            return View("CovidResponseResult001", result);
        }
    }
}
