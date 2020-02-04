using System;
using System.Collections.Generic;

namespace Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = Console.ReadLine();
            list.Add(a);
            list.Add(b);
            list.Add(c);
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}