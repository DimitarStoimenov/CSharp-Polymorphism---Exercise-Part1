namespace Vehicles
{
    public interface IVehicle
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumption  { get; set; }

        public double TankCapacity { get;}

        public void BusIncrease(double km);
        public void Drive(double km);

        public void Refuel(double refuel);




    }
}
