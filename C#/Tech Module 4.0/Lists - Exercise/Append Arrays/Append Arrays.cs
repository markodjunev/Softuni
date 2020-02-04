using System;
using System.Collections.Generic;
using System.Linq;

namespace solutions
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split('|').ToList();
            numbers.Reverse();
            var result = new List<string>();

            foreach (var item in numbers)
            {
                result.AddRange(item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}