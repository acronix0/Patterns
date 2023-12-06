using Patterns.Engines;
using System.Collections;
using System.Threading;

namespace Patterns.Transports
{
    public enum TransportTypes
    {
        Car,
        Truck
    }

    public abstract class Transport 
    {
        private TransportTypes transportType;
        private static Hashtable _registry = new Hashtable();
        protected void AddPrototype(Transport parTransport)
        {
            _registry[parTransport.transportType] = parTransport;
        }
        protected Transport(TransportTypes transportType)
        {
            this.transportType = transportType;
        }

        public abstract Transport Clone();
        protected void RemovePrototype(TransportTypes transportType)
        {
            _registry.Remove(transportType);
        }

        public string Name { get; set; }
        public IEngine Engine { get; set; }
        public double TankCapacity { get; set; }
        public double FuelConsumptionPer100Km { get; set; }
        public static Transport CreateTransport(TransportTypes parTransportType)
        {
            Transport transport = null;
            switch (parTransportType)
            {
                case TransportTypes.Car:
                    transport = (Car)_registry[parTransportType];
                    return transport.Clone();
                case TransportTypes.Truck:
                    transport = (Truck)_registry[parTransportType];
                    return transport.Clone();
            }

               
            return transport;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Транспортное средство: {Name}, вместимость бензобака: {TankCapacity}");
        }
        public virtual double CalculateFuelConsumption(double distance)
        {
            return distance / 100 * FuelConsumptionPer100Km;
        }
        public virtual double FuelConsumption()
        {
            return 0;
        }
    }
}
