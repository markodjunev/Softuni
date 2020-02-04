using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main()
        {
            var count = int.Parse(Console.ReadLine()); //the number of cars that can pass during a green light
            var queue = new Queue<string>();
            var passedCars = 0;
            var input = Console.ReadLine();

            while (input != "end")
            {
                if (input == "green")
                {
                    if (queue.Count > count || queue.Count == count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            var car = queue.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            passedCars++;
                        }
                    }
                    else
                    {
                        while (queue.Count != 0)
                        {
                            var car = queue.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            passedCars++;
                        }
                    }
                }

                else
                    queue.Enqueue(input);

                input = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}