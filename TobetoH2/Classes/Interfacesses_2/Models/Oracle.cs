using Interfacesses_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacesses_2.Models
{
    internal class Oracle : ICustomerDataAccessLayer
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
         
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Remove()
        {
            Console.WriteLine("Oracle remove");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated !");
        }
    }
}
