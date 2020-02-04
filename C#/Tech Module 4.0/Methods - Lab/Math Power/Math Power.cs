using System;

namespace Math_Power
{
    class Program
    {
        static double Power(double a, double b)
        {
            double res = Math.Pow(a, b);
            return res;
        }
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var res = Power(a, b);
            Console.WriteLine(res);
        }
    }
}