using Patterns.Transports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns.Composites
{
    internal class TransportComposite : Transport
    {
        List<Transport> transport = new List<Transport>();

        public TransportComposite(TransportTypes transportType) : base(transportType)
        {
        }

        public override Transport Clone()
        {
            throw new NotImplementedException();
        }

        public override void Add(Transport transport)
        {
            transport.Add(transport);
        }

        public override void Remove(Transport transport)
        {
            transport.Remove(transport);
        }
    }
}
