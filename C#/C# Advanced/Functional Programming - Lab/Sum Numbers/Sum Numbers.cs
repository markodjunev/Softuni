using System;
using System.Linq;

namespace Sum_Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }
    }
}