using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bootstrap01.Models;

namespace Bootstrap01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(){return View();}
        public IActionResult Privacy(){return View();}
        public IActionResult Alert(){return View();}
        public IActionResult BootstrapNav(){return View();}
        public IActionResult BootstrapNavBar(){return View();}
        public IActionResult Buttons(){return View();}
        public IActionResult Drowdowns(){return View();}
        public IActionResult FormBs(){return View();}
        public IActionResult Modals(){return View();}



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
