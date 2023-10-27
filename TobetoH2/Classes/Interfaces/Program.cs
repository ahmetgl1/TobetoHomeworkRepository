using Interfaces.Model;
using Interfaces.Services;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarService carService = new CarService();
            Car car = new Car
            {
                Id = 1,
                Name = "Opel",
                Brand = "Vectra",
                Wheels = 4
            };

            carService.Lock();


            
            
            
            
           
        }
    }
}
