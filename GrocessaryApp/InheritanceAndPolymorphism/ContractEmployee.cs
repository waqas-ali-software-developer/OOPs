using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.InheritanceAndPolymorphism
{
    internal class ContractEmployee : Employee
    {
        public override void EmployeeType()
        {
            Console.WriteLine("Contract Employee");
        }
    }
}
