using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] {" -> ", ","}, StringSplitOptions.RemoveEmptyEntries);

                var color = input[0];

                if(!dictionary.ContainsKey(color))
                    dictionary[color] = new Dictionary<string, int>();

                for (int j = 1; j <= input.Length - 1; j++)
                {
                    var type = input[j];
                    if (!dictionary[color].ContainsKey(type))
                        dictionary[color][type] = 0;

                    dictionary[color][type]++;
                }
            }


            var text = Console.ReadLine().Split();
            var color2 = text[0];
            var clothing = text[1];

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var value in item.Value)
                {
                    if(item.Key == color2 && value.Key == clothing)
                        Console.WriteLine($"* {value.Key} - {value.Value} (found!)");
                    else
                        Console.WriteLine($"* {value.Key} - {value.Value}");                  
                }
            }

        }
    }
}