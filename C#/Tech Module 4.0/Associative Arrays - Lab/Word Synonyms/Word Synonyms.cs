using System;
using System.Collections.Generic;
using System.Linq;

namespace Word_Synonyms
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                var synonym = Console.ReadLine();
                if (!dictionary.ContainsKey(word))
                    dictionary[word] = new List<string>();

                dictionary[word].Add(synonym);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }

        }
    }
}