﻿using System;
using System.Linq;

namespace Reverse_And_Exclude
{
    class Program
    {
        static void Main()
        {
            var array = Console.ReadLine()
                .Split()
                .Select(int.Parse);

            int number = int.Parse(Console.ReadLine());

            Predicate<int> filter = x => x % number != 0;
            Func<int, bool> filterFunc = x => filter(x);

            array = array
                .Where(filterFunc);

            Console.WriteLine(String.Join(" ", array.Reverse()));
        }
    }
}