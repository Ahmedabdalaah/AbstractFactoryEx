using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryEx
{
    internal interface IPayment
    {
        string GetName();
        string VisaCompany();
    }
}
