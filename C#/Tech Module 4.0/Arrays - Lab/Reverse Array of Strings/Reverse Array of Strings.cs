using System;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            Array.Reverse(input);
            foreach (var item in input)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}