using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiModeloConVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult GetName()
        {
            return View();
        }
    }
}
