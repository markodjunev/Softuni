using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var primarySum = 0;
            var secondarySum = 0;

            for (int i = 1; i <= n; i++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                primarySum += numbers[i - 1];
                secondarySum += numbers[numbers.Length - i];
            }
            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}