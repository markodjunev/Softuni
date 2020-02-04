using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    class Calculations
    {
        static void Main()
        {
            var command = Console.ReadLine();
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var res = 0;
            switch (command)
            {
                case "add": res = Add(a, b); break;
                case "subtract": res = Subtract(a, b); break;
                case "multiply": res = Multiply(a, b); break;
                case "divide": res = Divide(a, b); break;
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