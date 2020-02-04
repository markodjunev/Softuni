<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main()
        {
            var names = Console.ReadLine().Split();
            var count = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(names);

            while (queue.Count > 1)
            {
                for (int i = 1; i < count; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
=======
﻿using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main()
        {
            var names = Console.ReadLine().Split();
            var count = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(names);

            while (queue.Count > 1)
            {
                for (int i = 1; i < count; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
>>>>>>> 6f4f235c52a7e08aaadcb7b47dd53dd6dfd4e3cb
}