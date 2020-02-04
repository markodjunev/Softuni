using System;

namespace Train
{
    class Train
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}