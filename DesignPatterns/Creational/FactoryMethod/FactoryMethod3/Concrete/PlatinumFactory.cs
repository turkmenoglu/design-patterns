using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Platinum();
            return product;
        }
    }
}
