using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjectServicesToControllers.Services
{
    public interface IRandomService
    {
        int GetNumber();
    }

    public class RandomService : IRandomService
    {
        private int _randomNumber;

        public RandomService()
        {
            Random random = new Random();
            _randomNumber = random.Next(1000000);
        }
        public int GetNumber()
        {
            return _randomNumber;
        }
    }

    public interface IRandomWrapper
    {
        int GetNumber();
    }

    public class RandomWrapper : IRandomWrapper
    {
        private IRandomService _randomService;

        public RandomWrapper(IRandomService randomService)
        {
            _randomService = randomService;
        }

        public int GetNumber()
        {
            return _randomService.GetNumber();
        }
    }
}
