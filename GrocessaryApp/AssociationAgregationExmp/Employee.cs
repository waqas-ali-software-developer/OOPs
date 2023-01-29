using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.AssociationAgregationExmp
{
    internal class Employee
    {
        public int _age;
        public string _name;
        public Employee()
        {
            Console.WriteLine("Joined the company");
        }
        public Employee(Employee employee)
        {
            this._age = employee._age;
            this._name = employee._name;
        }

        ~Employee()//destructor
        {
            Console.WriteLine("Employeed destroyed");
            //here we will write all the code for object clean
            //CLR => it is not responsible for third library e.g. oracle
        }

        
    }
}
