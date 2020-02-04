using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new []{ ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rows = input[0];
            var cols = input[1];
            var arr = new int[rows, cols];
            int sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var numbers = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += numbers[j];
                    arr[i, j] = numbers[j];
                }
            }

            Console.WriteLine($"{rows}\n{cols}\n{sum}");
        }
    }
}