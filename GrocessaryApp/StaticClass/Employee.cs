using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.StaticClass
{
    internal class Employee
    {
        public static int countEmployee = 0;
        public int id;
        public static string CompanyLocation { get; set; }
        public Employee()
        {
            countEmployee = countEmployee + 1;
        }

        public static string GetCompanyName()
        {

            //we can access static member with this keyword
            return "Amazon";
        }
    }
}
