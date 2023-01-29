using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.Inheritnace
{
    //passenger is a person (Inheritnace)
    internal class Passenger : Person
    {
        /* parent class constructor will be call first and after that child class constructor
         will call
         */
        public Passenger()
        {
            Console.WriteLine("Child class Passenger");
        }
        public void GetPassengerTraveller()
        {
            Console.WriteLine("300 pasanger is travelling");
        }
    }
}
