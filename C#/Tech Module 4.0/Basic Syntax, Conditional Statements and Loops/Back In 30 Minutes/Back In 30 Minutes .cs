using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main()
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            if ((hour >= 0 && hour < 24) && (min >= 0 && min < 60))
            {
                min = min + 30;
                if (min < 60)
                {
                    if (min < 10)
                    {
                        Console.WriteLine($"{hour}:0{min}");
                        return;
                    }
                    if (min > 10)
                    {
                        Console.WriteLine($"{hour}:{min}");
                        return;

                    }
                }
                if (min > 59)
                {
                    hour++;
                    if (hour > 23) hour = 0;
                    min = min - 60;
                    if (min < 10)
                    {
                        Console.WriteLine($"{hour}:0{min}");
                        return;
                    }
                    if (min > 10)
                    {
                        Console.WriteLine($"{hour}:{min}");
                        return;

                    }
                }
            }
        }
    }
}