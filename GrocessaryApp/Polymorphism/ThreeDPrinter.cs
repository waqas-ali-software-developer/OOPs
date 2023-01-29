using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.Polymorphism
{
    internal class ThreeDPrinter: Printer
    {
        public override void PrintPaper()
        {
            Console.WriteLine("ThreeDPrinter Print");
        }
    }
}
