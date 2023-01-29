using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.AbstractClass
{
    internal class Rickshaw : Vehicle
    {
        public override string Name { get; set; }

        public override string ManufacturingRegion { get; set; }


        public Rickshaw()
        {
            Console.WriteLine("Rickshaw constructor");
        }
        public override int GetWheels()
        {
            Console.WriteLine("Rickshaw has 3 wheels");
            return 3;
        }

        public override void GetCarColor()
        {
            Console.WriteLine("Blue color rickshaw");
        }
    }
}
