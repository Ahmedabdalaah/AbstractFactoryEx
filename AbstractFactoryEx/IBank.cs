using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryEx
{
    internal interface IBank
    {
        string Welcome(string code, string userName);
    }
}
