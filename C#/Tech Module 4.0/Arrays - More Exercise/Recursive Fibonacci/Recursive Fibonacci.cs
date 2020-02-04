using System;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var f1 = 0;
            var f2 = 1;
            var temp = 0;
            for (int i = 0; i < n; i++)
            {
                temp = f1 + f2;
                f1 = f2;
                f2 = temp;
 
            }
            Console.WriteLine(f1);
        }
    }
}