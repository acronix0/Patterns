using Patterns.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Proxies
{
    internal class TransportProxy:IDisposable
    {
        public List<Car> Cars;
        public List<Truck> Trucks;
       
        public TransportProxy()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public Car GetCar(int TankCapacity)
        {
            Car car = Cars.FirstOrDefault(i => i.TankCapacity == TankCapacity);
            if (car == null)
                Cars.Add(car);
            return car;
        }

        public Truck GetInsurancePolicie(int TankCapacity)
        {
            Truck truck = Trucks.FirstOrDefault(i => i.TankCapacity == TankCapacity);
            if (truck == null)
                Trucks.Add(truck);
            return truck;
        }

        public void Dispose()
        {
            Trucks.Clear();
            Cars.Clear();
        }
    }
}
