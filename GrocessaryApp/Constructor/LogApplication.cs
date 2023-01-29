using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.Constructor
{
    internal class LogApplication
    {
        public static string _applicationName;
        public static int _applicationVersion;
        private static readonly DateTime _created = DateTime.Now;
        public static DateTime Updated { get; set; }
        public static int CounterApplicationStatic = 0;
        public static int CounterApplicationInstance = 0;
        /*
         * 1) default static constructor will called to intialize the static fields and properties
        if we did not provide any constructor(static)
         * 2) Always static constructor will call first.
         * 3) Always static constructor will call only one time. Not more than one time.
         * 4) clr(common lanuage runtime) will static constructor
         * 5) Static must be parameterless(without parameter)
         */

        static LogApplication()
        { 
            
     
            _applicationName = "Static Health";
            _applicationVersion = 123;
            CounterApplicationStatic = CounterApplicationStatic + 1;
        }

        //static LogApplication(string name)
        //{


        //    _applicationName = "Static Health";
        //    _applicationVersion = 123;
        //    CounterApplicationStatic = CounterApplicationStatic + 1;
        //}
        //instance constructor
        public LogApplication()
       {
            CounterApplicationInstance = CounterApplicationInstance + 1;
       }
       
        public LogApplication(DateTime updatedDate)
        {
            CounterApplicationInstance = CounterApplicationInstance + 1;
            Updated = updatedDate;
        }
        public void DisplayLogApplication()
        {
          
            Console.WriteLine($"Name {_applicationName} Version {_applicationVersion} Date {_created}");
        
        }
        // static constructor, default constructor, private constructor, parameterize constructor
        // copy constructor
    }
}
