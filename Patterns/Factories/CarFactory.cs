using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.AbstractTransports;
using Patterns.Transports;

namespace Patterns.Factories
{
    internal class CarFactory : TransportFactory
    {
        public override Transport CreateTransport()=> Transport.CreateTransport(TransportTypes.Car);
    }
}
