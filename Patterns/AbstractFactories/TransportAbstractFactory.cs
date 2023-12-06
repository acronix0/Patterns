using Patterns.AbstractTransports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactories
{
    public abstract class TransportAbstractFactory
    {
        public abstract AbstractCar CreateAbstractCar();
        public abstract AbstractTruck CreateAbstractTruck();
    }
}
