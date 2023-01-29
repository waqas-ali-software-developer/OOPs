using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.InheritanceAndPolymorphism
{
    internal class PartTimeEmployee : Employee
    {
        //change the implementation
        public override void EmployeeType()
        {
            Console.WriteLine("Partime Employee");
        }
    }
}
