using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiprimeraVista.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Price = 2;
            ViewBag.Names = new List<string>() { "name1", "name2", "name3" };
            var p1 = new Product() { Name = "Product1" };
            var p2 = new Product() { Name = "Product2" };
            var products = new List<Product>() { p1, p2 };
            return View(products);
        }
        public IActionResult Format()
        {
            return View();
        }
    }


    // MODEL to passing view
    public class Product
    {
        public string Name { get; set; }
    }
}

namespace Services
{
    public interface IFormatNumber
    {
        string GetFormattedNumber(int number);
    }
    public class FormatNumber : IFormatNumber
    {
        public string GetFormattedNumber(int number)
        {
            return string.Format("{0:N0}", number);
        }
    }
}
