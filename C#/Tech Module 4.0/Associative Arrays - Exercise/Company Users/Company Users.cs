using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                var tokens = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                var company = tokens[0];
                var id = tokens[1];
                if (!dictionary.ContainsKey(company))
                    dictionary[company] = new List<string>();

                if (!dictionary[company].Contains(id))
                    dictionary[company].Add(id);

                input = Console.ReadLine();
            }

            foreach (var item in dictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var value in item.Value)
                {
                    Console.WriteLine($"-- {value}");
                }    
            }

        }
    }
}