using System;
using System.Collections.Generic;

namespace Auto_Repair_and_Service
{
    class Program
    {
        static void Main()
        {
            var cars = Console.ReadLine().Split();
            var queue = new Queue<string>(cars); // cars for service
            var input = Console.ReadLine();
            var servedCars = new Stack<string>();
            while (input != "End")
            {
                var tokens = input.Split('-');
                var command = tokens[0];
                if (command == "Service" && queue.Count > 0)
                {
                    var curCar = queue.Dequeue();
                    servedCars.Push(curCar);
                    Console.WriteLine($"Vehicle {curCar} got served.");
                }
                else if (command == "CarInfo")
                {
                    var curCar = tokens[1];
                    Console.WriteLine(queue.Contains(curCar) ? "Still waiting for service." : "Served.");
                }
                else if (command == "History")
                   Console.WriteLine(string.Join(", ", servedCars));

                input = Console.ReadLine();
            }

            if(queue.Count > 0)
                Console.WriteLine($"Vehicles for service: {string.Join(", ", queue)}");
            if(servedCars.Count > 0)
                Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
        }
    }
}