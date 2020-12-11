using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod4
{
    public class CoolingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new CoolingManager(temperature);
    }
}
