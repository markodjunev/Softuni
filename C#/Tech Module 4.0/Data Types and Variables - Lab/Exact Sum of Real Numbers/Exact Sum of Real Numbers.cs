using System;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        private static decimal Sum(int n)
        {
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = decimal.Parse(Console.ReadLine());
                sum += num;
            }
            return sum;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(n));
            
        }
    }
}