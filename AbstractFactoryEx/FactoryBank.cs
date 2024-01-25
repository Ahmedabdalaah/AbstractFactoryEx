using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryEx
{
    internal class FactoryBank : IBankFactory
    {
        public IBank getBank(string code)
        {
            switch (code)
            {
                case "1111": return new CCSBank();

                case "2222": return new NileBank();
            }
                return null;
            }

        public IPayment GetCard(string codeNum)
        {
            switch (codeNum)
            {
                case "11": return new MasterCard();

                case "22": return new VisaCard();
            }
            return null;
        }
    }
}
