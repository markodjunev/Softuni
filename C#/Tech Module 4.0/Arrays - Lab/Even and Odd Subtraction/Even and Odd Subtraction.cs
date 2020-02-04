using System;
using System.Linq;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main()
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0) sumEven += n[i];
                else sumOdd += n[i];
            }
            Console.WriteLine(sumEven-sumOdd);
        }
    }
}