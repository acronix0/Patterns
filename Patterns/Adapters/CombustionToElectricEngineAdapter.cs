using Patterns.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapters
{
    class CombustionToElectricEngineAdapter : IEngine
    {
        ElectricEngine electricEngine;
        public CombustionToElectricEngineAdapter(ElectricEngine electricEngine)
        {
            this.electricEngine = electricEngine;
        }
        public void Ignite() => electricEngine.Start();
    }
}
