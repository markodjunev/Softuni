using System;

namespace _04._Pascal_Triangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var arr1 = new int[1];
            Console.WriteLine(1);
            arr1[0] = 1;

            for (int i = 0; i < n - 1; i++)
            {
                var arr2 = new int[arr1.Length + 1];
                arr2[0] = 1;
                for (int j = 1; j < arr1.Length; j++)
                {
                    arr2[j] = arr1[j - 1] + arr1[j];
                }
                arr2[arr2.Length - 1] = 1;
                Console.WriteLine(string.Join(" ", arr2));
                arr1 = arr2;
            }
            
        }
    }
}