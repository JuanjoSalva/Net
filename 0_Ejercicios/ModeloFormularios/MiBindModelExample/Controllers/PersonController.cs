using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiBindModelExample.Models;

namespace MiBindModelExample.Controllers
{
    public class PersonController : Controller
    {
        [Route("Person/GetName")]
        [HttpGet]
        public IActionResult GetName()
        {
            
            return View();
        }

        [Route("Person/GetName")]
        [HttpPost]
        public IActionResult GetName(Person person)
        {
            return View("ShowName", person);
        }
    }

    
}
