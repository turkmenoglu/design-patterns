using FactoryMethod2.Abstract;
using System;

namespace FactoryMethod2.Concrete
{
    public class MobileScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Mobile screen has been drawn.");
        }
    }
}
