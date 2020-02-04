using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"( ?\+359 2 \d{3} \d{4})|(\+ ?359-2-\d{3}-\d{4})";
            MatchCollection regex = Regex.Matches(input, pattern);
            var list = new List<string>();

            foreach (Match item in regex)
            {
                list.Add(item.Value.Trim());
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}