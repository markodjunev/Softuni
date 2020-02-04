using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n, n];
            int diagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                diagonalSum += numbers[i];
            }
            Console.WriteLine(diagonalSum);
        }
    }
}