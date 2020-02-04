using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var table = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var element = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < element.Length; j++)
                {
                    table.Add(element[j]);
                }
            }

            Console.WriteLine(string.Join(" ", table.OrderBy(x=>x)));

        }
    }
}