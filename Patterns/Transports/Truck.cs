﻿namespace Patterns.Transports
{
    public class Truck : Transport
    {
        public Truck() 
            : base(TransportTypes.Truck)
        {
            base.AddPrototype(this);
        }

        public double LoadCapacity { get; set; }

        public void SetLoadCapacity(double capacity)
        {
            LoadCapacity = capacity;
        }
        public override double CalculateFuelConsumption(double distance)
        {
            return base.CalculateFuelConsumption(distance);
        }

        public override Transport Clone() => new Truck();

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
