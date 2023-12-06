using Patterns.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builders
{
    internal class ElectricEngineBuilder
    {
        private double power;
        private double torque;
        private double batteryCapacity;

        public ElectricEngineBuilder SetPower(double power)
        {
            this.power = power;
            return this;
        }

        public ElectricEngineBuilder SetTorque(double torque)
        {
            this.torque = torque;
            return this;
        }

        public ElectricEngineBuilder SetBatteryCapacity(double batteryCapacity)
        {
            this.batteryCapacity = batteryCapacity;
            return this;
        }

        public ElectricEngine Build()
        {
            return new ElectricEngine(power, torque, batteryCapacity);
        }
    }
}
