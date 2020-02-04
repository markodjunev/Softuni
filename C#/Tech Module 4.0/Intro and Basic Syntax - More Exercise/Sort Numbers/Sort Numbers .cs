using System;
using System.Collections.Generic;

namespace Sort_Numbers
{
    class Program
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var list = new List<int>();
            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Sort();
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}