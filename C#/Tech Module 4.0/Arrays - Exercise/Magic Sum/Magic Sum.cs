using System;
using System.Linq;

namespace Magic_Sum
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var n = long.Parse(Console.ReadLine());

            for (long i = 0; i < arr.Length - 1; i++)
            {
                for (long j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == n)
                        Console.WriteLine(arr[i] + " " + arr[j]);
                }              
            }
        }
    }
}