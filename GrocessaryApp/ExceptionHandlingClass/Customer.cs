using GrocessaryApp.MySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.ExceptionHandlingClass
{
    internal class Customer
    {
        public string GetCustomerName()
        {
            try
            {
                string studentName = this.GetStudentNameFromMySQLDB();
                return studentName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private string GetStudentNameFromMySQLDB()
        {
            try
            {
                MySQLDatabase db = new MySQLDatabase();
                db.GetCustomer();
                return "customer Name";
            }
            catch {
                throw;
            }
        }
    }
}
