using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            var cars=new List<Car>();

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split();
                var model = tokens[0];
                var engineSpeed = int.Parse(tokens[1]);
                var enginePower = int.Parse(tokens[2]);
                var cargoWeight = int.Parse(tokens[3]);
                var cargoType = tokens[4];
                var tire1Pressure = double.Parse(tokens[5]);
                var tire1Age = int.Parse(tokens[6]);
                var tire2Pressure = double.Parse(tokens[7]);
                var tire2Age = int.Parse(tokens[8]);
                var tire3Pressure = double.Parse(tokens[9]);
                var tire3Age = int.Parse(tokens[10]);
                var tire4Pressure = double.Parse(tokens[11]);
                var tire4Age = int.Parse(tokens[12]);
                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);

                var car = new Car(model, engine, cargo, new List<Tire>
                    {
                        new Tire(tire1Pressure, tire1Age), new Tire(tire2Pressure, tire2Age),
                        new Tire(tire3Pressure, tire3Age), new Tire(tire4Pressure, tire4Age)
                    });

                cars.Add(car);
            }

            var command = Console.ReadLine();

            switch (command)
            {
                case "fragile":
                    cars.Where(c => c.Cargo.CargoType == "fragile").Where(c => c.Tires.Any(t => t.TirePressure < 1))
                        .Select(c => c.Model).ToList().ForEach(m => Console.WriteLine(m));
                    break;
                case "flamable":
                    cars.Where(c => c.Cargo.CargoType == "flamable").Where(c => c.Engine.EnginePower > 250)
                        .Select(c => c.Model).ToList().ForEach(m => Console.WriteLine(m));
                    break;
            }
        }
    }
}