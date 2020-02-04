using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            var input = Console.ReadLine();
            var stack = new Stack<int>(numbers);


            while (input != "end")
            {
                var tokens = input.Split();
                var command = tokens[0];
                if (command == "add")
                {
                    for (int i = 1; i <= 2; i++)
                    {
                        var num = int.Parse(tokens[i]);
                        stack.Push(num);
                    }
                }
                else if (command == "remove")
                {
                    var countToRemove = int.Parse(tokens[1]);
                    if (countToRemove <= stack.Count)
                    {
                        for (int i = 0; i < countToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }                 
                }
                input = Console.ReadLine();
            }

            var sum = 0;

            foreach (var number in stack)
            {
                sum += number;
            }

            Console.WriteLine($"Sum: {sum}");

        }
    }
}