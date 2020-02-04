using System;
using System.Linq;

namespace Sort_Even_Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n);

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}