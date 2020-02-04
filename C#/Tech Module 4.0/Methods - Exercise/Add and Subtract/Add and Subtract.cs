using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var sum = Sum(a, b);
            var res = Substract(c, sum);
            Console.WriteLine(res); 
        }

        private static int Substract(int c, int sum)
        {
            return sum - c;
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}