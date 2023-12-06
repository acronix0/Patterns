using Patterns.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractTransports
{
    public class AbstractCar : Transport
    {
        public AbstractCar(TransportTypes transportType) : base(transportType)
        {
        }

        public override Transport Clone()
        {
            throw new NotImplementedException();
        }
    }
}
