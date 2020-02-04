using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main()
        {
            var dictionary = new Dictionary<string, Dictionary<string, double>>();
            var input = Console.ReadLine();

            while (input != "Revision")
            {
                var tokens = input.Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);
                var shop = tokens[0];
                var product = tokens[1];
                var price = double.Parse(tokens[2]);

                if(!dictionary.ContainsKey(shop))
                    dictionary[shop] = new Dictionary<string, double>();

                dictionary[shop][product] = price;

                input = Console.ReadLine();
            }

            foreach (var item in dictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var values in item.Value)
                {
                    Console.WriteLine($"Product: {values.Key}, Price: {values.Value}");
                }
            }

        }
    }
}