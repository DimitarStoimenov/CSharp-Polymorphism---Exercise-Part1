using System;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine().Split();
            double fuelQuantity = double.Parse(carInput[1]);
            double litersPerKm = double.Parse(carInput[2]);

            string[] truckInfo = Console.ReadLine().Split();
            double truckQuantity = double.Parse(truckInfo[1]);
            double truckLitersPerKm = double.Parse(truckInfo[2]);

            IVehicle car = new Car(fuelQuantity, litersPerKm);
            IVehicle truck = new Truck(truckQuantity, truckLitersPerKm);

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
                    }

                }
                catch (Exception ae)
                {

                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            
        }
    }
}
