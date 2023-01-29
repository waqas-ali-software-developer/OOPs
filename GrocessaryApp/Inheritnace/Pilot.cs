using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.Inheritnace
{
    //Pilot is a person (Inheritnace)
    internal class Pilot: Person
    {
        public Pilot()
        {
            Console.WriteLine("Child class Pilot");
        }
        public void FlyAeroplane()
        {
            Console.WriteLine("Pilot is flying aeroplane");
        }
        public void TakeOffAeroplane()
        {
            Console.WriteLine("Pilot is takeoff aeroplane");
        }

        public void DisplayPilotIdAndAge()
        {
            //this current created object 
            Console.WriteLine($"Id = {this.id} LastName = {this.age}");
        }

        public void DisplayPilotName()
        {
            //this current created object 
            Console.WriteLine($"FirstName = {this.firstName} LastName = {this.lastName}");
        }

        //ovverride the GetCityName method from parent class

        public override void GetCityName()
        {
            Console.WriteLine("The pilot city is London");
        }

    }
}
