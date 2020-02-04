using System;
using System.Collections.Generic;

namespace Orders
{
    class Orders
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, double[]>();
            while (input != "buy")
            {
                var tokens = input.Split();
                var product = tokens[0];
                var price = double.Parse(tokens[1]);
                var quantity = double.Parse(tokens[2]);
                if (!dictionary.ContainsKey(product))
                    dictionary.Add(product, new double[2]);

                dictionary[product][0] = price;
                dictionary[product][1] += quantity;

                input = Console.ReadLine();
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0]*item.Value[1]:f2}");
            }
        }
    }
}