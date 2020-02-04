using System;
using System.Collections.Generic;
using System.Linq;

namespace Speed_Racing
{
    public class StartUp
    {
        public static void Main()
        {
            int countOfCars = int.Parse(Console.ReadLine());
            var cars = new HashSet<Car>();
            for (int i = 0; i < countOfCars; i++)
            {
                var input = Console.ReadLine();
                var tokens = input.Split();
                var model = tokens[0];
                var fuelAmount = double.Parse(tokens[1]);
                var fuelConsumptionPerKilometer = double.Parse(tokens[2]);
                var car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command.Split();
                var model = tokens[1];
                var amountOfKm = double.Parse(tokens[2]);

                var curCar = cars.First(x => x.Model == model);
                if(curCar.Drive(amountOfKm) == false)
                    Console.WriteLine("Insufficient fuel for the drive");


                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }

        }
    }
}