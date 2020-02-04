using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (!dictionary.ContainsKey(input[i][j]))
                        dictionary[input[i][j]] = 0;

                    dictionary[input[i][j]]++;
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}