using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryEx
{
    internal class VisaCard : IPayment
    {
        public string GetName()
        {
            return " Visa Card";
        }

        public string VisaCompany()
        {
            return " Visa ";
        }
    }
}
