using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.Interface
{
    //interface is a contract
    internal interface IAnimal
    {
        string Age { get; set; }
        //interface members are alway be public
        void DisplayAnimalName();
        void DisplayAnimalLegs();
    }
}
