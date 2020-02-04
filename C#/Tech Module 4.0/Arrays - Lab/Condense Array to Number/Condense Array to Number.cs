using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main()
        {
            var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            if (arr1.Length == 1)
            {
                Console.WriteLine(arr1[0]);
                return;
            }
            else if (arr1.Length == 2)
            {
                Console.WriteLine(arr1[0] + arr1[1]);
                return;
            }

            while (arr1.Length > 2)
            {
                var arr2 = new int[arr1.Length - 1];
                for (int i = 0; i < arr1.Length - 1; i++)
                {
                    arr2[i] = arr1[i] + arr1[i + 1];
                }
                arr1 = arr2;
            }
            sum = arr1[0] + arr1[1];
            Console.WriteLine(sum);
        }
    }
}