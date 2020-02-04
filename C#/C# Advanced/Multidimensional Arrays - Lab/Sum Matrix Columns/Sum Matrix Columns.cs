using System;
using System.Linq;

namespace Sum_Matrix_Columns
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

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = numbers[j];
                }
            }

            for (int i = 0; i < arr.GetLength(1); i++)
            {
                int sum = 0;               
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    sum += arr[j, i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}