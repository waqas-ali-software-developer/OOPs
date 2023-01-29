using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.InheritanceAndPolymorphism
{
    internal class Employee
    {
        public string _firstName;
        public string _lastName;

        public void GetFullName()
        {
            Console.WriteLine($"FirstName = {_firstName} LastName = {_lastName}");
        }

        public virtual void EmployeeType()
        {
            Console.WriteLine("FullTime Employee");
        }
        
    }
}
