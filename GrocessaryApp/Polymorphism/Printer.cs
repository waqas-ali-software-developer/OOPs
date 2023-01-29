using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.Polymorphism
{
    internal class Printer
    {
        public string name;

        public virtual void PrintPaper()
        {
            Console.WriteLine("Normal Print - old ink");
        }
    }
}
