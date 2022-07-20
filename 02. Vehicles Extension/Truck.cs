using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption + 1.6, tankCapacity)
        {
        }

        public override void Refuel(double refuel)
        {
            if (refuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (refuel + this.FuelQuantity > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {refuel} fuel in the tank");
            }
            refuel  *= 0.95;
            base.Refuel(refuel);
        }
    }
}
