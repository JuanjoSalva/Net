using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalsMvc.Models
{
    public class Animal : Controller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string UniqueInformation { get; set; }
        public string Category { get; set; }
        public IActionResult Index()
        {
            return View();
        }
    }
}
