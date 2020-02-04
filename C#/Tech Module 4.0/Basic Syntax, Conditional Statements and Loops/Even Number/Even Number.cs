using System;

namespace Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(n)}");
                return;
            }
            while (n % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                n = int.Parse(Console.ReadLine());
            }
                Console.WriteLine($"The number is: {Math.Abs(n)}");
        }
    }
}