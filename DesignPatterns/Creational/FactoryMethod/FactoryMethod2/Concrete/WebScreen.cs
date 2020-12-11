using FactoryMethod2.Abstract;
using System;

namespace FactoryMethod2.Concrete
{
    public class WebScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Web screen has been drawn.");
        }
    }
}
