using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];
            var matrix = new string[rows, cols];


            for (int i = 0; i < rows; i++)
            {
                var numbers = Console.ReadLine().Split();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            var input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];

                if (command == "swap" && tokens.Length == 5)
                {
                    var row1 = int.Parse(tokens[1]);
                    var col1 = int.Parse(tokens[2]);
                    var row2 = int.Parse(tokens[3]);
                    var col2 = int.Parse(tokens[4]);

                    if (row1 >= rows || col1 >= cols || row2 >= rows || col2 >= cols)
                        Console.WriteLine("Invalid input!");
                    else
                    {
                        var num1 = matrix[row1, col1];
                        var num2 = matrix[row2, col2];
                        matrix[row1, col1] = num2;
                        matrix[row2, col2] = num1;
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write(matrix[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }


                }
                else
                    Console.WriteLine("Invalid input!");


                input = Console.ReadLine();
            }

        }
    }
}