using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (b > 10)
            {
                Console.WriteLine($"{a} X {b} = {a * b}");
                return;
            }
            if (b <= 10)
            {
                for (int i = b; i <= 10; i++)
                {
                    Console.WriteLine($"{a} X {i} = {a * i}");
                }
            }
        }
    }
}