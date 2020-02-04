using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int res = (a + b) / c;
            Console.WriteLine(res * d);
        }
    }
}