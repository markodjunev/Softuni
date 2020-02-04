using System;
using System.Linq;

namespace Square_With_Maximum_Sum
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rows = input[0];
            var cols = input[1];
            var arr = new int[rows, cols];
            var biggestPair = new int[2, 2];
            var biggestSum = int.MinValue;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var numbers = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = numbers[j];
                }
            }

            int sum;
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    sum = arr[i, j] + arr[i, j+1] + arr[i+1, j] + arr[i+1, j+1];
                    if (sum > biggestSum)
                    {
                        biggestSum = sum;
                        biggestPair[0, 0] = arr[i, j];
                        biggestPair[0, 1] = arr[i, j+1];
                        biggestPair[1, 0] = arr[i+1, j];
                        biggestPair[1, 1] =arr[i+1,j+1];
                    }
                }
            }

            Console.WriteLine($"{biggestPair[0, 0]} {biggestPair[0, 1]}" +
                              $"\n{biggestPair[1, 0] } {biggestPair[1, 1]}" +
                              $"\n{biggestSum}");

        }
    }
}