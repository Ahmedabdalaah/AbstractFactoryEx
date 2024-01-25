using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryEx
{
    internal interface IBankFactory
    {
        IBank getBank(string code);
        IPayment GetCard(string codeNum);
    }
}
