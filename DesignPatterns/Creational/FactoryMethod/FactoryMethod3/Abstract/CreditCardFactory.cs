using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod3
{
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();
        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
