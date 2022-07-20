using System;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();

            double fuelQuantity = double.Parse(carInput[1]);
            double litersPerKm = double.Parse(carInput[2]);
            double tankCapacity = double.Parse(carInput[3]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckLitersPerKm = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            double busFuelQuantity = double.Parse(busInfo[1]);
            double busLitersPerKm = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);



            IVehicle car = new Car(fuelQuantity, litersPerKm, tankCapacity);
            IVehicle truck = new Truck(truckFuelQuantity, truckLitersPerKm, truckTankCapacity);
            IVehicle bus = new Bus(busFuelQuantity, busLitersPerKm, busTankCapacity);


            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();
                string typeCommand = input[0];
                string typeVahicle = input[1];

                try
                {
                    if (typeCommand == "Drive")
                    {
                        double kmToDrive = double.Parse(input[2]);

                        if (typeVahicle == "Car")
                        {
                            car.Drive(kmToDrive);
                        }
                        else if (typeVahicle == "Truck")
                        {
                            truck.Drive(kmToDrive);
                        }
                        else if (typeVahicle == "Bus")
                        {
                            
                            bus.BusIncrease(kmToDrive);
                           

                        }
                    }
                    else if (typeCommand == "Refuel")
                    {
                        double refuel = double.Parse(input[2]);

                        if (typeVahicle == "Car")
                        {
                            car.Refuel(refuel);
                        }
                        else if (typeVahicle == "Truck")
                        {
                            truck.Refuel(refuel);
                        }
                        else if (typeVahicle == "Bus")
                        {
                            bus.Refuel(refuel);
                        }
                    }

                    else if (typeCommand == "DriveEmpty")
                    {
                        double kmto = double.Parse(input[2]);
                        bus.Drive(kmto);
                    }

                }
                catch (Exception ae)
                {

                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
            
        }
    }
}
