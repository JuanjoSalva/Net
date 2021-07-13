using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsandoHelpers.Controllers
{
    public class HomeController : Controller
    {
        //[Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }
        //[Route("Home/AnotherAction")]
        public IActionResult AnotherAction()
        {
            return Content("AnotherAction result");
        }
    }
}
