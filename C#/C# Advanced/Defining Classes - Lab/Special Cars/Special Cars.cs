using System;
using System.Collections.Generic;
using System.Linq;

namespace Special_Cars
{
    class Program
    {
        static void Main()
        {
            var tireList = new List<Tire[]>();
            var engineList = new List<Engine>();
            var carList = new List<Car>();
            string tireInfo = Console.ReadLine();
            
            while (tireInfo != "No more tires!")
            {
                var currentTyre = tireInfo.Split();

                var currentSet = new Tire[4]
                {
                    new Tire(int.Parse(currentTyre[0]),double.Parse(currentTyre[1])),
                    new Tire(int.Parse(currentTyre[2]),double.Parse(currentTyre[3])),
                    new Tire(int.Parse(currentTyre[4]),double.Parse(currentTyre[5])),
                    new Tire(int.Parse(currentTyre[6]),double.Parse(currentTyre[7])),
                };

                tireList.Add(currentSet);
                tireInfo = Console.ReadLine();
            }

            var engineInfo = Console.ReadLine();

            while (engineInfo != "Engines done")
            {
                var curEngine = engineInfo.Split();
                Engine engine = new Engine(int.Parse(curEngine[0]), double.Parse(curEngine[1]));

                engineList.Add(engine);

                engineInfo = Console.ReadLine();
            }
            var carInfo = Console.ReadLine();

            while (carInfo != "Show special")
            {
                var currentCar = carInfo.Split();
                string make = currentCar[0];
                string model = currentCar[1];
                int year = int.Parse(currentCar[2]);
                double fuelQuantity = double.Parse(currentCar[3]);
                double fuelConsumption = double.Parse(currentCar[4]);
                int engineIndex = int.Parse(currentCar[5]);
                int tiresIndex = int.Parse(currentCar[6]);


                Car car = new Car(
                    make,
                    model,
                    year,
                    fuelQuantity,
                    fuelConsumption,
                    engineList.ElementAt(engineIndex),
                    tireList.ElementAt(tiresIndex));

                carList.Add(car);

                carInfo = Console.ReadLine();
            }

            var filteredCarList = carList
                .Where(x => x.Year == 2017)
                .Where(x => x.Engine.HorsePower >= 330)
                .Where(x => x.Tires.Select(y => y.Pressure).Sum() >= 9)
                .Where(x => x.Tires.Select(y => y.Pressure).Sum() <= 10)
                .ToList();

            foreach (var car in filteredCarList)
            {
                car.Drive(20);

                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}