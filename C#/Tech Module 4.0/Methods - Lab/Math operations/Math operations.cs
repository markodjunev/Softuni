using System;

namespace Math_operations
{
    class Program
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var command = char.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var res = 0;
            switch (command)
            {
                case '+': res = Add(a, b); break;
                case '-': res = Subtract(a, b); break;
                case '*': res = Multiply(a, b); break;
                case '/': res = Divide(a, b); break;
            }
            Console.WriteLine(res);
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }
        private static int Subtract(int a, int b)
        {
            return a - b;
        }
        private static int Multiply(int a, int b)
        {
            return a * b;
        }
        private static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}