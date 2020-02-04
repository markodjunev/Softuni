using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!dictionary.ContainsKey(num))
                    dictionary[num] = 0;
                dictionary[num]++;
            }

            foreach (var item in dictionary.Where(x=>x.Value % 2 == 0))
            {
                Console.WriteLine(item.Key);
            }

        }
    }
}