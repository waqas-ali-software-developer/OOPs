using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.Const_ReadOnly
{
    class Employee
    {
        //class members by default private if we did not provide any access modifier
       int EmployeeId;
        /*  We can access const field through class name same like static variable
         *  static and constant
         */
        public const string company ="Amazon";//=>field static and constant

        public readonly string _companyBuildingColor;//set value on runtime through constructor
        
        public Employee(string companyBuildingColor)
        {
            _companyBuildingColor = companyBuildingColor;// we are setting the value through run-time
        }
        public int GetCompanyStreetNumber()
        {
           const int streetNumber = 345;// we are using const as variable
            
            return streetNumber;
        }

        public string GetEmployeeName()
        {
            return "John";
        }

    }
}
