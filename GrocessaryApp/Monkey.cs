using GrocessaryApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp
{
    internal class Monkey : IAnimal
    {
        public string Age { get; set; }
        public void DisplayAnimalLegs()
        {
            Console.WriteLine("Monkey has 2 legs");
        }

        public void DisplayAnimalName()
        {
            Console.WriteLine("Monkey Name");
        }
    }
}
