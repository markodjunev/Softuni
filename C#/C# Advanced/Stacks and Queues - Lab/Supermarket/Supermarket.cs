using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Supermarket
    {
        static void Main()
        {
            var queue = new Queue<string>();
            var input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    var count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }

                else
                    queue.Enqueue(input);

                input = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");

        }
    }
}