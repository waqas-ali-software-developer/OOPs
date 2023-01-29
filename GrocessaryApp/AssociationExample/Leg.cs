using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.AssociationExample
{
    internal class Leg
    {
        public Leg()
        {
            Console.WriteLine("Leg created");
        }

        ~Leg()
        {
            Console.WriteLine("Leg Died");
        }
    }
}
