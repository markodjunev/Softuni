using System;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());

            int n2 = n1;
            int sum = 0;
            int factorial = 0;

            for (int i = n1; i > 0; i = i / 10)
            {
                factorial = 1;
                for (int j = 2; j <= i % 10; j++)
                {
                    factorial = factorial * j;
                }
                sum = sum + factorial;
            }

            if (sum == n2) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}