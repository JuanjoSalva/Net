using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsandoHelpers.Controllers
{
    public class FirstController : Controller
    {
         [Route("First/Some")]
        public IActionResult Some()
        {
            return View();
        }
    }

    public class SecondController : Controller
    {
        [Route("Second/Index")]
        public IActionResult MyAction()
        {
            return Content("Second Controller");
        }
    }

    public class PhotoController: Controller
    {
        [Route("Photo/Choose")]
        public IActionResult Choose()
        {
            return View();
        }

        [Route("Photo/Display/{id}")]
        public IActionResult Display(int id)
        {
            //string res = $"Photo number {id} was choseen";
            //return Content("");
            ViewBag.Id = id;
            return View();
        }

        
    }
    
}
