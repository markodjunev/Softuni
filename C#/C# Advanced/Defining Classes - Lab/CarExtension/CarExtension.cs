using System;
using System.Text;
using CarExtension;

namespace CarManufacturer
{  
    public class CarExtension
    {
        static void Main()
        {
            var car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 8;
            car.Drive(200);
            Console.WriteLine(car.WhoAmI());
        }
    }
}