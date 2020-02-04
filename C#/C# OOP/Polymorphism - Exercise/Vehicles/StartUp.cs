using System;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
            var car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            var truckInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = input[0];
                var vehicleType = input[1];
                if (command == "Drive")
                {
                    var km = double.Parse(input[2]);
                    switch (vehicleType)
                    {
                        case "Car": Console.WriteLine(car.Drive(km)); break;
                        case "Truck": Console.WriteLine(truck.Drive(km)); break;
                    }
                }
                else if (command == "Refuel")
                {
                    var fuel = double.Parse(input[2]);
                    switch (vehicleType)
                    {
                        case "Car": car.Refuel(fuel); break;
                        case "Truck": truck.Refuel(fuel); break;
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}