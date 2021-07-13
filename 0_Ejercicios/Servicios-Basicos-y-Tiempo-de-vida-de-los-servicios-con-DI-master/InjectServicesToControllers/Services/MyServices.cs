using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjectServicesToControllers.Services
{
    public interface IMyService
    {
        string DoSomething();
    }
    public class MyServices : IMyService
    {
        public string DoSomething()
        {
           return "Algo desde nuestro servicio mas básico";
        }
    }
}
