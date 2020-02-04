using System;
using System.Linq;

namespace Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            foreach (var item in arr.Reverse())
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}