using FactoryMethod1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod1.Concrete
{
    public class WebScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Web screen has been drawn.");
        }
    }
}
