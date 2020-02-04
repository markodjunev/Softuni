using System;
using System.Collections.Generic;
using System.Linq;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!dictionary.ContainsKey(continent))
                    dictionary[continent] = new Dictionary<string, List<string>>();
               
                if(!dictionary[continent].ContainsKey(country))
                    dictionary[continent][country] = new List<string>();

                dictionary[continent][country].Add(city);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var values in item.Value)
                {
                    Console.WriteLine($"  {values.Key} -> {string.Join(", ",values.Value)}");
                }
            }

        }
    }
}