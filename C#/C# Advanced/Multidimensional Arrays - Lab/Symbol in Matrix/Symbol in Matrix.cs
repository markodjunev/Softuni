using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine().ToArray();
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = numbers[j];
                }
            }

            var symbol = char.Parse(Console.ReadLine());

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    var curSym = arr[i, j];
                    if (symbol.Equals(curSym))
                    {
                        Console.WriteLine($"({i}, {j})");
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}