using System;
using System.Linq;

namespace Snake_Moves
{
    class Program
    {
        static void Main()
        {
            var dimensions = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];
            var snake = Console.ReadLine();
            var matrix = new char[rows, cols];
            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (counter >= snake.Length)
                        counter = 0;

                    matrix[i, j] = snake[counter++];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}