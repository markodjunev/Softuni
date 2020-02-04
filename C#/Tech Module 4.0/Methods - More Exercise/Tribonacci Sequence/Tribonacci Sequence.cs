using System;

namespace Tribonacci_Sequence
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var f1 = 1;
            var f2 = 1;
            var f3 = 2;

            for (int i = 0; i < n; i++)
            {
                Console.Write(f1 + " ");
                var fNext = f1 + f2 + f3;
                f1 = f2;
                f2 = f3;
                f3 = fNext;
            }
            Console.WriteLine();
        }
    }
}