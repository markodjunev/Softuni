using System;
using System.Linq;

namespace Squares_in_Matrix
{
    class Program
    {
        static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new char[dimensions[0]][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray().Where(c => c != ' ').ToArray();
            }


            var pairs = 0;

            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    if (matrix[i][j] == matrix[i][j + 1] &&
                        matrix[i][j] == matrix[i + 1][j] &&
                        matrix[i][j] == matrix[i + 1][j + 1])
                    {
                        pairs++;
                    }
                }
            }

            Console.WriteLine(pairs);
        }
    }
}