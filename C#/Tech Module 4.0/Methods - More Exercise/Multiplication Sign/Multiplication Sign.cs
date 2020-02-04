using System;

namespace Multiplication_Sign
{
    class Program
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var type = Multiply(a, b, c);
            Console.WriteLine(type);
        }

        private static string Multiply(int a, int b, int c)
        {
            var res = a * b * c;
            if (res < 0)
                return "negative";

            else if (res > 0)
                return "positive";
            else
                return "zero";            
        }
    }
}