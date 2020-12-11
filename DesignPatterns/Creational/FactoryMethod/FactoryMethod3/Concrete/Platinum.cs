using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3
{
    public class Platinum : CreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }
    }
}
