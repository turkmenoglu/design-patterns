using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3
{
    public class MoneyBack : CreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
    }
}
