using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var s = input[1];
            var x = input[2];
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(numbers);

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            Console.WriteLine(stack.Count == 0 ? "0" : stack.Contains(x) ? "true" : $"{stack.Min()}");
        }
    }
}