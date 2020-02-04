using System;
using System.Linq;

namespace Hotel_Reservation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var pricePerDay = decimal.Parse(items[0]);
            var numberOfDays = int.Parse(items[1]);
            var season = (Season)Enum.Parse(typeof(Season), items[2]);
            var discountType = DiscountType.None;

            if (items.Length == 4)
            {
                discountType = (DiscountType)Enum.Parse(typeof(DiscountType), items[3]);
            }

            PriceCalculator calculator = new PriceCalculator(pricePerDay, numberOfDays, season, discountType);
            Console.WriteLine($"{calculator.CalculatePrice():F2}");
        }
    }
}