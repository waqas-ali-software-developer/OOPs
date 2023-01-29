using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.AssociationAgregationExmp
{
    internal class Bank
    {
        private Employee _employee;
        public Bank(Employee employee)//parameter we will pass employee object
        {
            _employee = employee;
            Console.WriteLine("Standard Chartered");
        }

        ~Bank()
        {
            Console.WriteLine("Bank destroyed");
        }
    }
}
