using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.AbstractClass
{
    internal abstract class Vehicle
    {
        public abstract string Name { get; set; }

       // public virtual int id;
        public virtual string ManufacturingRegion { get; set; }
        //Alway parent class contructor call first
        public Vehicle()
        {
            Console.WriteLine("Parent class Vehicle Constructor");
        }
        /* we can not provide the implementation of abstract method
         OR we can provide body of the method
        We must have to ovverie abstract method
        */
        public abstract int GetWheels();

        public void DisplayCompanyName()
        {
            Console.WriteLine("Toyata");
        }
        /*
         * 1)we have option in derived class we can ovveride the virtual method
           2) OR We can not ovveride.
         * */
        public virtual void GetCarColor()
        {
            Console.WriteLine("White");
        }
    }
}
