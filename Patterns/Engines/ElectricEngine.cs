using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Engines
{
    internal class ElectricEngine: IElectricEngine
    {
        public double Power { get; private set; }
        public double Torque { get; private set; }
        public double BatteryCapacity { get; private set; }

        public ElectricEngine(double power, double torque, double batteryCapacity)
        {
            Power = power;
            Torque = torque;
            BatteryCapacity = batteryCapacity;
        }
        public void Start()
        {
            Console.WriteLine("Электродвигатель запущен!");
        }

        public void Stop()
        {
            Console.WriteLine("Электродвигатель остановлен!");
        }


        public void Recharge()
        {
            Console.WriteLine("Электродвигатель перезаряжен!");
        }
    }
}
