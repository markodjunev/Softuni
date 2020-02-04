using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sum_Digits
{
    class Program
    {
        private static int Sum(int n)
        {
            int sum = 0;
            for (int i = n; i > 0; i/=10)
            {
                var lastDigit = i % 10;
                sum += lastDigit;
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