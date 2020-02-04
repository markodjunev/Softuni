using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_Lot
{
    class Program
    {
        static void Main()
        {
            var cars = new HashSet<string>();
            var input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];
                var carLicense = tokens[1];

                if (command == "IN")
                    cars.Add(carLicense);

                if (command == "OUT")
                    cars.Remove(carLicense);

                input = Console.ReadLine();
            }

            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
                Console.WriteLine("Parking Lot is Empty");

        }
    }
}