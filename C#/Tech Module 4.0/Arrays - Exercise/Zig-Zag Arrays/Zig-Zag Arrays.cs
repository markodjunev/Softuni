using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arr1 = new int[n];
            var arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    arr1[i] = input[0];
                    arr2[i] = input[1];
                }
                else
                {
                    arr1[i] = input[1];
                    arr2[i] = input[0];
                }              
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}