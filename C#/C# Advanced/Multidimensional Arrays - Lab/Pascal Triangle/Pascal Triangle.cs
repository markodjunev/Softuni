using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var arr = new long[n][];
            arr[0]= new long[1];
            arr[0][0] = 1;
            Console.WriteLine(1);
            for (int i = 1; i < n; i++)
            {
                arr[i] = new long[i + 1];
                arr[i][0] = 1;
                for (int j = 1; j < arr[i].Length-1; j++)
                {
                    arr[i][j] = arr[i - 1][j] + arr[i - 1][j - 1];
                }

                arr[i][arr[i].Length - 1] = 1;
                Console.WriteLine(string.Join(" ",arr[i]));
            }
        }
    }
}