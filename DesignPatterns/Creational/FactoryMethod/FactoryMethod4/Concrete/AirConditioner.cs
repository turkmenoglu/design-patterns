using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod4
{
    public class AirConditioner
    {
        private readonly Dictionary<Actions, AirConditionerFactory> _factories;

        //public AirConditioner()
        //{
        //    //_factories = new Dictionary<Actions, AirConditionerFactory>
        //    //{
        //    //    { Actions.Cooling, new CoolingFactory() },
        //    //    { Actions.Warming, new WarmingFactory() }
        //    //};

        //    _factories = new Dictionary<Actions, AirConditionerFactory>();
        //    foreach (Actions action in Enum.GetValues(typeof(Actions)))
        //    {
        //        var factory = (AirConditionerFactory)Activator.CreateInstance(Type.GetType($"FactoryMethod4.{Enum.GetName(typeof(Actions), action)}Factory"));
        //        _factories.Add(action, factory);
        //    }
        //}



        private AirConditioner()
        {
            _factories = new Dictionary<Actions, AirConditionerFactory>();
            foreach (Actions action in Enum.GetValues(typeof(Actions)))
            {
                var factory = (AirConditionerFactory)Activator.CreateInstance(Type.GetType("FactoryMethod4." + Enum.GetName(typeof(Actions), action) + "Factory"));
                _factories.Add(action, factory);
            }
        }

        public static AirConditioner InitializeFactories() => new AirConditioner();

        public IAirConditioner ExecuteCreation(Actions action, double temperature) => _factories[action].Create(temperature);
    }
}