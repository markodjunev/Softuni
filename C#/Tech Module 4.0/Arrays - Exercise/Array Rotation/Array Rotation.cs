using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rotation = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotation; i++)
            {
                var temp = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = temp;
            }
            Console.Write(string.Join(" ", arr));
            Console.WriteLine();
        }
    }
}