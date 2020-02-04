using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var dictionary = new Dictionary<string, List<string>>();
            while (input != "Lumpawaroo")
            {
                if (input.Contains('|'))
                {
                    string[] data = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string side = data[0];
                    string user = data[1];
                    if (!dictionary.ContainsKey(side))
                    {
                        dictionary[side] =  new List<string>();
                    }
                    if (!dictionary[side].Contains(user) &&
                        !dictionary.Values.Any(x => x.Contains(user)))
                    {
                        dictionary[side].Add(user);
                    }

                }
                else if (input.Contains("->"))
                {
                    string[] data = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string user = data[0];
                    string side = data[1];

                    if (!dictionary.Any(x => x.Value.Contains(user)))
                    {
                        if (!dictionary.ContainsKey(side))
                            dictionary[side] = new List<string>();

                        dictionary[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        foreach (var s in dictionary)
                        {
                            if (s.Value.Contains(user))
                            {
                                s.Value.Remove(user);
                            }
                        }

                        if (!dictionary.ContainsKey(side))
                            dictionary[side] = new List<string>();

                        dictionary[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var side in dictionary.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count()}");
                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}