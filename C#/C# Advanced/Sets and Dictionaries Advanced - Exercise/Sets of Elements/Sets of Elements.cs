using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstLength = numbers[0];
            var secondLength = numbers[1];

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < firstLength; i++)
            {
                var num = int.Parse(Console.ReadLine());
                firstSet.Add(num);
            }

            for (int i = 0; i < secondLength; i++)
            {
                var num = int.Parse(Console.ReadLine());
                secondSet.Add(num);
            }

            Console.WriteLine(string.Join(" ", firstSet.Intersect(secondSet)));
        }
    }
}