using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().ToLower().Split(' ');

        var dictionary = new Dictionary<string, int>();

        foreach (var word in input)
        {
            if (!dictionary.ContainsKey(word))
                dictionary[word] = 0;

                dictionary[word]++;
        }

        var results = new List<string>();

        foreach (var item in dictionary)
        {
            if (item.Value % 2 != 0)
            {
                results.Add(item.Key);
            }
        }
        Console.WriteLine(string.Join(" ", results));
    }
}