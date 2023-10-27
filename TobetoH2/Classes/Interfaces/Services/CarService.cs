using Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    internal class CarService : IVehicle
    {
        public void Lock()
        {
            Console.WriteLine("Araba kilitlendi.");
        }

        public void Unlock()
        {
            Console.WriteLine("Araba kilidi açıldı.");
        }
    }
}
