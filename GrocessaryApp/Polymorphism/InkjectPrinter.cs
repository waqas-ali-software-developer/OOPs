using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.Polymorphism
{
    internal class InkjectPrinter: Printer
    {
        public override void PrintPaper()
        {
            Console.WriteLine("Inkjet Print");
        }
    }
}
