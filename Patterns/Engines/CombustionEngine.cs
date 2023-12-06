using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Engines
{
    internal class CombustionEngine : ICombustionEngine
    {
        public double EngineCapacity { get; private set; }
        public int Cylinders { get; private set; }
        public CombustionEngine(double engineCapacity, int cylinders)
        {
            EngineCapacity = engineCapacity;
            Cylinders = cylinders;
        }
        public void Ignite()
        {
            Console.WriteLine("Двигатель внутреннего сгорания запущен!");
        }

        public void Shutdown()
        {
            Console.WriteLine("Двигатель внутреннего сгорания остановлен!");
        }

        public void Refuel()
        {
            Console.WriteLine("Двигатель внутреннего сгорания заправлен!");
        }
    }
}
