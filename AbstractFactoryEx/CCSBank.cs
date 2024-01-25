using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryEx
{
    internal class CCSBank : IBank
    {
        public string Welcome(string code, string userName)
        {
            return $"Welcome {userName} in CCSBank System";
        }
    }
}
