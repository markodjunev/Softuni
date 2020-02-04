using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, List<string>>();

            while (input != "END")
            {
                var tokens = input.Split(new[] {"->", ","}, StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];
                var store = tokens[1];

                if (command == "Remove")
                {
                    if (dictionary.ContainsKey(store))
                    {
                        dictionary.Remove(store);
                    }
                }
                else if (command == "Add")
                {
                    if (!dictionary.ContainsKey(store))
                    {
                        dictionary[store] = new List<string>();
                    }

                    for (int i = 2; i < tokens.Length; i++)
                    {
                        var item = tokens[i];
                        dictionary[store].Add(item);
                    }
                }
                input = Console.ReadLine();
            }

            var orderedDictionary = dictionary.OrderByDescending(x => x.Value.Count).ThenByDescending(x=>x.Key);
            Console.WriteLine("Stores list:");
            foreach (var item in orderedDictionary)
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"<<{item2}>>");
                }
            }

        }
    }
}