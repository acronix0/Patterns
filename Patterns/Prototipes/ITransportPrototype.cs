using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Transports;

namespace Patterns.Prototipes
{
    interface ITransportPrototype
    {
        public abstract Transport Clone();
    }
}
