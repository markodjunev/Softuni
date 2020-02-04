using System;
using System.Collections.Generic;
using System.Linq;

namespace _1
{
    class Program
    {
        static void Main()
        {
            var dictionary = new Dictionary<string, List<string>>();
            var input = Console.ReadLine().Split(new []{" | "},StringSplitOptions.RemoveEmptyEntries);
            var words = Console.ReadLine().Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = Console.ReadLine();
            if (command == "List")
            {
                var list = new List<string>();
                for (int i = 0; i < input.Length; i++)
                {
                    var curPart = input[i].Split(new[] { ":", ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var key = curPart[0];
                    list.Add(key);
                }
                list = list.Distinct().ToList();
                list = list.OrderBy(x => x).ToList();
                Console.WriteLine(string.Join(" ", list));
            }
           
            else if (command == "End")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    var curPart = input[i].Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var key = curPart[0];
                    if (words.Contains(key))
                    {
                         if (!dictionary.ContainsKey(key))
                         {
                             dictionary[key] = new List<string>();
                         }

                         dictionary[key].Add(curPart[1]);
                     
                    }
                }

                foreach (var item in dictionary.OrderBy(x=>x.Key))
                {
                    Console.WriteLine(item.Key);
                    foreach (var value in item.Value.OrderByDescending(x=>x.Length))
                    {
                        Console.WriteLine($" -{value}");
                    }
                }

            }           
        }
    }
}