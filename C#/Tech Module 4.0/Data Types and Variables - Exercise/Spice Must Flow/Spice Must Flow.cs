using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main()
        {
            var yield = int.Parse(Console.ReadLine());
            var currentYield = 0;
            var days = 0;
            var workersConsume = 26;
            var total = 0;
            var isProfitable = false;
            while (yield >= 100)
            {
                currentYield = yield - workersConsume;
                total += currentYield;
                yield -= 10;
                days++;
                isProfitable = true;
            }
            if (isProfitable == false)
            {
                Console.WriteLine(days);
                Console.WriteLine(total);
            }
            else
            {
                total -= workersConsume;
                Console.WriteLine(days);
                Console.WriteLine(total);
            }
           
        }
    }
}