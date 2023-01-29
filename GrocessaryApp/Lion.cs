using GrocessaryApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GrocessaryApp
{
    internal class Lion : IAnimal
    {
        public string Age { get; set; }

        public void DisplayAnimalLegs()
        {
            Console.WriteLine("Lion has 4 legs");
        }

        public void DisplayAnimalName()
        {
            Console.WriteLine("Samba Lion");
        }
    }
}
