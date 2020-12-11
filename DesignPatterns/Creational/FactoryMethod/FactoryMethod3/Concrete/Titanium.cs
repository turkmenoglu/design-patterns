using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3
{
    public class Titanium : CreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }
    }
}
