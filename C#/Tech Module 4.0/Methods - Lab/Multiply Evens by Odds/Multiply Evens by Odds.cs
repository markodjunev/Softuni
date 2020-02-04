using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        private static long Sum(long n)
        {
            long sumEven = 0;
            long sumOdd = 0;
            for (long i = Math.Abs(n); i > 0; i/=10)
            {
                long digit = i % 10;
                if (digit % 2 == 0)
                    sumEven += digit;
                else
                    sumOdd += digit;                
            }
            var sum = sumEven * sumOdd;
            return sum;
        }
        static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            long sum = Sum(n);
            Console.WriteLine(sum);
        }
    }
}