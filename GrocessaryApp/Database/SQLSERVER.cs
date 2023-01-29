using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.Database
{
    internal class SQLSERVER
    {
    }
    internal class Bank
    {
        //  publi
        private string _bankName;
        public string GetN9BankName()
        {
            //string name = "Standard Charterd";
            return _bankName;
        }

        public void SetN1BankName(string bankName)
        {
            _bankName = bankName;
        }
    }
}
