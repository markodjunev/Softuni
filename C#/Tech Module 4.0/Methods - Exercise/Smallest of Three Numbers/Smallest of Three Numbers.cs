using System;
using System.Linq;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static int Smallest(int[] arr)
        {
            return arr.Min();
        }
        static void Main()
        {
            var arr = new int[3];
            arr[0] = int.Parse(Console.ReadLine());
            arr[1] = int.Parse(Console.ReadLine());
            arr[2] = int.Parse(Console.ReadLine());
            Console.WriteLine(Smallest(arr));
        }
    }
}