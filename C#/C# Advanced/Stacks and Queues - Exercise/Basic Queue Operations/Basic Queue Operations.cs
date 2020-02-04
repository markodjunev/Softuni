using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var s = input[1];
            var x = input[2];
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(numbers);

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            Console.WriteLine(queue.Count == 0 ? "0" : queue.Contains(x) ? "true" : $"{queue.Min()}");
        }
    }
}