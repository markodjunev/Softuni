using System;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(numbers);
            Array.Reverse(numbers);
            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
                count++;
                if (count == 3)
                    break;
            }
            Console.WriteLine();
        }
    }
}
