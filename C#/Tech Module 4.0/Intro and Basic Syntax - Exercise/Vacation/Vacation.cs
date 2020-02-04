using System;

namespace Vacation
{
    class Vacation
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            if (type == "Students")
            {
                if (day == "Friday") price = 8.45;
                if (day == "Saturday") price = 9.80;
                if (day == "Sunday") price = 10.46;
                if (n >= 30) price *= 0.85;

            }
            if (type == "Business")
            {
                if (day == "Friday") price = 10.90;
                if (day == "Saturday") price = 15.60;
                if (day == "Sunday") price = 16.00;
                if (n >= 100) n = n - 10;

            }
            if (type == "Regular")
            {
                if (day == "Friday") price = 15;
                if (day == "Saturday") price = 20;
                if (day == "Sunday") price = 22.50;
                if (n >= 10 && n <= 20) price *= 0.95;

            }
            double totalPrice = price * n;
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}