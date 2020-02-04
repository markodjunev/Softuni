using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main()
        {
            var foodQuantity = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse);
            var queue = new Queue<int>(orders);
            var biggestOrder = queue.Max();

            while (queue.Count != 0)
            {
                var curOrder = queue.Peek();

                if (foodQuantity - curOrder >= 0)
                { 
                    foodQuantity -= curOrder;
                    queue.Dequeue();
                }

                else
                {
                    Console.WriteLine(biggestOrder);
                    Console.Write("Orders left: ");
                    Console.Write(string.Join(" ", queue));
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine(biggestOrder);
            Console.WriteLine("Orders complete");
        }
    }
}