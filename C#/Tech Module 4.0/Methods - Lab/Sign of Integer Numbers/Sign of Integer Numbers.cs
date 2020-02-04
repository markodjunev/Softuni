using System;

namespace Sign_of_Integer_Numbers
{
    class Program
    {
        static void Number(int n)
        {
            if(n > 0)
                Console.WriteLine($"The number {n} is positive.");
            else if (n < 0)
                Console.WriteLine($"The number {n} is negative.");
            else
                Console.WriteLine($"The number {n} is zero.");
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Number(n);
        }
    }
}