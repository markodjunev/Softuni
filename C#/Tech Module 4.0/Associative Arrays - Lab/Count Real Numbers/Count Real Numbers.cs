using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var dictionary = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dictionary.ContainsKey(numbers[i]))
                    dictionary[numbers[i]] = 0;

                dictionary[numbers[i]]++;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}