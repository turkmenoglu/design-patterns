using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod4
{
    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new WarmingManager(temperature);
    }
}
