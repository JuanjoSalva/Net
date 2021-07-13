using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyViewComponent.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InvokeVC() //Llamamos como Home/InvokeVC
        {
            return ViewComponent("My");
        }
        
    }
}
