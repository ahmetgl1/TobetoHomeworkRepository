using Interfacesses_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacesses_2.Models
{
    internal class SqlServer : ICustomerDataAccessLayer
    {
        public void Add()
        {
            Console.WriteLine("Sql Server added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Server deleted");
        }

        public void Remove()
        {
            Console.WriteLine("Sql Server remove");
        }

        public void Update()
        {
            Console.WriteLine("Sql Server updated");
        }
    }
}
