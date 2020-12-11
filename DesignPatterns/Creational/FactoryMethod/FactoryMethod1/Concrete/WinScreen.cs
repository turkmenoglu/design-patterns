using FactoryMethod1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod1.Concrete
{
    public class WinScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Win screen has been drawn.");
        }
    }
}
