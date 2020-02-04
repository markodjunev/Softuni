using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
    class Program
    {
        static void Main()
        {
            var dictionary = new Dictionary<char, int>();
            var text = Console.ReadLine().ToCharArray();

            foreach (var ch in text)
            {
                if (!dictionary.ContainsKey(ch))
                    dictionary[ch] = 0;

                dictionary[ch]++;
            }

            foreach (var item in dictionary.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}