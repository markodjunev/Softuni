using System;
using System.Collections.Generic;

namespace Repeat_String
{
    class Program
    {
        private static new List<string> Result(string input, int n)
        {
            var list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add(input);
            }
            return list;
        }
        static void Main()
        {
            var input = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join("", Result(input, n)));
        }
    }
}