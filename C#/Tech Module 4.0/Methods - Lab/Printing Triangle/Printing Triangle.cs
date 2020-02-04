using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Triangle(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Triangle(n);
        }
    }
}