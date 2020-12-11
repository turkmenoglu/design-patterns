using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Titanium();
            return product;
        }
    }
}
