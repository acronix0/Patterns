using Patterns.Transports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Flyweights
{
    internal class FlyweightFactory
    {
        Dictionary<string, Transport> transports = new Dictionary<string, Transport>();
        public FlyweightFactory()
        {
            transports.Add("X", new Car());
            transports.Add("Y", new Truck());
        }
        public Transport GetTransport(string key)
        {
            if (!transports.ContainsKey(key))
                transports.Add(key, new Car());
            return transports[key] as Car;
        }

    }
}
