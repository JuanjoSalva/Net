using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InjectServicesToControllers.Services;
namespace InjectServicesToControllers.Controllers
{
    //Ejemplo de Servicios Básicos
    /*public class HomeController : Controller
    {
        private IMyService _myService;

        public HomeController(IMyService myService)
        {
            _myService = myService;
        }

        public IActionResult Index()
        {
            //return View();
            //return Content("Hola desde nuestro controlador mas básico");
            return Content(_myService.DoSomething());
        }

        public IActionResult Photo()
        {
            //return View();
            return Content("Respuesta desde la action Photo");
        }
    }*/

    //Ejemplo del Controlador con servicios y su lifetime "Tiempo de vida"
    public class HomeController : Controller
    {
        private IRandomService _randomService;
        private IRandomWrapper _randomWrapper;

        public HomeController(IRandomService randomService, IRandomWrapper randomWrapper)
        {
            _randomService = randomService;
            _randomWrapper = randomWrapper;
        }

        public IActionResult Index()
        {
            string result = $"The number from Random Service in controller: { _randomService.GetNumber()}, the number from Wrapper Service: { _randomWrapper.GetNumber()}";
            return Content(result);
        }
    }
}
