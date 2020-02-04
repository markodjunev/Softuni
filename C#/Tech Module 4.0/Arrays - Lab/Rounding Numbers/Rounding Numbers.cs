using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                var x = Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arr[i]} => {x}");
            }           
        }
    }
}