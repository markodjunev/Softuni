using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var petrolPumps = new Queue<int[]>();

            for (int i = 0; i < count; i++)
            {
                var petrolPump = Console.ReadLine().Split().Select(int.Parse).ToArray();
                petrolPumps.Enqueue(petrolPump);
            }

            var index = 0;
            
            while (true)
            {
                var totalFuel = 0;
                foreach (var petrolPump in petrolPumps)
                {
                    var curFuel = petrolPump[0];
                    var distance = petrolPump[1];

                    totalFuel += curFuel - distance;
                    if (totalFuel < 0)
                    {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        index++;
                        break;
                    }                  
                }

                if (totalFuel >= 0)
                    break;
             
            }
            Console.WriteLine(index);
        }
    }
}