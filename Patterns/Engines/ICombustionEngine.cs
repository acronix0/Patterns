using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Engines
{
    internal interface ICombustionEngine
    {
        void Ignite();
        void Shutdown();
        void Refuel();
    }
}
