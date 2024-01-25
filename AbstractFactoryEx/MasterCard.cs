using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryEx
{
    internal class MasterCard : IPayment
    {
        public string GetName()
        {
            return "Master Card";
        }

        public string VisaCompany()
        {
            return " Visa ";
        }
    }
}
