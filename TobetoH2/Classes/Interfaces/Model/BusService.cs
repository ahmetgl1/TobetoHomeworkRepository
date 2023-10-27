using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Model
{
    internal class BusService : IVehicle
    {
        public void Lock()
        {
            Console.WriteLine("Otobüs kilitlendi.");
        }

        public void Unlock()
        {
            Console.WriteLine("Otobüs kilidi açıldı.");
        }
    }
}
