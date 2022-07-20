using System;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {

        private double fuelQuantity;
        private double fuelConsumption;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;

        }

        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            set
            {

                if (value > this.TankCapacity)
                {
                    value = 0;
                }
                this.fuelQuantity = value;
            }
        }
        public virtual double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }
        public virtual double TankCapacity { get; set; }
        public virtual void BusIncrease(double km)
        {
           
        }
        
        public void Drive(double km)
        {
            if (FuelQuantity - km * this.FuelConsumption < 0)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            FuelQuantity -= km * FuelConsumption;
            Console.WriteLine($"{this.GetType().Name} travelled {km} km");
        }

        public virtual void Refuel(double refuel)
        {
            if (refuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (refuel + this.FuelQuantity > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {refuel} fuel in the tank");
            }
            FuelQuantity += refuel;

        }


    }
}
