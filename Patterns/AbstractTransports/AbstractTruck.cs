using Patterns.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractTransports
{
    public class AbstractTruck : Transport
    {
        public AbstractTruck(TransportTypes transportType) 
            : base(transportType)
        {
        }

        public override void Add(Transport transport)
        {
            throw new NotImplementedException();
        }

        public override Transport Clone()
        {
            throw new NotImplementedException();
        }

        public override void Remove(Transport transport)
        {
            throw new NotImplementedException();
        }
    }
}
