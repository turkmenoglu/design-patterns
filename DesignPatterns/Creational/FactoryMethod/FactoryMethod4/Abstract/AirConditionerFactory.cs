using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod4
{
    public abstract class AirConditionerFactory
    {
        public abstract IAirConditioner Create(double temperature);
    }
}
