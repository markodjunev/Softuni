using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var symbol = Console.ReadLine();
                sum += symbol[0];
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}