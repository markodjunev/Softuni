using System;
using System.Collections.Generic;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main()
        {
            Action<string> appendSir = x => Console.WriteLine($"Sir {x}");

            Console.ReadLine().Split().ToList().ForEach(appendSir);
        }
    }
}
