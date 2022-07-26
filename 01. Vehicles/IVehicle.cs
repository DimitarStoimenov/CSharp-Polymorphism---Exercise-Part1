﻿namespace Vehicles
{
    public interface IVehicle
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumption  { get; set; }

        public void Drive(double km);

        public void Refuel(double refuel);
    }
}
