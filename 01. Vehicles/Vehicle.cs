using System;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get ; set; }
        public virtual double FuelConsumption { get ; set; }

        public void Drive(double km)
        {
            if (FuelQuantity - km * FuelConsumption <= 0)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            FuelQuantity -= km * FuelConsumption;
            Console.WriteLine($"{this.GetType().Name} travelled {km} km");
        }

        public virtual void Refuel(double refuel)
        {
            FuelQuantity += refuel;

        }

        
    }
}
