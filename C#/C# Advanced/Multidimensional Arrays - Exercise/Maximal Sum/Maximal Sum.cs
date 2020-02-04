using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];
            var matrix = new int[rows, cols];
            var biggestSum = int.MinValue;
            var indexRow = -1;
            var indexCol = -1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var numbers = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    var curSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                             matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                             matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (curSum > biggestSum)
                    {
                        biggestSum = curSum;
                        indexRow = i;
                        indexCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {biggestSum}");
            Console.WriteLine($"{matrix[indexRow, indexCol]} {matrix[indexRow, indexCol + 1]} {matrix[indexRow, indexCol + 2]}\n" +
                              $"{matrix[indexRow + 1, indexCol]} {matrix[indexRow + 1, indexCol + 1]} {matrix[indexRow + 1, indexCol + 2]}\n" +
                              $"{matrix[indexRow + 2, indexCol]} {matrix[indexRow + 2, indexCol + 1]} {matrix[indexRow + 2, indexCol + 2]}");
        }
    }
}