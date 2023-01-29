using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.Inheritnace
{
    //Parent/Base Class
    internal class Person
    {
        protected int id;
        protected int age;
        public string firstName;
        public string lastName;
        private int wallet;
        public Person()
        {
            id = 0;
            age = 0;
            wallet = 0;
            Console.WriteLine("Parent class person");
        }
        public virtual void GetCityName()
        {
            Console.WriteLine("The peron city is Chicago");
        }


    }
}
