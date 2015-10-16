using DataAccessLayer;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectTestConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerRepository = new CustomerRepository();

            var customer = new Customer
            {
                firstName = "Eric",
                lastName = "Brunner",
                streetAddress = "my street",
                city = "Vienna"
            };

            customerRepository.Create(customer);

            Console.ReadKey();
        }
    }
}
