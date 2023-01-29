using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.Polymorphism
{
    internal class LaserPrinter : Printer
    {
        public override void PrintPaper()
        {
            Console.WriteLine("LaserPrinter Print");
        }
    }
}
