using System;
using System.Collections.Generic;

namespace List_of_Products
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var product = Console.ReadLine();
                list.Add(product);
            }
            list.Sort();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}