﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.SealedClass
{
    //We cannot inherit customer class becuase this class is a sealed class
    internal sealed class Customer
    {
        public Customer()
        {
            Console.WriteLine("Seald class constructor");
        }

        public void DiplayTotalCustomers()
        {
            Console.WriteLine("Total numbers of customers are 300");
        }
    }
}
