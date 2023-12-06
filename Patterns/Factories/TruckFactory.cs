using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Transports;

namespace Patterns.Factories
{
    internal class TruckFactory: TransportFactory
    {
        public override Transport CreateTransport() => Transport.CreateTransport(TransportTypes.Truck);
    }
}
