using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.Inheritnace
{
    //Crew is a person (Inheritnace)
    //Child / Derived
    internal class Crew: Person
    {
        public Crew()
        {
            Console.WriteLine("Child class Passenger");
        }
        public void ServeFoodToCustomer()
        {
            Console.WriteLine("Serve food and check ticket in the aero plane");
        }

      
    }
}
