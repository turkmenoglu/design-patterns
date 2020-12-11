using FactoryMethod1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod1.Concrete
{
    public class MobileScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Mobile screen has been drawn.");
        }
    }
}
