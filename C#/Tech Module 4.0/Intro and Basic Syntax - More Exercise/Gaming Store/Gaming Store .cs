using System;
using System.Collections.Generic;

namespace Gaming_Store
{
    class Program
    {
        static void Main()
        {
            var dictionary = new Dictionary<string, double>();
            dictionary.Add("OutFall 4", 39.99);
            dictionary.Add("CS: OG", 15.99);
            dictionary.Add("Zplinter Zell", 19.99);
            dictionary.Add("Honored 2", 59.99);
            dictionary.Add("RoverWatch", 29.99);
            dictionary.Add("RoverWatch Origins Edition", 39.99);
            var budget = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var totalSpent = 0.0;
            while (input!= "Game Time")
            {
                if (dictionary.ContainsKey(input))
                {
                    if (dictionary[input] > budget)
                    {
                        if (budget == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        else Console.WriteLine("Too Expensive");

                    }
                    else if (dictionary[input] <= budget)
                    {
                        totalSpent += dictionary[input];
                        budget -= dictionary[input];
                        Console.WriteLine($"Bought {input}");
                        if (budget == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }
                    }
                }
                else Console.WriteLine("Not Found");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${budget:f2}");
        }
    }
}