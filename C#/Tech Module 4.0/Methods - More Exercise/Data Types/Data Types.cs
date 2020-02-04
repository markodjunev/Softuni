using System;

namespace Data_Types
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            PrintType(input);
        }

        private static void PrintType(string input)
        {
            if (input == "int")
            {
                var n = int.Parse(Console.ReadLine());
                Console.WriteLine($"{n * 2}");
            }
            else if (input == "real")
            {
                var n = double.Parse(Console.ReadLine());
                Console.WriteLine($"{n*1.5:f2}");
            }
            else if (input == "string")
            {
                var text = Console.ReadLine();
                Console.WriteLine($"${text}$");
            }
        }
    }
}