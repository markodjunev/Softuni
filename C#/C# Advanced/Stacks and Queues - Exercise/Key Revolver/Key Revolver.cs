using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main()
        {
            var priceBullet = int.Parse(Console.ReadLine());
            var size = int.Parse(Console.ReadLine());
            var bullets = Console.ReadLine().Split().Select(int.Parse);
            var locks = Console.ReadLine().Split().Select(int.Parse);
            var value = int.Parse(Console.ReadLine());

            var stack = new Stack<int>(bullets);
            var queue = new Queue<int>(locks);

            var usedBullets = 0;
            var shoot = 0;
            while (stack.Any() && queue.Any())
            {
                var curBullet = stack.Peek();
                var curLock = queue.Peek();

                if (curBullet > curLock)
                {
                    Console.WriteLine("Ping!");
                    usedBullets++;
                    shoot++;
                    stack.Pop();
                }

                else if(curBullet <= curLock)
                {
                    Console.WriteLine("Bang!");
                    usedBullets++;
                    shoot++;
                    stack.Pop();
                    queue.Dequeue();
                }

                if (shoot == size && stack.Any())
                {
                    Console.WriteLine("Reloading!");
                    shoot = 0;
                }
            }

            if (queue.Count == 0)
                Console.WriteLine($"{stack.Count} bullets left. Earned ${value - (priceBullet * usedBullets)}");
            else
                Console.WriteLine($"Couldn't get through. Locks left: {queue.Count}");

        }
    }
}