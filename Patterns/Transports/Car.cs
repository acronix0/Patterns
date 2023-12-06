using Patterns.Prototipes;

namespace Patterns.Transports
{
    public class Car : Transport, ITransportPrototype
    {
        public Car() 
            :base(TransportTypes.Car)
        {
            base.AddPrototype(this);
        }

        public override Transport Clone()
        {
            Car car = new Car();
            return car;
        }
        public string BodyType { get; set; }

        public void SetBodyType(string type)
        {
            BodyType = type;
        }

        public override double CalculateFuelConsumption(double distance)
        {
            return base.CalculateFuelConsumption(distance);
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override void Add(Transport transport)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Transport transport)
        {
            throw new NotImplementedException();
        }
    }
}
