using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine()); // n queries
            var stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var command = input[0];

                switch (command)
                {
                    case 1: stack.Push(input[1]); break;
                    case 2:
                        if (stack.Count > 0)
                            stack.Pop();
                        break;
                    case 3:
                        if (stack.Count > 0)
                            Console.WriteLine(stack.Max());
                        break;
                    case 4:
                        if(stack.Count > 0)
                            Console.WriteLine(stack.Min());
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}