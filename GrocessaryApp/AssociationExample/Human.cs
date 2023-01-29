using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.AssociationExample
{
    //Strong Composition
    internal class Human
    {
        //private Hand hand1 = new Hand();
        //private Hand hand2 = new Hand();

        //private Leg leg1 = new Leg();
        //private Leg leg2 = new Leg();

        private Hand  hand1;
        private Hand  hand2;

        private Leg leg1;
        private Leg leg2;

        public Human()
        {
            hand1 = new Hand();
            hand2 = new Hand();
            leg1 = new Leg();
            leg2 = new Leg();
            Console.WriteLine("Baby born");
        }

        ~Human()
        {
            Console.WriteLine("Baby died");
        }
    }
}
