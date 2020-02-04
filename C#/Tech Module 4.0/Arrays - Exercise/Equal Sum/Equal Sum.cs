using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }
                for (int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}