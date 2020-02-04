using System;
using System.Collections.Generic;
using System.Linq;

namespace From_Left_to_The_Right
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = 0;
                var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
                long res = Math.Abs(numbers.Max());
                for (long j = res; j > 0; j/=10)
                {                   
                    sum += j % 10;
                }
                Console.WriteLine(sum);
            }
        }
    }
}