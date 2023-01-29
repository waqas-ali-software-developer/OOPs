using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.AssociationExample
{
    internal class Hand
    {
        public Hand()
        {
            Console.WriteLine("Hand created");
        }

         ~Hand()//destructor
        {
            Console.WriteLine("Hand died");
        }
    }
}
