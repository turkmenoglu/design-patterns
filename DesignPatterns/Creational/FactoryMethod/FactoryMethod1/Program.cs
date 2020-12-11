using FactoryMethod1.Abstract;
using System;

namespace FactoryMethod1
{
    class Program
    {
        static void Main(string[] args)
        {
            ScreenCreator screenCreator = new ScreenCreator();
            screenCreator.Create(Concrete.Enum.ScreenType.Mobile).Draw();
            screenCreator.Create(Concrete.Enum.ScreenType.Web).Draw();
            screenCreator.Create(Concrete.Enum.ScreenType.Win).Draw();
        }
    }
}
