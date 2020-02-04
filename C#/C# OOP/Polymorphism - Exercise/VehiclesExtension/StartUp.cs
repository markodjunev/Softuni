using System;

namespace VehiclesExtension
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), int.Parse(carInfo[3]));
            var truckInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), int.Parse(truckInfo[3]));
            var busInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), int.Parse(busInfo[3]));
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
                        case "Bus": bus.IsEmpty("Drive"); Console.WriteLine(bus.Drive(km)); break;
                    }
                }
                else if (command == "DriveEmpty")
                {
                    var km = double.Parse(input[2]);
                    bus.IsEmpty("DriveEmpty");
                    Console.WriteLine(bus.Drive(km));
                }
                else if (command == "Refuel")
                {
                    var fuel = double.Parse(input[2]);
                    switch (vehicleType)
                    {
                        case "Car": car.Refuel(fuel); break;
                        case "Truck": truck.Refuel(fuel); break;
                        case "Bus": bus.Refuel(fuel); break;
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}