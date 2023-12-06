using Patterns.AbstractFactories;
using Patterns.AbstractTransports;
using Patterns.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Patterns.Factories
{
    public abstract  class TransportFactory: TransportAbstractFactory
    {
        public override AbstractCar CreateAbstractCar()
        {
            return new AbstractCar(TransportTypes.Car);
        }

        public override AbstractTruck CreateAbstractTruck()
        {
            return new AbstractTruck(TransportTypes.Truck);
        }

        public abstract Transport CreateTransport();

    }
}
