using System;
using System.Collections.Generic;
using System.Linq;

namespace Refactoring
{
    class Refactoring
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<int>();
            list.Add(2);
            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        break;
                    else if (i == j + 1)
                        list.Add(i);

                }
            }
            if (list.Count() >= 1)
            {
                for (int i = 2; i <= n; i++)
                {
                    if (list.Contains(i)) Console.WriteLine($"{i} -> true");
                    else Console.WriteLine($"{i} -> false");
                }
            }

        }
    }
}