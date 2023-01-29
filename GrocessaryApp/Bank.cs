using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp
{ 
 /* In the same namespace(Container) we can not write
 more than one classes with same name
 */
    internal class Bank
    {
        //  publi
        private string _bankName;
        public string BankN1Name { get; set; }
        public string GetN1BankName()
        {
            //string name = "Standard Charterd";
            return _bankName;
        }

        public void SetN1BankName(string bankName)
        {
            _bankName = bankName;
        }
    }

    //public class Bank { } error

    //namespace 2

    namespace WebAPP
    {

        internal class Bank
        {
            //  publi
            private string _bankName;
            public string GetN2BankName()
            {
                //string name = "Standard Charterd";
                return _bankName;
            }

            public void SetN2BankName(string bankName)
            {
                _bankName = bankName;
            }
        }
    }

    //namespace 3
    namespace DesktopApplication
    {
        internal class Bank
        {
            //  publi
            private string _bankName;
            public string GetN3BankName()
            {
                //string name = "Standard Charterd";
                return _bankName;
            }

            public void SetN3BankName(string bankName)
            {
                _bankName = bankName;
            }
        }
    }

}
