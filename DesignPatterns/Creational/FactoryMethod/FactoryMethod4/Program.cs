using System;

namespace FactoryMethod4
{
    class Program
    {
        static void Main(string[] args)
        {
            //new AirConditioner().ExecuteCreation(Actions.Warming, 22.5).Operate();

            AirConditioner
            .InitializeFactories()
            .ExecuteCreation(Actions.Warming, 22.5)
            .Operate();
        }
    }
}
