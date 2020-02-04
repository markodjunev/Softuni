using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main()
        {
            var dictionary = new Dictionary<string, int>();

            while (true)
            {
                var resource = Console.ReadLine();
                if (resource == "stop")
                    break;
                var quantity = int.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(resource))
                    dictionary[resource] = 0;

                dictionary[resource] += quantity;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}