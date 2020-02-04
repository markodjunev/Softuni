using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main()
        {
            var num1 = long.Parse(Console.ReadLine());
            var num2 = long.Parse(Console.ReadLine());
            var f1 = Factorial(num1);
            var f2 = Factorial(num2);
            var res = f1 / f2;
            Console.WriteLine($"{res:f2}");
        }

        public static double Factorial(double num)
        {
            double sum = 1;
            for (double i = 2; i <= num; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}