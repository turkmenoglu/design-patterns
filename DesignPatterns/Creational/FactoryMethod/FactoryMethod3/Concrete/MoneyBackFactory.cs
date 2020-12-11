using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new MoneyBack();
            return product;
        }
    }
}
