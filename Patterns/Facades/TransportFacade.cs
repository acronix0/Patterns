using Patterns.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facades
{
    internal class TransportFacade
    {
        Truck truck;
        Car car;

        public TransportFacade(Truck truck, Car car)
        {
            this.truck = truck;
            this.car = car;
        }

        public void CalculateFuelConsumption(double distance)
        {
            truck.CalculateFuelConsumption(12);
        }
        public void ShowInfo()
        {
            car.ShowInfo();
        }
    }

}

