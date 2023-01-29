using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.AbstractClass
{
    //it is incomplete class
    internal abstract class Employee
    {
        public int Id;
        public string Name;
        public string Country;
        public Employee()
        {
            Console.WriteLine("Employee Parent Class Constructor");
        }

        

        public void GetEmployeeDetail()
        {
            Console.WriteLine($"Id = {Id} Name = {Name} and Country = {Country}");
        }
    }
}
