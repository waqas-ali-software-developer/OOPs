using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.AbstractClass
{
    internal class Car : Vehicle
    {
        public override string Name { get; set; }

        public override int GetWheels()
        {
            Console.WriteLine("4 wheeler car");
            return 4;
        }
    }
}
