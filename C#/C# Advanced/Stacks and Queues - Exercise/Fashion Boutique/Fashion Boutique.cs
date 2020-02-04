using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse); // clothes
            var capacity = int.Parse(Console.ReadLine());
            var neededRacks = 1;
            var stack = new Stack<int>(input);
            var sum = 0;
            var remaining = 0;
            while (stack.Count > 0)
            {
                var curValue = stack.Pop();
                if (sum + curValue > capacity)
                {
                    sum = (sum + curValue) - capacity;
                    neededRacks++;
                }
                else if (sum + curValue == capacity)
                {
                    if (stack.Count > 0 && stack.Peek() > 0)
                    {
                        neededRacks++;
                        sum += curValue;
                    }
                }
                else
                    sum += curValue;
            }
            Console.WriteLine(neededRacks);
        }
    }
}