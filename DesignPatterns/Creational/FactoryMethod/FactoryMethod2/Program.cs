using FactoryMethod2.Concrete;
using System;

namespace FactoryMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            new MobileScreenCreator().Create().Draw();
            new WebScreenCreator().Create().Draw();
            new WinScreenCreator().Create().Draw();
        }
    }
}
