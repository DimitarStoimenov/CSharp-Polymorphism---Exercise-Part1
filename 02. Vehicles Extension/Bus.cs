using System;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        public override void BusIncrease(double km)
        {
            if (FuelQuantity - km * (this.FuelConsumption + 1.4) < 0)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            FuelQuantity -= km * (FuelConsumption + 1.4);
            Console.WriteLine($"{this.GetType().Name} travelled {km} km");
        }
    }
}
