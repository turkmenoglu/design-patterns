using FactoryMethod2.Abstract;
using System;

namespace FactoryMethod2.Concrete
{
    public class WinScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Win screen has been drawn.");
        }
    }
}
