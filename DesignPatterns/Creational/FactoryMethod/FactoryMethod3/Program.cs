using System;

namespace FactoryMethod3
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCardMoneyBack = new MoneyBackFactory().CreateProduct();
            Console.WriteLine(creditCardMoneyBack.GetCardType());

            CreditCard creditCardPlatinum = new PlatinumFactory().CreateProduct();
            Console.WriteLine(creditCardPlatinum.GetCardType());

            CreditCard creditCardTitanium = new TitaniumFactory().CreateProduct();
            Console.WriteLine(creditCardTitanium.GetCardType());
        }
    }
}
