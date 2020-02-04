using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}